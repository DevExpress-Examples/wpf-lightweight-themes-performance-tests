<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/641886343/2023.1)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1166652)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WPF Lightweight Themes - Performance Tests

In our v23.1 release cycle, we optimized existing WPF themes and introduced new ["lightweight" versions](https://docs.devexpress.com/WPF/404442/common-concepts/themes/lightweight-themes) for the following themes: Windows 10, Office, and Visual Studio styles.

These "lightweight" themes consume less memory and improve application startup speed. To test/review these performance enhancements on your machine, simply run the application included in this repository.

## Solution Structure

The solution contains 5 projects:

* PerfApp_Net7_v22_2
* PerfApp_Net7_v23_1
* PerfApp_NETFramework_v22_2
* PerfApp_NETFramework_v23_1
* TestRunner

The first 4 projects implement the same UI but use different versions of DevExpress WPF controls (v23.1 and v22.2) and different frameworks (.NET Framework v4.7.2 and .NET 7). You can run each project separately and use settings defined in `App.xaml.cs` to change test configurations:

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

Once you run an application, the main window will display startup time (in milliseconds) within its title bar.

The **TestRunner** project contains an NUnit test that runs **PerfApp** applications (one by one - based on settings specified in `Tests.cs`:)

```cs
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
```

## Run Tests

To run tests:

1. Open the `ComponentStartupTests.sln` solution.
2. Build the solution using **Release** configuration.
3. (Recommended) Close all open applications except for Visual Studio.
4. Run tests. We recommend that you use [CodeRush for Visual Studio](https://www.devexpress.com/products/coderush/): our FREE developer productivity IDE extension. If you do use CodeRush, simply right-click the **TestRunner** project in the Solution Explorer and select **Run Tests**.

After all tests pass, the application creates a `Results.md` file with test results.

> **Important Note:** It may take over an hour to run tests for all views/across all configurations.

## Test Results

Here are our test results for comparison purposes ([Results.2023-07-04.md](./CS/Results.2023-07-04.md)):

**Main Test: Ribbon, Docking, Grid, PropertyGrid, Accordion, Editors, LayoutControl, DXTabControl**

### ColdStart, .NET Framework 4.7.2

**Perfomance**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 7530 ms | 6882 ms, 8.61% | 5997 ms, 20.36% |
|  Bars | 2706 ms | 2159 ms, 20.21% | 1804 ms, 33.33% |
|  Charts | 2239 ms | 2019 ms, 9.83% | 1813 ms, 19.03% |
|  Editors | 2355 ms | 2070 ms, 12.10% | 1882 ms, 20.08% |
|  Grid | 3092 ms | 2847 ms, 7.92% | 2504 ms, 19.02% |
|  Ribbon | 3737 ms | 3098 ms, 17.10% | 2595 ms, 30.56% |
|  RichEdit | 6510 ms | 6466 ms, 0.68% | 5835 ms, 10.37% |
|  Scheduler | 4406 ms | 4277 ms, 2.93% | 3643 ms, 17.32% |

**Memory**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 56489 KB | 42872 KB, 24.11% | 35658 KB, 36.88% |
|  Bars | 23569 KB | 16053 KB, 31.89% | 11062 KB, 53.07% |
|  Charts | 18589 KB | 13296 KB, 28.47% | 9020 KB, 51.48% |
|  Editors | 22092 KB | 14890 KB, 32.60% | 11431 KB, 48.26% |
|  Grid | 24903 KB | 17566 KB, 29.46% | 13343 KB, 46.42% |
|  Ribbon | 33272 KB | 22917 KB, 31.12% | 16622 KB, 50.04% |
|  RichEdit | 38049 KB | 34041 KB, 10.53% | 22232 KB, 41.57% |
|  Scheduler | 35892 KB | 31713 KB, 11.64% | 20923 KB, 41.71% |


### ColdStart, .NET 7

**Perfomance**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 6987 ms | 5729 ms, 18.00% | 4925 ms, 29.51% |
|  Bars | 2550 ms | 1792 ms, 29.73% | 1528 ms, 40.08% |
|  Charts | 1839 ms | 1680 ms, 8.65% | 1472 ms, 19.96% |
|  Editors | 2215 ms | 1795 ms, 18.96% | 1569 ms, 29.16% |
|  Grid | 2344 ms | 2146 ms, 8.45% | 1896 ms, 19.11% |
|  Ribbon | 3402 ms | 2785 ms, 18.14% | 2312 ms, 32.04% |
|  RichEdit | 5034 ms | 4927 ms, 2.13% | 3832 ms, 23.88% |
|  Scheduler | 3936 ms | 3468 ms, 11.89% | 2961 ms, 24.77% |

**Memory**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 88975 KB | 70583 KB, 20.67% | 60387 KB, 32.13% |
|  Bars | 35543 KB | 25433 KB, 28.44% | 18182 KB, 48.85% |
|  Charts | 27889 KB | 20478 KB, 26.57% | 14785 KB, 46.99% |
|  Editors | 33224 KB | 23445 KB, 29.43% | 18921 KB, 43.05% |
|  Grid | 37670 KB | 27409 KB, 27.24% | 22057 KB, 41.45% |
|  Ribbon | 50824 KB | 36801 KB, 27.59% | 27837 KB, 45.23% |
|  RichEdit | 56204 KB | 50420 KB, 10.29% | 34365 KB, 38.86% |
|  Scheduler | 55728 KB | 49690 KB, 10.83% | 34823 KB, 37.51% |


### ColdStart, .NET Framework 4.7.2, Ngen

**Perfomance**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 4211 ms | 2885 ms, 31.49% | 2476 ms, 41.20% |
|  Bars | 1533 ms | 997 ms, 34.96% | 813 ms, 46.97% |
|  Charts | 867 ms | 714 ms, 17.65% | 508 ms, 41.41% |
|  Editors | 1003 ms | 858 ms, 14.46% | 685 ms, 31.70% |
|  Grid | 1035 ms | 882 ms, 14.78% | 674 ms, 34.88% |
|  Ribbon | 2141 ms | 1425 ms, 33.44% | 1103 ms, 48.48% |
|  RichEdit | 2034 ms | 2231 ms, -9.69% | 1696 ms, 16.62% |
|  Scheduler | 1880 ms | 1869 ms, 0.59% | 1260 ms, 32.98% |

**Memory**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 56831 KB | 43474 KB, 23.50% | 36307 KB, 36.11% |
|  Bars | 23490 KB | 16118 KB, 31.38% | 11063 KB, 52.90% |
|  Charts | 18537 KB | 13278 KB, 28.37% | 9008 KB, 51.41% |
|  Editors | 22073 KB | 14897 KB, 32.51% | 11476 KB, 48.01% |
|  Grid | 24904 KB | 17557 KB, 29.50% | 13341 KB, 46.43% |
|  Ribbon | 33225 KB | 23227 KB, 30.09% | 17142 KB, 48.41% |
|  RichEdit | 38021 KB | 34038 KB, 10.48% | 22228 KB, 41.54% |
|  Scheduler | 35914 KB | 31760 KB, 11.57% | 20906 KB, 41.79% |


### ColdStart, .NET 7, ReadyToRun

**Perfomance**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 5128 ms | 4451 ms, 13.20% | 3585 ms, 30.09% |
|  Bars | 1936 ms | 1452 ms, 25.00% | 1225 ms, 36.73% |
|  Charts | 1519 ms | 1335 ms, 12.11% | 1137 ms, 25.15% |
|  Editors | 1642 ms | 1466 ms, 10.72% | 1276 ms, 22.29% |
|  Grid | 1839 ms | 1593 ms, 13.38% | 1318 ms, 28.33% |
|  Ribbon | 2838 ms | 2260 ms, 20.37% | 1813 ms, 36.12% |
|  RichEdit | 3613 ms | 3440 ms, 4.79% | 3126 ms, 13.48% |
|  Scheduler | 2928 ms | 2783 ms, 4.95% | 2286 ms, 21.93% |

**Memory**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 61115 KB | 46329 KB, 24.19% | 38319 KB, 37.30% |
|  Bars | 26619 KB | 20831 KB, 21.74% | 16311 KB, 38.72% |
|  Charts | 22829 KB | 18252 KB, 20.05% | 10265 KB, 55.04% |
|  Editors | 28350 KB | 17472 KB, 38.37% | 13649 KB, 51.86% |
|  Grid | 27174 KB | 22896 KB, 15.74% | 16742 KB, 38.39% |
|  Ribbon | 35141 KB | 27352 KB, 22.16% | 21494 KB, 38.83% |
|  RichEdit | 42480 KB | 38852 KB, 8.54% | 26956 KB, 36.54% |
|  Scheduler | 39533 KB | 35288 KB, 10.74% | 24607 KB, 37.76% |


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


### HotStart, .NET 7

**Perfomance**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 1093 ms | 1078 ms, 1.37% | 951 ms, 12.99% |
|  Bars | 261 ms | 256 ms, 1.92% | 195 ms, 25.29% |
|  Charts | 246 ms | 243 ms, 1.22% | 243 ms, 1.22% |
|  Editors | 257 ms | 232 ms, 9.73% | 227 ms, 11.67% |
|  Grid | 257 ms | 230 ms, 10.51% | 228 ms, 11.28% |
|  Ribbon | 557 ms | 526 ms, 5.57% | 453 ms, 18.67% |
|  RichEdit | 743 ms | 712 ms, 4.17% | 662 ms, 10.90% |
|  Scheduler | 555 ms | 528 ms, 4.86% | 482 ms, 13.15% |



### HotStart, .NET Framework 4.7.2, Ngen

**Perfomance**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 1101 ms | 1109 ms, -0.73% | 954 ms, 13.35% |
|  Bars | 221 ms | 216 ms, 2.26% | 173 ms, 21.72% |
|  Charts | 220 ms | 215 ms, 2.27% | 219 ms, 0.45% |
|  Editors | 197 ms | 197 ms, 0.00% | 193 ms, 2.03% |
|  Grid | 203 ms | 248 ms, -22.17% | 183 ms, 9.85% |
|  Ribbon | 505 ms | 507 ms, -0.40% | 402 ms, 20.40% |
|  RichEdit | 812 ms | 757 ms, 6.77% | 688 ms, 15.27% |
|  Scheduler | 592 ms | 506 ms, 14.53% | 486 ms, 17.91% |


### HotStart, .NET 7, ReadyToRun

**Perfomance**

|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 1059 ms | 1046 ms, 1.23% | 997 ms, 5.85% |
|  Bars | 252 ms | 256 ms, -1.59% | 204 ms, 19.05% |
|  Charts | 242 ms | 241 ms, 0.41% | 254 ms, -4.96% |
|  Editors | 237 ms | 239 ms, -0.84% | 231 ms, 2.53% |
|  Grid | 237 ms | 248 ms, -4.64% | 224 ms, 5.49% |
|  Ribbon | 560 ms | 529 ms, 5.54% | 447 ms, 20.18% |
|  RichEdit | 739 ms | 750 ms, -1.49% | 705 ms, 4.60% |
|  Scheduler | 518 ms | 512 ms, 1.16% | 484 ms, 6.56% |
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lightweight-themes-performance-tests&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lightweight-themes-performance-tests&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
