<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1166652)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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

## Test Results

Below are test results measured by our team ([Results.2023-05-17.md](./CS/Results.2023-05-17.md)):

**Main Test: Ribbon, Docking, Grid, PropertyGrid, Accordion, Editors, LayoutControl, DXTabControl**

### ColdStart, .NET Framework 4.7.2

**Perfomance**

|  Test | v22.2 (baseline) | v23.1 | LWThemes v23.1 |
|  ---- | ---------------- | ----- | -------------- |
|  Main | 7623 ms | 6916 ms, 9.27% | 6127 ms, 19.62% |
|  Bars | 2780 ms | 2148 ms, 22.73% | 1833 ms, 34.06% |
|  Charts | 2321 ms | 2068 ms, 10.90% | 1804 ms, 22.27% |
|  Editors | 2411 ms | 2093 ms, 13.19% | 1870 ms, 22.44% |
|  Grid | 3026 ms | 2830 ms, 6.48% | 2485 ms, 17.88% |
|  Ribbon | 3785 ms | 3151 ms, 16.75% | 2612 ms, 30.99% |
|  RichEdit | 7121 ms | 6631 ms, 6.88% | 6160 ms, 13.50% |
|  Scheduler | 4589 ms | 4494 ms, 2.07% | 3696 ms, 19.46% |

**Memory**

|  Test | v22.2 (baseline) | v23.1 | LWThemes v23.1 |
|  ---- | ---------------- | ----- | -------------- |
|  Main | 56542 KB | 42933 KB, 24.07% | 34564 KB, 38.87% |
|  Bars | 23539 KB | 16051 KB, 31.81% | 10982 KB, 53.35% |
|  Charts | 18589 KB | 13296 KB, 28.47% | 8768 KB, 52.83% |
|  Editors | 22106 KB | 14883 KB, 32.67% | 11331 KB, 48.74% |
|  Grid | 24904 KB | 17577 KB, 29.42% | 12839 KB, 48.45% |
|  Ribbon | 33268 KB | 22918 KB, 31.11% | 16355 KB, 50.84% |
|  RichEdit | 38015 KB | 34042 KB, 10.45% | 21626 KB, 43.11% |
|  Scheduler | 35884 KB | 31704 KB, 11.65% | 20663 KB, 42.42% |


### ColdStart, NET 7

**Perfomance**

|  Test | v22.2 (baseline) | v23.1 | LWThemes v23.1 |
|  ---- | ---------------- | ----- | -------------- |
|  Main | 6562 ms | 5925 ms, 9.71% | 4984 ms, 24.05% |
|  Bars | 2571 ms | 1847 ms, 28.16% | 1536 ms, 40.26% |
|  Charts | 1924 ms | 1747 ms, 9.20% | 1456 ms, 24.32% |
|  Editors | 2268 ms | 1793 ms, 20.94% | 1616 ms, 28.75% |
|  Grid | 2405 ms | 2151 ms, 10.56% | 1848 ms, 23.16% |
|  Ribbon | 3630 ms | 2815 ms, 22.45% | 2360 ms, 34.99% |
|  RichEdit | 5336 ms | 5130 ms, 3.86% | 4228 ms, 20.76% |
|  Scheduler | 3960 ms | 3630 ms, 8.33% | 2994 ms, 24.39% |

**Memory**

|  Test | v22.2 (baseline) | v23.1 | LWThemes v23.1 |
|  ---- | ---------------- | ----- | -------------- |
|  Main | 89068 KB | 70498 KB, 20.85% | 58513 KB, 34.31% |
|  Bars | 35565 KB | 25434 KB, 28.49% | 18050 KB, 49.25% |
|  Charts | 27896 KB | 20478 KB, 26.59% | 14402 KB, 48.37% |
|  Editors | 33232 KB | 23446 KB, 29.45% | 18709 KB, 43.70% |
|  Grid | 37716 KB | 27449 KB, 27.22% | 21297 KB, 43.53% |
|  Ribbon | 50819 KB | 36794 KB, 27.60% | 27345 KB, 46.19% |
|  RichEdit | 56175 KB | 50450 KB, 10.19% | 33417 KB, 40.51% |
|  Scheduler | 55735 KB | 49666 KB, 10.89% | 34405 KB, 38.27% |


### ColdStart, .NET Framework 4.7.2, Ngen

**Perfomance**

|  Test | v22.2 (baseline) | v23.1 | LWThemes v23.1 |
|  ---- | ---------------- | ----- | -------------- |
|  Main | 3406 ms | 2816 ms, 17.32% | 2215 ms, 34.97% |
|  Bars | 1243 ms | 975 ms, 21.56% | 821 ms, 33.95% |
|  Charts | 784 ms | 655 ms, 16.45% | 496 ms, 36.73% |
|  Editors | 918 ms | 831 ms, 9.48% | 659 ms, 28.21% |
|  Grid | 995 ms | 865 ms, 13.07% | 646 ms, 35.08% |
|  Ribbon | 1877 ms | 1377 ms, 26.64% | 1128 ms, 39.90% |
|  RichEdit | 1808 ms | 2456 ms, -35.84% | 1455 ms, 19.52% |
|  Scheduler | 1807 ms | 1700 ms, 5.92% | 1257 ms, 30.44% |

**Memory**

|  Test | v22.2 (baseline) | v23.1 | LWThemes v23.1 |
|  ---- | ---------------- | ----- | -------------- |
|  Main | 56962 KB | 43259 KB, 24.06% | 34728 KB, 39.03% |
|  Bars | 23514 KB | 16043 KB, 31.77% | 10974 KB, 53.33% |
|  Charts | 18536 KB | 13276 KB, 28.38% | 8751 KB, 52.79% |
|  Editors | 22100 KB | 14920 KB, 32.49% | 11321 KB, 48.77% |
|  Grid | 24904 KB | 17563 KB, 29.48% | 12834 KB, 48.47% |
|  Ribbon | 33208 KB | 23208 KB, 30.11% | 16810 KB, 49.38% |
|  RichEdit | 37988 KB | 34039 KB, 10.40% | 21633 KB, 43.05% |
|  Scheduler | 35895 KB | 31751 KB, 11.54% | 20648 KB, 42.48% |


### ColdStart, NET 7, ReadyToRun

**Perfomance**

|  Test | v22.2 (baseline) | v23.1 | LWThemes v23.1 |
|  ---- | ---------------- | ----- | -------------- |
|  Main | 5125 ms | 4554 ms, 11.14% | 3578 ms, 30.19% |
|  Bars | 1984 ms | 1485 ms, 25.15% | 1244 ms, 37.30% |
|  Charts | 1507 ms | 1392 ms, 7.63% | 1126 ms, 25.28% |
|  Editors | 1638 ms | 1468 ms, 10.38% | 1265 ms, 22.77% |
|  Grid | 1854 ms | 1662 ms, 10.36% | 1322 ms, 28.69% |
|  Ribbon | 2789 ms | 2275 ms, 18.43% | 1923 ms, 31.05% |
|  RichEdit | 3845 ms | 4081 ms, -6.14% | 2578 ms, 32.95% |
|  Scheduler | 2949 ms | 2871 ms, 2.64% | 2353 ms, 20.21% |

**Memory**

|  Test | v22.2 (baseline) | v23.1 | LWThemes v23.1 |
|  ---- | ---------------- | ----- | -------------- |
|  Main | 58556 KB | 45741 KB, 21.89% | 39884 KB, 31.89% |
|  Bars | 25537 KB | 19718 KB, 22.79% | 16618 KB, 34.93% |
|  Charts | 24691 KB | 17333 KB, 29.80% | 10026 KB, 59.39% |
|  Editors | 28278 KB | 16445 KB, 41.85% | 16193 KB, 42.74% |
|  Grid | 27116 KB | 22595 KB, 16.67% | 15835 KB, 41.60% |
|  Ribbon | 35791 KB | 26669 KB, 25.49% | 20244 KB, 43.44% |
|  RichEdit | 41901 KB | 39855 KB, 4.88% | 28556 KB, 31.85% |
|  Scheduler | 39037 KB | 35128 KB, 10.01% | 23892 KB, 38.80% |


### HotStart, .NET Framework 4.7.2

**Perfomance**

|  Test | v22.2 (baseline) | LWThemes v23.1 |
|  ---- | ---------------- | -------------- |
|  Main | 1059 ms | 878 ms, 17.09% |
|  Bars | 211 ms | 166 ms, 21.33% |
|  Charts | 222 ms | 199 ms, 10.36% |
|  Editors | 203 ms | 184 ms, 9.36% |
|  Grid | 198 ms | 170 ms, 14.14% |
|  Ribbon | 512 ms | 397 ms, 22.46% |
|  RichEdit | 833 ms | 592 ms, 28.93% |
|  Scheduler | 596 ms | 713 ms, -19.63% |


### HotStart, NET 7

**Perfomance**

|  Test | v22.2 (baseline) | LWThemes v23.1 |
|  ---- | ---------------- | -------------- |
|  Main | 1214 ms | 980 ms, 19.28% |
|  Bars | 282 ms | 215 ms, 23.76% |
|  Charts | 270 ms | 249 ms, 7.78% |
|  Editors | 273 ms | 235 ms, 13.92% |
|  Grid | 261 ms | 228 ms, 12.64% |
|  Ribbon | 608 ms | 489 ms, 19.57% |
|  RichEdit | 869 ms | 729 ms, 16.11% |
|  Scheduler | 642 ms | 556 ms, 13.40% |


### HotStart, .NET Framework 4.7.2, Ngen

**Perfomance**

|  Test | v22.2 (baseline) | LWThemes v23.1 |
|  ---- | ---------------- | -------------- |
|  Main | 1080 ms | 894 ms, 17.22% |
|  Bars | 215 ms | 163 ms, 24.19% |
|  Charts | 224 ms | 212 ms, 5.36% |
|  Editors | 207 ms | 187 ms, 9.66% |
|  Grid | 198 ms | 170 ms, 14.14% |
|  Ribbon | 514 ms | 384 ms, 25.29% |
|  RichEdit | 724 ms | 799 ms, -10.36% |
|  Scheduler | 577 ms | 476 ms, 17.50% |


### HotStart, NET 7, ReadyToRun

**Perfomance**

|  Test | v22.2 (baseline) | LWThemes v23.1 |
|  ---- | ---------------- | -------------- |
|  Main | 1103 ms | 1010 ms, 8.43% |
|  Bars | 272 ms | 207 ms, 23.90% |
|  Charts | 246 ms | 248 ms, -0.81% |
|  Editors | 251 ms | 227 ms, 9.56% |
|  Grid | 316 ms | 227 ms, 28.16% |
|  Ribbon | 621 ms | 477 ms, 23.19% |
|  RichEdit | 732 ms | 678 ms, 7.38% |
|  Scheduler | 666 ms | 545 ms, 18.17% |
