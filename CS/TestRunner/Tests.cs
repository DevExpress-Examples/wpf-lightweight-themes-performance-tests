using NUnit.Framework;
using System.Diagnostics;
using System.Text;

namespace TestRunner;

[TestFixture]
public class Tests {
    //Set the required configuration
    public static TestConfigurations TestConfigurations = TestConfigurations.All;
    public static readonly TestViews TestViews = TestViews.All;
    
    public static readonly bool TestColdStart = true;
    public static readonly bool TestHotStart = true;
    
    public static readonly bool TestLegacyThemes_v22_2 = true;
    public static readonly bool TestLegacyThemes = true;
    public static readonly bool TestLegacyThemesAfterPreload = false;
    public static readonly bool TestLightweightThemes = true;

    public static readonly bool EnableWarmingUp = true;
    public static readonly int ColdStartRunCount = 3;
    public static readonly int HotStartRunCount = 2;

    [Test]
    public static void Run() => RunTests();


    static readonly string PathNgen = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\ngen.exe";
    static readonly string PathRoot = Path.Combine(Environment.CurrentDirectory, @"..\..\");
    static readonly string PathPerfAppBin = Path.Combine(PathRoot, @"PerfApp\bin\NETFramework\");
    static readonly string PathPerfAppBin_v22_2 = Path.Combine(PathRoot, @"PerfApp\bin\NETFramework_v22.2\");
    static readonly string PathPerfAppBinNet7 = Path.Combine(PathRoot, @"PerfApp\bin\Net7\");
    static readonly string PathPerfAppBinNet7_v22_2 = Path.Combine(PathRoot, @"PerfApp\bin\Net7_v22.2\");
    static readonly string PathPerfApp = $"{PathPerfAppBin}PerfApp.exe";
    static readonly string PathPerfApp_v22_2 = $"{PathPerfAppBin_v22_2}PerfApp.exe";
    static readonly string PathPerfAppNet7 = $"{PathPerfAppBinNet7}PerfApp.exe";
    static readonly string PathPerfAppNet7_v22_2 = $"{PathPerfAppBinNet7_v22_2}PerfApp.exe";
    static readonly string PathPerfAppNet7_ReadyToRun = Path.Combine(PathRoot, $@"{PathPerfAppBinNet7}win-x86\publish\PerfApp.exe");
    static readonly string PathPerfAppNet7_v22_2_ReadyToRun = Path.Combine(PathRoot, $@"{PathPerfAppBinNet7_v22_2}win-x86\publish\PerfApp.exe");
    static readonly string PathPerfAppNet7_csproj = Path.Combine(PathRoot, @"PerfApp\PerfApp.Net7.csproj");
    static readonly string PathPerfAppNet7_v22_2_csproj = Path.Combine(PathRoot, @"PerfApp\PerfApp.Net7.v22.2.csproj");
    static readonly string PathResults = Path.Combine(PathRoot, "Results.md");

    static bool TestNETFramework => TestConfigurations.HasFlag(TestConfigurations.NETFramework) || TestConfigurations.HasFlag(TestConfigurations.NETFrameworkWithNGen);
    static bool TestNet7 => TestConfigurations.HasFlag(TestConfigurations.NET7) || TestConfigurations.HasFlag(TestConfigurations.NET7ReadyToRun);
    static bool TestLatestVersion => TestLegacyThemes || TestLegacyThemesAfterPreload || TestLightweightThemes;
    static bool Test22_2 => TestLegacyThemes_v22_2;

    static readonly Stopwatch Stopwatch = Stopwatch.StartNew();
    static readonly List<TestResults> ColdStartResults = new();
    static readonly List<TestResults> HotStartResults = new();

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
        if (TestLatestVersion && TestNETFramework)
            Check(PathPerfAppBin, "DevExpress.Data.v23.1.dll");
        if (TestLatestVersion && TestNet7)
            Check(PathPerfAppBinNet7, "DevExpress.Data.v23.1.dll");
        if (Test22_2 && TestNETFramework)
            Check(PathPerfAppBin_v22_2, "DevExpress.Data.v22.2.dll");
        if (Test22_2 && TestNet7)
            Check(PathPerfAppBinNet7_v22_2, "DevExpress.Data.v22.2.dll");
        static void Check(string pathBin, string dataDll) {
            if (!File.Exists($"{pathBin}{dataDll}"))
                throw new Exception($"Cannot find '{dataDll}' in '{pathBin}'");
        }
    }
    static void SetUp(Configuration configuration) {
        if (configuration == Configuration.NETFramework || configuration == Configuration.NETFrameworkWithNGen) {
            if (TestLatestVersion)
                Ngen(DXVersion.Latest, configuration == Configuration.NETFrameworkWithNGen);
            if (Test22_2)
                Ngen(DXVersion.v22_2, configuration == Configuration.NETFrameworkWithNGen);
        }
        if (configuration == Configuration.NET7ReadyToRun) {
            if (TestLatestVersion)
                PublishNET7ReadyToRun(DXVersion.Latest);
            if (Test22_2)
                PublishNET7ReadyToRun(DXVersion.v22_2);
        }

        if (EnableWarmingUp) {
            if (TestLatestVersion)
                RunCore(TestView.Main, TestType.ColdStart, TestMode.LegacyThemes, DXVersion.Latest, configuration, 1);
            if (Test22_2)
                RunCore(TestView.Main, TestType.ColdStart, TestMode.LegacyThemes, DXVersion.v22_2, configuration, 1);
            Thread.Sleep(2000);
        }
    }
    static void RunTests(Configuration configuration, TestType testType) {
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

    static string GetAppPath(DXVersion appVersion, Configuration config) {
        switch (appVersion) {
            case DXVersion.Latest:
                return config switch {
                    Configuration.NETFramework => PathPerfApp,
                    Configuration.NETFrameworkWithNGen => PathPerfApp,
                    Configuration.NET7 => PathPerfAppNet7,
                    Configuration.NET7ReadyToRun => PathPerfAppNet7_ReadyToRun,
                    _ => throw new NotImplementedException(),
                };
            case DXVersion.v22_2:
                return config switch {
                    Configuration.NETFramework => PathPerfApp_v22_2,
                    Configuration.NETFrameworkWithNGen => PathPerfApp_v22_2,
                    Configuration.NET7 => PathPerfAppNet7_v22_2,
                    Configuration.NET7ReadyToRun => PathPerfAppNet7_v22_2_ReadyToRun,
                    _ => throw new NotImplementedException(),
                };
            default: throw new NotImplementedException();
        }
    }
    static void Ngen(DXVersion appVersion, bool install) {
        var appPath = GetAppPath(appVersion, Configuration.NETFramework);
        var args = install ? $"install \"{appPath}\" /nologo" : $"uninstall \"{appPath}\" /nologo";

        using var process = new Process {
            StartInfo = new ProcessStartInfo {
                FileName = PathNgen,
                Arguments = args,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                Verb = "runas",
                WorkingDirectory = Path.GetDirectoryName(appPath),
            }
        };
        process.Start();
        process.WaitForExit();
    }
    static void PublishNET7ReadyToRun(DXVersion appVersion) {
        var csproj = appVersion == DXVersion.Latest
            ? PathPerfAppNet7_csproj
            : PathPerfAppNet7_v22_2_csproj;
        using var process = new Process {
            StartInfo = new ProcessStartInfo {
                FileName = "dotnet",
                Arguments = $"publish {csproj} --configuration Release --runtime win-x86 --self-contained -p:PublishReadyToRun=true",
                UseShellExecute = true,
            }
        };
        process.Start();
        process.WaitForExit();
    }
    static TestResult RunTestCore(Configuration configuration, TestView testView, TestType testType, int runCount) {
        var r1 = TestLegacyThemes_v22_2
            ? RunCore(testView, testType, TestMode.LegacyThemes, DXVersion.v22_2, configuration, runCount)
            : null;
        var r2 = TestLegacyThemes && testType == TestType.ColdStart
            ? RunCore(testView, testType, TestMode.LegacyThemes, DXVersion.Latest, configuration, runCount)
            : null;
        var r3 = TestLegacyThemesAfterPreload && testType == TestType.ColdStart
            ? RunCore(testView, testType, TestMode.LegacyThemesAfterPreload, DXVersion.Latest, configuration, runCount)
            : null;
        var r4 = TestLightweightThemes
            ? RunCore(testView, testType, TestMode.LightweightThemes, DXVersion.Latest, configuration, runCount)
            : null;

        var res = new TestResult() {
            TestName = testView.ToString(),
            v22_2 = r1,
            Latest = r2,
            LatestAfterPreload = r3,
            LW = r4
        };
        return res;
    }
    static RunResults RunCore(TestView testView, TestType testType, TestMode testMode, DXVersion version, Configuration config, int runCount) {
        RunResult RunCore() {
            var path = GetAppPath(version, config);
            var args = $"{testView} {testType} {testMode}";
            var startInfo = new ProcessStartInfo(path, args) {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                WorkingDirectory = Path.GetDirectoryName(path),
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
        return new RunResults(res);
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
                Configuration.NET7 => "NET 7",
                Configuration.NET7ReadyToRun => "NET 7, ReadyToRun",
                _ => throw new NotImplementedException(),
            };
            return $"# {testType}, {config}";
        }

        static string PrintTable_Performance(List<TestResult> results) {
            StringBuilder b = new();
            b.Append(PrintTableHeader(results));
            foreach (var r in results) {
                b.AppendLine();
                var row = PrintTableRow(
                    r.TestName,
                    r.v22_2?.Mean,
                    r.Latest?.Mean,
                    r.LW?.Mean,
                    "ms");
                b.Append(row);
            }
            return b.ToString();
        }
        static string PrintTable_Memory(List<TestResult> results) {
            StringBuilder b = new();
            b.AppendLine(PrintTableHeader(results));
            foreach (var r in results) {
                var row = PrintTableRow(
                    r.TestName,
                    r.v22_2?.MeanTotalMemory,
                    r.Latest?.MeanTotalMemory,
                    r.LW?.MeanTotalMemory,
                    "KB");
                b.AppendLine(row);
            }
            return b.ToString();
        }
        static string PrintTableHeader(List<TestResult> results) {
            var r = results.First();
            bool v22_2 = r.v22_2 != null;
            bool latest = r.Latest != null;
            bool lw = r.LW != null;

            StringBuilder b = new();
            b.AppendLine(PrintTableRow(
                "Test",
                v22_2 ? "v22.2 (baseline)" : null,
                latest ? "v23.1" : null,
                lw ? "LWThemes v23.1" : null));
            b.Append(PrintTableRow(
                "----",
                v22_2 ? "----------------" : null,
                latest ? "-----" : null,
                lw ? "--------------" : null));
            return b.ToString();
        }
        static string PrintTableRow(string? testName, double? v22_2, double? latest, double? lw, string unit) {
            double? m1 = v22_2;
            double? m2 = latest;
            double? m3 = lw;

            Func<double?, double?, double?> calcChange = (x, y) => x == null || y == null ? null : (x - y) / x;
            double? change2 = calcChange(m1, m2);
            double? change3 = calcChange(m1, m3);

            var change2Str = change2 != null ? $", {change2:P2}" : null;
            var change3Str = change3 != null ? $", {change3:P2}" : null;

            var r1 = m1 != null ? $"{(int)m1} {unit}" : "";
            var r2 = m2 != null ? $"{(int)m2} {unit}{change2Str}" : "";
            var r3 = m3 != null ? $"{(int)m3} {unit}{change3Str}" : "";

            return PrintTableRow(testName, r1, r2, r3);
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
                PrintResult(r.v22_2, "v22.2");
                PrintResult(r.Latest, "v23.1");
                PrintResult(r.LW, "LWThemes v23.1");
                PrintResult(r.LatestAfterPreload, "v23.1 with Preload");
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
    }
    class TestResult {
        public string? TestName { get; init; }
        public RunResults? v22_2 { get; init; }
        public RunResults? Latest { get; init; }
        public RunResults? LW { get; init; }
        public RunResults? LatestAfterPreload { get; init; }
    }
    class RunResults {
        public List<RunResult> Results { get; }
        public double Mean { get; }
        public double MeanPreload { get; }
        public double MeanTotalMemory { get; }

        public RunResults(List<RunResult> results) {
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
    NETFramework = 0,
    NETFrameworkWithNGen = 1 << 0,
    NET7 = 1 << 1,
    NET7ReadyToRun = 1 << 2,
    All = NETFramework | NETFrameworkWithNGen | NET7 | NET7ReadyToRun
}
[Flags]
public enum TestViews {
    Main = 0,
    Editors = 1 << 0,
    Grid = 1 << 1,
    Ribbon = 1 << 2,
    Bars = 1 << 3,
    RichEdit = 1 << 4,
    Scheduler = 1 << 5,
    Charts = 1 << 6,
    All = Main | Editors | Grid | Ribbon | Bars | RichEdit | Scheduler | Charts
}
public enum Configuration { NETFramework, NETFrameworkWithNGen, NET7, NET7ReadyToRun }
public enum DXVersion { Latest, v22_2 }
public enum TestView { Editors, Grid, Ribbon, Bars, RichEdit, Scheduler, Charts, Main }
public enum TestMode { LightweightThemes, LegacyThemes, LegacyThemesAfterPreload }
public enum TestType { ColdStart, HotStart }