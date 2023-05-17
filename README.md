# WPF Lightweight Themes - Performance Tests

In v23.1, we optimize our existing themes and introduced new lightweight themes that are optimized for speed and memory consumption. This sample application allows you to test our performance enhancements on your machine.

## Solution Structure

The solution contains 5 projects:

* PerfApp
* PerfApp.Net7
* PerfApp.v22.2
* PerfApp.Net7.v22.2
* TestRunner

First 4 projects have the same UI but use different versions of DevExpress controls (23.1 and 22.2) and different frameworks (.NET Framework v4.7.2 and .NET 7). You can run each project separately and use settings defined in `App.xaml.cs` files to change the configuration:

```cs
public static bool IsTestRun { get; private set; } = false;
public static TestView TestView { get; private set; } = TestView.Default;
public static TestType TestType { get; private set; } = TestType.ColdStart;
public static TestMode TestMode { get; private set; } = TestMode.LightweightThemes;
public static bool AutoClose => IsTestRun;
public static string ThemeName = "Office2019Colorful";
public static bool MemoryMonitoring => IsTestRun && TestType == TestType.ColdStart;
static int HotStartRunCount => 5;
```

The opened window's title bar displays the startup time in milliseconds.

The **TestRunner** project contains the NUnit test that runs PerfApp applications one by one based on settings specified in the `Tests.cs` file:

```cs
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
```

## Run Tests

Follow the steps below to run tests:

1. Open the `ComponentStartupTests.sln` solution.
2. Build the solution in the **Release** configuration.
3. (Recommended) Close all opened applications except for the Visual Studio.
4. Run tests. We recommend that you use the CodeRush Visual Studio extension. In this case you can right-click the **TestRunner** project and select **Run Tests**.

After all tests have passed, the application creates the `Results.md` file with test results.

> **Note**
> It could take more that an hour to run test for all views in all configurations.
