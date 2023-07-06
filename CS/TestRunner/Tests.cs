using NUnit.Framework;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace TestRunner;

[TestFixture]
public class Tests {
    //Set the required configuration
    public static TestConfigurations TestConfigurations = TestConfigurations.All;
    public static readonly TestViews TestViews = TestViews.All;
    public static readonly (DXVersion Version, TestMode Mode, bool IsBaseline)[] TestsList = new[] {
        (DXVersion.v22_2, TestMode.LegacyThemes, true),
        (DXVersion.v23_1, TestMode.LegacyThemes, false),
        (DXVersion.v23_1, TestMode.LightweightThemes, false),
    };
    public static readonly bool TestColdStart = true;
    public static readonly bool TestHotStart = true;
    public static readonly bool EnableWarmingUp = true;
    public static readonly int ColdStartRunCount = 4;
    public static readonly int HotStartRunCount = 3;

    [Test]
    public static void Run() => RunTests();
    [Test, Explicit]
    public static void UnNgen() => UnNgenAll();

    static readonly IEnumerable<DXVersion> AllVersions = Enum.GetValues(typeof(DXVersion)).OfType<DXVersion>();
    static readonly IEnumerable<DXVersion> AllTestingVersions = TestsList.Select(x => x.Version).Distinct().ToList();
    static bool TestNETFramework => TestConfigurations.HasFlag(TestConfigurations.NETFramework) || TestConfigurations.HasFlag(TestConfigurations.NETFrameworkWithNGen);
    static bool TestNet7 => TestConfigurations.HasFlag(TestConfigurations.NET7) || TestConfigurations.HasFlag(TestConfigurations.NET7ReadyToRun);

    static readonly string PathRoot = Path.Combine(Environment.CurrentDirectory, @"..\..\");
    static readonly string PathResults = Path.Combine(PathRoot, "Results.md");
    static readonly string PathNgen = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\ngen.exe";

    static readonly Stopwatch Stopwatch = Stopwatch.StartNew();
    static readonly List<TestResults> ColdStartResults = new();
    static readonly List<TestResults> HotStartResults = new();

    static void UnNgenAll() {
        foreach(var v in AllVersions) {
            Ngen(v, false);
        }
    }
    static void RunTests() {
        CheckBuild();

        Exception? exception = null;
        try {
            if (TestConfigurations.HasFlag(TestConfigurations.NETFramework))
                RunCore(Configuration.NETFramework);
            if (TestConfigurations.HasFlag(TestConfigurations.NET7))
                RunCore(Configuration.NET7);
            if (TestConfigurations.HasFlag(TestConfigurations.NETFrameworkWithNGen))
                RunCore(Configuration.NETFrameworkWithNGen);
            if (TestConfigurations.HasFlag(TestConfigurations.NET7ReadyToRun))
                RunCore(Configuration.NET7ReadyToRun);
        } catch (Exception e) {
            exception = e;
            throw;
        } finally {
            SaveResults(ColdStartResults.Concat(HotStartResults), exception);
            if(TestNETFramework) {
                foreach(var ver in AllTestingVersions) {
                    Ngen(ver, false);
                }
            }
        }

        static void RunCore(Configuration configuration) {
            SetUp(configuration);
            if (TestColdStart) {
                RunTests(configuration, TestType.ColdStart);
                SaveResults(ColdStartResults.Concat(HotStartResults), null);
            }
            if (TestHotStart) {
                RunTests(configuration, TestType.HotStart);
                SaveResults(ColdStartResults.Concat(HotStartResults), null);
            }
        }
    }
    static void CheckBuild() {
        foreach(var ver in AllTestingVersions) {
            if(NeedTesting(ver)) {
                if(TestNETFramework) AppInfo.GetNETFramework(ver).CheckBin();
                if(TestNet7) AppInfo.GetNET7(ver).CheckBin();
            }
        }
    }
    static void SetUp(Configuration configuration) {
        if (configuration == Configuration.NETFramework || configuration == Configuration.NETFrameworkWithNGen) {
            foreach(var ver in AllTestingVersions) {
                Ngen(ver, configuration == Configuration.NETFrameworkWithNGen);
            }
        }
        if (configuration == Configuration.NET7ReadyToRun) {
            foreach(var ver in AllTestingVersions) {
                PublishNET7ReadyToRun(ver);
            }
        }

        if (EnableWarmingUp) {
            foreach(var ver in AllTestingVersions) {
                Console.WriteLine($"WarmingUp {ver} ...");
                RunCore(TestView.Main, TestType.ColdStart, TestMode.LegacyThemes, ver, configuration, 1);
            }
            Thread.Sleep(2000);
            Console.WriteLine($"WarmingUp finished.");
        }
    }
    static void RunTests(Configuration configuration, TestType testType) {
        Console.WriteLine($"Running tests ({configuration}, {testType}) ...");
        
        var results = testType == TestType.ColdStart ? ColdStartResults : HotStartResults;
        results.Add(new TestResults(configuration, testType));

        if (TestViews.HasFlag(TestViews.Main))
            RunCore(results.Last(), configuration, testType, TestView.Main);
        Enum.GetValues(typeof(TestViews))
            .OfType<TestViews>()
            .Except(new[] { TestViews.Main, TestViews.All })
            .Where(x => TestViews.HasFlag(x))
            .OrderBy(x => x.ToString())
            .ToList()
            .ForEach(x => RunCore(results.Last(), configuration, testType, ToTestView(x)));

        static void RunCore(TestResults results, Configuration configuration, TestType testType, TestView testView) {
            var runCount = testType == TestType.ColdStart ? ColdStartRunCount : HotStartRunCount;
            results.Add(RunTestCore(configuration, testView, testType, runCount));
        }
    }
    static void SaveResults(IEnumerable<TestResults> results, Exception? exception) {
        StringBuilder b = new();

        results
            .ToList()
            .ForEach(x => {
                b.Append(x.GetReport());
                b.AppendLine();
                b.AppendLine();
            });

        if (exception != null)
            b.AppendLine(exception.ToString());

        b.AppendLine();
        b.AppendLine($"Test execution complete. Duration: {Stopwatch.Elapsed.ToString(@"hh\:mm\:ss")}");

        var res = b.ToString();
        File.WriteAllText(PathResults, res);
    }
    static TestView ToTestView(TestViews x) {
        switch (x) {
            case TestViews.Main: return TestView.Main;
            case TestViews.Editors: return TestView.Editors;
            case TestViews.Grid: return TestView.Grid;
            case TestViews.Ribbon: return TestView.Ribbon;
            case TestViews.Bars: return TestView.Bars;
            case TestViews.RichEdit: return TestView.RichEdit;
            case TestViews.Scheduler: return TestView.Scheduler;
            case TestViews.Charts: return TestView.Charts;
            default: throw new Exception();
        };
    }
    static bool NeedTesting(DXVersion version) {
        return TestsList.Any(x => x.Version == version);
    }

    static void Ngen(DXVersion appVersion, bool install) {
        var app = AppInfo.GetNETFramework(appVersion);
        if(!Directory.Exists(app.Bin)) return;
        var dlls = Directory.GetFiles(app.Bin, "*.dll", SearchOption.TopDirectoryOnly);

        Console.WriteLine(install ? $"Ngen install {appVersion} ..." : $"Ngen uninstall {appVersion} ...");
        if(!install) NgenCore(null, app.Exe, false);
        foreach(var dll in dlls)
            NgenCore(dll, app.Exe, install);
        if(install) NgenCore(null, app.Exe, true);

        static void NgenCore(string? dll, string exe, bool install) {
            var cmd = install ? "install" : "uninstall";
            var args = dll != null
                    ? $"{cmd} \"{dll}\" /ExeConfig:\"{exe}\" /nologo"
                    : $"{cmd} \"{exe}\" /nologo";

            using var process = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = PathNgen,
                    Arguments = args,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    Verb = "runas",
                    WorkingDirectory = Path.GetDirectoryName(exe),
                }
            };
            process.Start();
            process.WaitForExit();
        } 
    }
    static void PublishNET7ReadyToRun(DXVersion appVersion) {
        Console.WriteLine($"dotnet publish {appVersion} ...");

        var csproj = AppInfo.GetNET7(appVersion).Csproj;
        using var process = new Process {
            StartInfo = new ProcessStartInfo {
                FileName = "dotnet",
                Arguments = $"publish {csproj} --configuration Release --runtime win-x86 --self-contained -p:PublishReadyToRun=true",
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Minimized,
            }
        };
        process.Start();
        process.WaitForExit();
    }
    static TestResult RunTestCore(Configuration configuration, TestView testView, TestType testType, int runCount) {
        var res = new TestResult(testView.ToString());
        foreach(var test in TestsList) {
            var r = RunCore(testView, testType, test.Mode, test.Version, configuration, runCount);
            res.Results.Add(new RunResults(test.Version, test.Mode, test.IsBaseline, r));
        }
        return res;
    }
    static List<RunResult> RunCore(TestView testView, TestType testType, TestMode testMode, DXVersion version, Configuration config, int runCount) {
        RunResult RunCore() {
            var app = AppInfo.Get(version, config);
            var args = $"{testView} {testType} {testMode}";
            var startInfo = new ProcessStartInfo(app.Exe, args) {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                WorkingDirectory = Path.GetDirectoryName(app.Exe),
            };
            using var process = new Process() {
                StartInfo = startInfo
            };
            List<string> res = new();
            process.OutputDataReceived += (s, e) => res.Add(e.Data ?? string.Empty);
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
            return new RunResult(res);
        }

        List<RunResult> res = new();
        for (int i = 0; i < runCount; i++) {
            res.Add(RunCore());
            Thread.Sleep(300);
        }
        return res;
    }
    
    struct AppInfo {
        public static AppInfo GetNETFramework(DXVersion version) => Get(version, Configuration.NETFramework);
        public static AppInfo GetNET7(DXVersion version) => Get(version, Configuration.NET7);
        public static AppInfo Get(DXVersion version, Configuration configuration) {
            var binSubFolderName =
                configuration == Configuration.NETFramework || configuration == Configuration.NETFrameworkWithNGen
                ? "NETFramework_"
                : "NET7_";
            binSubFolderName += version.ToString();
            var binPath = Path.Combine(PathRoot, $@"PerfApp\bin\{binSubFolderName}");
            var exe = configuration == Configuration.NET7ReadyToRun
                ? Path.Combine(binPath, $@"win-x86\publish\PerfApp.exe")
                : Path.Combine(binPath, "PerfApp.exe");
            var csproj = Path.Combine(PathRoot, $@"PerfApp\PerfApp_{binSubFolderName}.csproj");
            return new AppInfo(version, binPath, exe, csproj);
        }

        public DXVersion Version { get; }
        public string Bin { get; }
        public string Exe { get; }
        public string Csproj { get; }
        
        AppInfo(DXVersion version, string bin, string exe, string csproj) {
            Version = version;
            Bin = bin;
            Exe = exe;
            Csproj = csproj;
        }
        public void CheckBin() {
            var version = Version.ToString().Replace("_", ".");
            var dataDll = Path.Combine(Bin, $"DevExpress.Data.{version}.dll");
            if(!File.Exists(dataDll))
                throw new Exception($"Cannot find '{dataDll}' in '{Bin}'");
            if(!File.Exists(Exe))
                throw new Exception($"Cannot find '{Exe}' in '{Bin}'");
        }
    }
    class TestResults {
        List<TestResult> Results { get; } = new();
        TestType TestType { get; }
        Configuration Configuration { get; }

        public TestResults(Configuration configuration, TestType testType) {
            TestType = testType;
            Configuration = configuration;
        }
        public void Add(TestResult r) {
            Results.Add(r);
        }
        public string GetReport() {
            StringBuilder b = new();
            b.AppendLine();
            b.AppendLine(GetHeader(Configuration, TestType));
            b.AppendLine();
            b.AppendLine("**Perfomance**");
            b.AppendLine(PrintTable_Performance(Results));
            if (TestType == TestType.ColdStart) {
                b.AppendLine();
                b.AppendLine("**Memory**");
                b.AppendLine(PrintTable_Memory(Results));
            }
            b.AppendLine();
            b.AppendLine("**Plain Results**");
            b.AppendLine(PrintPlainResults(Results));

            return b.ToString();
        }
        static string GetHeader(Configuration configuration, TestType testType) {
            var config = configuration switch {
                Configuration.NETFramework => ".NET Framework 4.7.2",
                Configuration.NETFrameworkWithNGen => ".NET Framework 4.7.2, Ngen",
                Configuration.NET7 => ".NET 7",
                Configuration.NET7ReadyToRun => ".NET 7, ReadyToRun",
                _ => throw new NotImplementedException(),
            };
            return $"# {testType}, {config}";
        }

        static string PrintTable_Performance(List<TestResult> results) {
            StringBuilder b = new();
            b.Append(PrintTableHeader(results));
            foreach (var r in results) {
                b.AppendLine();
                var row = PrintTableRow(r, PrintType.Performance);
                b.Append(row);
            }
            return b.ToString();
        }
        static string PrintTable_Memory(List<TestResult> results) {
            StringBuilder b = new();
            b.AppendLine(PrintTableHeader(results));
            foreach (var r in results) {
                var row = PrintTableRow(r, PrintType.Memory);
                b.AppendLine(row);
            }
            return b.ToString();
        }
        static string PrintTableHeader(List<TestResult> results) {
            List<string> headerCells = new();
            List<string> separatorCells = new();
            headerCells.Add("Test");
            separatorCells.Add("-----");

            var first = results.First();
            foreach(var r in first.Results) {
                headerCells.Add(GetHeader(r));
                separatorCells.Add("-----");
            }
            StringBuilder b = new();
            b.AppendLine(PrintTableRow(headerCells.ToArray()));
            b.Append(PrintTableRow(separatorCells.ToArray()));
            return b.ToString();
        }
        enum PrintType { Performance, Memory }
        static string PrintTableRow(TestResult result, PrintType printType) {
            List<string> cells = new();
            cells.Add(result.TestName);

            string unit = printType == PrintType.Memory ? "KB" : "ms";
            Func< RunResults, double> getMean = x => printType == PrintType.Performance ? x.Mean : x.MeanTotalMemory;
            Func<double, double, double> calcChange = (x, y) => (x - y) / x;
            var baseline = result.Results.FirstOrDefault(x => x.IsBaseline);
            foreach(var r in result.Results) {
                if(r.Mode == TestMode.LegacyThemesAfterPreload && printType == PrintType.Performance) {
                    var resStr = $"{(int)r.MeanPreload}(preload) + {(int)r.Mean}(startup) {unit}";
                    cells.Add(resStr);
                    continue;
                }
                if(r == baseline || baseline == null) {
                    var resStr = $"{(int)getMean(r)} {unit}";
                    cells.Add(resStr);
                    continue;
                } 
                {
                    double change = calcChange(getMean(baseline), getMean(r));
                    var resStr = $"{(int)getMean(r)} {unit}, {change:P2}";
                    cells.Add(resStr);
                    continue;
                }
            }

            return PrintTableRow(cells.ToArray());
        }
        static string PrintTableRow(params string?[] cells) {
            StringBuilder b = new();
            b.Append("| ");
            foreach (var c in cells) {
                if (string.IsNullOrEmpty(c)) continue;
                b.Append($" {c} |");
            }
            return b.ToString();
        }

        static string PrintPlainResults(List<TestResult> results) {
            StringBuilder b = new();
            b.AppendLine("<details>");
            b.AppendLine("<summary>Results</summary>");

            foreach (var r in results) {
                b.AppendLine();
                b.AppendLine($"**{r.TestName}**");
                foreach(var rr in r.Results) {
                    PrintResult(rr, GetHeader(rr));
                }
            }

            b.AppendLine();
            b.Append("</details>");
            return b.ToString();

            void PrintResult(RunResults? runs, string caption) {
                if (runs == null) return;
                for (int i = 0; i < runs.Results.Count; i++) {
                    var r = runs.Results[i];
                    b.Append($"* **{caption}, #{i + 1}:** ");
                    if (r.PreloadElapsedMilliseconds > 0) {
                        b.Append($"Preload Time: {r.PreloadElapsedMilliseconds} ms, ");
                        b.Append($"Time after Preload: {r.ElapsedMilliseconds} ms");
                    } else {
                        b.Append($"Time: {r.ElapsedMilliseconds} ms");
                    }

                    if (r.TotalMemoryKB > 0)
                        b.Append($", TotalMemory: {r.TotalMemoryKB} KB");
                    b.AppendLine();
                }
            }
        }
        static string GetHeader(RunResults r) {
            var ver = r.Version.ToString().Replace("_", ".");
            var mode = TestModeToString(r.Mode);
            return r.IsBaseline ? $"{ver} {mode} (baseline)" : $"{ver} {mode}";

            static string TestModeToString(TestMode mode) {
                switch(mode) {
                    case TestMode.LegacyThemes: return "";
                    case TestMode.LegacyThemesAfterPreload: return "With Preload";
                    case TestMode.LightweightThemes: return "LW Themes";
                    default: throw new NotImplementedException();
                }
            }
        }
    }
    class TestResult {
        public string TestName { get; init; }
        public List<RunResults> Results { get; } = new();
        public TestResult(string testName) {
            TestName = testName;
        }
    }
    class RunResults {
        public bool IsBaseline { get; }
        public DXVersion Version { get; }
        public TestMode Mode { get; }
        public List<RunResult> Results { get; }
        public double Mean { get; }
        public double MeanPreload { get; }
        public double MeanTotalMemory { get; }

        public RunResults(DXVersion version, TestMode mode, bool isBaseline, List<RunResult> results) {
            Version = version;
            Mode = mode;
            IsBaseline = isBaseline;
            Results = results;
            Mean = Results.Sum(x => x.ElapsedMilliseconds) / Results.Count;
            MeanTotalMemory = Results.Sum(x => x.TotalMemoryKB) / Results.Count;
            if (Results.Any(x => x.PreloadElapsedMilliseconds > 0))
                MeanPreload = Results.Sum(x => x.PreloadElapsedMilliseconds) / Results.Count;
        }
        public override string ToString() {
            StringBuilder r = new();
            r.Append("Elapsed: ");
            r.Append(string.Join(", ", Results.Select(x => $"{x.ElapsedMilliseconds} ms")));
            if (Results.Any(x => x.PreloadElapsedMilliseconds > 0)) {
                r.AppendLine();
                r.Append("Preload: ");
                r.Append(string.Join(", ", Results.Select(x => $"{x.PreloadElapsedMilliseconds} ms")));
            }
            if (Results.Any(x => x.TotalMemoryKB > 0)) {
                r.AppendLine();
                r.Append("TotalMemory: ");
                r.Append(string.Join(", ", Results.Select(x => $"{x.TotalMemoryKB} KB")));
            }
            return r.ToString();
        }
    }
    class RunResult {
        public int ElapsedMilliseconds { get; }
        public int PreloadElapsedMilliseconds { get; }
        public int TotalMemoryKB { get; }

        public RunResult(List<string> data) {
            var d = data.Single(x => x.StartsWith("ElapsedMilliseconds: "));
            d = d.Remove(0, "ElapsedMilliseconds: ".Length);
            ElapsedMilliseconds = int.Parse(d);

            d = data.FirstOrDefault(x => x.StartsWith("PreloadElapsedMilliseconds: "));
            d = d?.Remove(0, "PreloadElapsedMilliseconds: ".Length);
            PreloadElapsedMilliseconds = d != null ? int.Parse(d) : 0;

            d = data.FirstOrDefault(x => x.StartsWith("TotalMemoryKB: "));
            d = d?.Remove(0, "TotalMemoryKB: ".Length);
            TotalMemoryKB = d != null ? int.Parse(d) : 0;
        }
    }
}


[Flags]
public enum TestConfigurations {
    NETFramework = 1 << 0,
    NETFrameworkWithNGen = 1 << 1,
    NET7 = 1 << 2,
    NET7ReadyToRun = 1 << 3,
    All = NETFramework | NETFrameworkWithNGen | NET7 | NET7ReadyToRun
}
[Flags]
public enum TestViews {
    Main = 1 << 0,
    Editors = 1 << 1,
    Grid = 1 << 2,
    Ribbon = 1 << 3,
    Bars = 1 << 4,
    RichEdit = 1 << 5,
    Scheduler = 1 << 6,
    Charts = 1 << 7,
    All = Main | Editors | Grid | Ribbon | Bars | RichEdit | Scheduler | Charts
}

public enum Configuration { NETFramework, NETFrameworkWithNGen, NET7, NET7ReadyToRun }
public enum DXVersion { v22_2, v23_1 }
public enum TestView { Editors, Grid, Ribbon, Bars, RichEdit, Scheduler, Charts, Main }
public enum TestMode { LightweightThemes, LegacyThemes, LegacyThemesAfterPreload }
public enum TestType { ColdStart, HotStart }