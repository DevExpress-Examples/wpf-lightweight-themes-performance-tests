**Main Test: Ribbon, Docking, Grid, PropertyGrid, Accordion, Editors, LayoutControl, DXTabControl**

# ColdStart, .NET Framework 4.7.2

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


**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2, #1:** Time: 7627 ms, TotalMemory: 56537 KB
* **v22.2, #2:** Time: 7611 ms, TotalMemory: 56468 KB
* **v22.2, #3:** Time: 7632 ms, TotalMemory: 56621 KB
* **v23.1, #1:** Time: 6948 ms, TotalMemory: 42832 KB
* **v23.1, #2:** Time: 6843 ms, TotalMemory: 42882 KB
* **v23.1, #3:** Time: 6957 ms, TotalMemory: 43085 KB
* **LWThemes v23.1, #1:** Time: 6117 ms, TotalMemory: 34579 KB
* **LWThemes v23.1, #2:** Time: 6213 ms, TotalMemory: 34617 KB
* **LWThemes v23.1, #3:** Time: 6052 ms, TotalMemory: 34496 KB

**Bars**
* **v22.2, #1:** Time: 2780 ms, TotalMemory: 23539 KB
* **v22.2, #2:** Time: 2773 ms, TotalMemory: 23539 KB
* **v22.2, #3:** Time: 2787 ms, TotalMemory: 23539 KB
* **v23.1, #1:** Time: 2149 ms, TotalMemory: 16052 KB
* **v23.1, #2:** Time: 2161 ms, TotalMemory: 16052 KB
* **v23.1, #3:** Time: 2135 ms, TotalMemory: 16051 KB
* **LWThemes v23.1, #1:** Time: 1863 ms, TotalMemory: 10986 KB
* **LWThemes v23.1, #2:** Time: 1827 ms, TotalMemory: 10986 KB
* **LWThemes v23.1, #3:** Time: 1811 ms, TotalMemory: 10975 KB

**Charts**
* **v22.2, #1:** Time: 2382 ms, TotalMemory: 18589 KB
* **v22.2, #2:** Time: 2297 ms, TotalMemory: 18589 KB
* **v22.2, #3:** Time: 2286 ms, TotalMemory: 18589 KB
* **v23.1, #1:** Time: 2130 ms, TotalMemory: 13296 KB
* **v23.1, #2:** Time: 2053 ms, TotalMemory: 13296 KB
* **v23.1, #3:** Time: 2023 ms, TotalMemory: 13296 KB
* **LWThemes v23.1, #1:** Time: 1809 ms, TotalMemory: 8767 KB
* **LWThemes v23.1, #2:** Time: 1797 ms, TotalMemory: 8768 KB
* **LWThemes v23.1, #3:** Time: 1808 ms, TotalMemory: 8769 KB

**Editors**
* **v22.2, #1:** Time: 2395 ms, TotalMemory: 22093 KB
* **v22.2, #2:** Time: 2367 ms, TotalMemory: 22092 KB
* **v22.2, #3:** Time: 2473 ms, TotalMemory: 22134 KB
* **v23.1, #1:** Time: 2127 ms, TotalMemory: 14870 KB
* **v23.1, #2:** Time: 2069 ms, TotalMemory: 14870 KB
* **v23.1, #3:** Time: 2083 ms, TotalMemory: 14910 KB
* **LWThemes v23.1, #1:** Time: 1872 ms, TotalMemory: 11346 KB
* **LWThemes v23.1, #2:** Time: 1881 ms, TotalMemory: 11303 KB
* **LWThemes v23.1, #3:** Time: 1859 ms, TotalMemory: 11345 KB

**Grid**
* **v22.2, #1:** Time: 3037 ms, TotalMemory: 24904 KB
* **v22.2, #2:** Time: 3016 ms, TotalMemory: 24905 KB
* **v22.2, #3:** Time: 3027 ms, TotalMemory: 24904 KB
* **v23.1, #1:** Time: 2814 ms, TotalMemory: 17577 KB
* **v23.1, #2:** Time: 2855 ms, TotalMemory: 17577 KB
* **v23.1, #3:** Time: 2822 ms, TotalMemory: 17578 KB
* **LWThemes v23.1, #1:** Time: 2504 ms, TotalMemory: 12839 KB
* **LWThemes v23.1, #2:** Time: 2471 ms, TotalMemory: 12839 KB
* **LWThemes v23.1, #3:** Time: 2482 ms, TotalMemory: 12840 KB

**Ribbon**
* **v22.2, #1:** Time: 3797 ms, TotalMemory: 33269 KB
* **v22.2, #2:** Time: 3763 ms, TotalMemory: 33268 KB
* **v22.2, #3:** Time: 3796 ms, TotalMemory: 33268 KB
* **v23.1, #1:** Time: 3104 ms, TotalMemory: 22919 KB
* **v23.1, #2:** Time: 3130 ms, TotalMemory: 22918 KB
* **v23.1, #3:** Time: 3220 ms, TotalMemory: 22918 KB
* **LWThemes v23.1, #1:** Time: 2592 ms, TotalMemory: 16351 KB
* **LWThemes v23.1, #2:** Time: 2648 ms, TotalMemory: 16351 KB
* **LWThemes v23.1, #3:** Time: 2596 ms, TotalMemory: 16363 KB

**RichEdit**
* **v22.2, #1:** Time: 7364 ms, TotalMemory: 38015 KB
* **v22.2, #2:** Time: 7574 ms, TotalMemory: 38015 KB
* **v22.2, #3:** Time: 6425 ms, TotalMemory: 38015 KB
* **v23.1, #1:** Time: 7034 ms, TotalMemory: 34038 KB
* **v23.1, #2:** Time: 6818 ms, TotalMemory: 34039 KB
* **v23.1, #3:** Time: 6043 ms, TotalMemory: 34049 KB
* **LWThemes v23.1, #1:** Time: 5887 ms, TotalMemory: 21626 KB
* **LWThemes v23.1, #2:** Time: 5938 ms, TotalMemory: 21626 KB
* **LWThemes v23.1, #3:** Time: 6655 ms, TotalMemory: 21626 KB

**Scheduler**
* **v22.2, #1:** Time: 4601 ms, TotalMemory: 35873 KB
* **v22.2, #2:** Time: 4456 ms, TotalMemory: 35907 KB
* **v22.2, #3:** Time: 4711 ms, TotalMemory: 35874 KB
* **v23.1, #1:** Time: 4989 ms, TotalMemory: 31705 KB
* **v23.1, #2:** Time: 4286 ms, TotalMemory: 31705 KB
* **v23.1, #3:** Time: 4209 ms, TotalMemory: 31702 KB
* **LWThemes v23.1, #1:** Time: 3763 ms, TotalMemory: 20664 KB
* **LWThemes v23.1, #2:** Time: 3673 ms, TotalMemory: 20663 KB
* **LWThemes v23.1, #3:** Time: 3654 ms, TotalMemory: 20663 KB

</details>



# ColdStart, NET 7

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


**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2, #1:** Time: 6602 ms, TotalMemory: 89027 KB
* **v22.2, #2:** Time: 6534 ms, TotalMemory: 89209 KB
* **v22.2, #3:** Time: 6551 ms, TotalMemory: 88969 KB
* **v23.1, #1:** Time: 6054 ms, TotalMemory: 70455 KB
* **v23.1, #2:** Time: 5852 ms, TotalMemory: 70416 KB
* **v23.1, #3:** Time: 5870 ms, TotalMemory: 70624 KB
* **LWThemes v23.1, #1:** Time: 4979 ms, TotalMemory: 58590 KB
* **LWThemes v23.1, #2:** Time: 4935 ms, TotalMemory: 58530 KB
* **LWThemes v23.1, #3:** Time: 5040 ms, TotalMemory: 58420 KB

**Bars**
* **v22.2, #1:** Time: 2576 ms, TotalMemory: 35586 KB
* **v22.2, #2:** Time: 2553 ms, TotalMemory: 35587 KB
* **v22.2, #3:** Time: 2585 ms, TotalMemory: 35522 KB
* **v23.1, #1:** Time: 1845 ms, TotalMemory: 25430 KB
* **v23.1, #2:** Time: 1855 ms, TotalMemory: 25431 KB
* **v23.1, #3:** Time: 1843 ms, TotalMemory: 25442 KB
* **LWThemes v23.1, #1:** Time: 1547 ms, TotalMemory: 18050 KB
* **LWThemes v23.1, #2:** Time: 1532 ms, TotalMemory: 18052 KB
* **LWThemes v23.1, #3:** Time: 1531 ms, TotalMemory: 18048 KB

**Charts**
* **v22.2, #1:** Time: 2049 ms, TotalMemory: 27927 KB
* **v22.2, #2:** Time: 1834 ms, TotalMemory: 27901 KB
* **v22.2, #3:** Time: 1891 ms, TotalMemory: 27860 KB
* **v23.1, #1:** Time: 1953 ms, TotalMemory: 20476 KB
* **v23.1, #2:** Time: 1648 ms, TotalMemory: 20480 KB
* **v23.1, #3:** Time: 1641 ms, TotalMemory: 20480 KB
* **LWThemes v23.1, #1:** Time: 1451 ms, TotalMemory: 14410 KB
* **LWThemes v23.1, #2:** Time: 1475 ms, TotalMemory: 14399 KB
* **LWThemes v23.1, #3:** Time: 1443 ms, TotalMemory: 14397 KB

**Editors**
* **v22.2, #1:** Time: 2297 ms, TotalMemory: 33278 KB
* **v22.2, #2:** Time: 2261 ms, TotalMemory: 33236 KB
* **v22.2, #3:** Time: 2247 ms, TotalMemory: 33183 KB
* **v23.1, #1:** Time: 1785 ms, TotalMemory: 23529 KB
* **v23.1, #2:** Time: 1795 ms, TotalMemory: 23414 KB
* **v23.1, #3:** Time: 1800 ms, TotalMemory: 23395 KB
* **LWThemes v23.1, #1:** Time: 1603 ms, TotalMemory: 18723 KB
* **LWThemes v23.1, #2:** Time: 1630 ms, TotalMemory: 18678 KB
* **LWThemes v23.1, #3:** Time: 1615 ms, TotalMemory: 18726 KB

**Grid**
* **v22.2, #1:** Time: 2447 ms, TotalMemory: 37699 KB
* **v22.2, #2:** Time: 2367 ms, TotalMemory: 37727 KB
* **v22.2, #3:** Time: 2401 ms, TotalMemory: 37722 KB
* **v23.1, #1:** Time: 2160 ms, TotalMemory: 27444 KB
* **v23.1, #2:** Time: 2172 ms, TotalMemory: 27445 KB
* **v23.1, #3:** Time: 2122 ms, TotalMemory: 27459 KB
* **LWThemes v23.1, #1:** Time: 1850 ms, TotalMemory: 21296 KB
* **LWThemes v23.1, #2:** Time: 1866 ms, TotalMemory: 21294 KB
* **LWThemes v23.1, #3:** Time: 1830 ms, TotalMemory: 21303 KB

**Ribbon**
* **v22.2, #1:** Time: 3489 ms, TotalMemory: 50843 KB
* **v22.2, #2:** Time: 3576 ms, TotalMemory: 50808 KB
* **v22.2, #3:** Time: 3827 ms, TotalMemory: 50808 KB
* **v23.1, #1:** Time: 2842 ms, TotalMemory: 36808 KB
* **v23.1, #2:** Time: 2834 ms, TotalMemory: 36781 KB
* **v23.1, #3:** Time: 2771 ms, TotalMemory: 36795 KB
* **LWThemes v23.1, #1:** Time: 2358 ms, TotalMemory: 27354 KB
* **LWThemes v23.1, #2:** Time: 2373 ms, TotalMemory: 27339 KB
* **LWThemes v23.1, #3:** Time: 2350 ms, TotalMemory: 27344 KB

**RichEdit**
* **v22.2, #1:** Time: 5902 ms, TotalMemory: 56194 KB
* **v22.2, #2:** Time: 4537 ms, TotalMemory: 56200 KB
* **v22.2, #3:** Time: 5570 ms, TotalMemory: 56133 KB
* **v23.1, #1:** Time: 5484 ms, TotalMemory: 50451 KB
* **v23.1, #2:** Time: 5056 ms, TotalMemory: 50414 KB
* **v23.1, #3:** Time: 4852 ms, TotalMemory: 50485 KB
* **LWThemes v23.1, #1:** Time: 4169 ms, TotalMemory: 33386 KB
* **LWThemes v23.1, #2:** Time: 4633 ms, TotalMemory: 33447 KB
* **LWThemes v23.1, #3:** Time: 3883 ms, TotalMemory: 33419 KB

**Scheduler**
* **v22.2, #1:** Time: 4311 ms, TotalMemory: 55747 KB
* **v22.2, #2:** Time: 3796 ms, TotalMemory: 55728 KB
* **v22.2, #3:** Time: 3774 ms, TotalMemory: 55731 KB
* **v23.1, #1:** Time: 3816 ms, TotalMemory: 49669 KB
* **v23.1, #2:** Time: 3537 ms, TotalMemory: 49667 KB
* **v23.1, #3:** Time: 3539 ms, TotalMemory: 49663 KB
* **LWThemes v23.1, #1:** Time: 3015 ms, TotalMemory: 34408 KB
* **LWThemes v23.1, #2:** Time: 2977 ms, TotalMemory: 34396 KB
* **LWThemes v23.1, #3:** Time: 2991 ms, TotalMemory: 34413 KB

</details>



# ColdStart, .NET Framework 4.7.2, Ngen

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


**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2, #1:** Time: 3388 ms, TotalMemory: 57004 KB
* **v22.2, #2:** Time: 3447 ms, TotalMemory: 56921 KB
* **v22.2, #3:** Time: 3384 ms, TotalMemory: 56963 KB
* **v23.1, #1:** Time: 2834 ms, TotalMemory: 43255 KB
* **v23.1, #2:** Time: 2838 ms, TotalMemory: 43286 KB
* **v23.1, #3:** Time: 2776 ms, TotalMemory: 43238 KB
* **LWThemes v23.1, #1:** Time: 2209 ms, TotalMemory: 34729 KB
* **LWThemes v23.1, #2:** Time: 2228 ms, TotalMemory: 34686 KB
* **LWThemes v23.1, #3:** Time: 2208 ms, TotalMemory: 34769 KB

**Bars**
* **v22.2, #1:** Time: 1210 ms, TotalMemory: 23514 KB
* **v22.2, #2:** Time: 1252 ms, TotalMemory: 23514 KB
* **v22.2, #3:** Time: 1267 ms, TotalMemory: 23514 KB
* **v23.1, #1:** Time: 996 ms, TotalMemory: 16044 KB
* **v23.1, #2:** Time: 948 ms, TotalMemory: 16043 KB
* **v23.1, #3:** Time: 981 ms, TotalMemory: 16043 KB
* **LWThemes v23.1, #1:** Time: 826 ms, TotalMemory: 10974 KB
* **LWThemes v23.1, #2:** Time: 812 ms, TotalMemory: 10974 KB
* **LWThemes v23.1, #3:** Time: 826 ms, TotalMemory: 10975 KB

**Charts**
* **v22.2, #1:** Time: 824 ms, TotalMemory: 18537 KB
* **v22.2, #2:** Time: 751 ms, TotalMemory: 18537 KB
* **v22.2, #3:** Time: 779 ms, TotalMemory: 18536 KB
* **v23.1, #1:** Time: 665 ms, TotalMemory: 13276 KB
* **v23.1, #2:** Time: 650 ms, TotalMemory: 13276 KB
* **v23.1, #3:** Time: 651 ms, TotalMemory: 13276 KB
* **LWThemes v23.1, #1:** Time: 482 ms, TotalMemory: 8752 KB
* **LWThemes v23.1, #2:** Time: 511 ms, TotalMemory: 8751 KB
* **LWThemes v23.1, #3:** Time: 495 ms, TotalMemory: 8751 KB

**Editors**
* **v22.2, #1:** Time: 925 ms, TotalMemory: 22099 KB
* **v22.2, #2:** Time: 891 ms, TotalMemory: 22100 KB
* **v22.2, #3:** Time: 938 ms, TotalMemory: 22101 KB
* **v23.1, #1:** Time: 796 ms, TotalMemory: 14866 KB
* **v23.1, #2:** Time: 866 ms, TotalMemory: 14948 KB
* **v23.1, #3:** Time: 832 ms, TotalMemory: 14948 KB
* **LWThemes v23.1, #1:** Time: 638 ms, TotalMemory: 11335 KB
* **LWThemes v23.1, #2:** Time: 655 ms, TotalMemory: 11335 KB
* **LWThemes v23.1, #3:** Time: 685 ms, TotalMemory: 11293 KB

**Grid**
* **v22.2, #1:** Time: 1000 ms, TotalMemory: 24904 KB
* **v22.2, #2:** Time: 982 ms, TotalMemory: 24904 KB
* **v22.2, #3:** Time: 1005 ms, TotalMemory: 24904 KB
* **v23.1, #1:** Time: 880 ms, TotalMemory: 17564 KB
* **v23.1, #2:** Time: 854 ms, TotalMemory: 17564 KB
* **v23.1, #3:** Time: 861 ms, TotalMemory: 17563 KB
* **LWThemes v23.1, #1:** Time: 633 ms, TotalMemory: 12834 KB
* **LWThemes v23.1, #2:** Time: 686 ms, TotalMemory: 12834 KB
* **LWThemes v23.1, #3:** Time: 620 ms, TotalMemory: 12834 KB

**Ribbon**
* **v22.2, #1:** Time: 1883 ms, TotalMemory: 33222 KB
* **v22.2, #2:** Time: 1879 ms, TotalMemory: 33222 KB
* **v22.2, #3:** Time: 1870 ms, TotalMemory: 33182 KB
* **v23.1, #1:** Time: 1384 ms, TotalMemory: 23163 KB
* **v23.1, #2:** Time: 1416 ms, TotalMemory: 23229 KB
* **v23.1, #3:** Time: 1333 ms, TotalMemory: 23232 KB
* **LWThemes v23.1, #1:** Time: 1107 ms, TotalMemory: 16826 KB
* **LWThemes v23.1, #2:** Time: 1107 ms, TotalMemory: 16793 KB
* **LWThemes v23.1, #3:** Time: 1172 ms, TotalMemory: 16811 KB

**RichEdit**
* **v22.2, #1:** Time: 2046 ms, TotalMemory: 37988 KB
* **v22.2, #2:** Time: 1687 ms, TotalMemory: 37988 KB
* **v22.2, #3:** Time: 1691 ms, TotalMemory: 37988 KB
* **v23.1, #1:** Time: 2740 ms, TotalMemory: 34040 KB
* **v23.1, #2:** Time: 2681 ms, TotalMemory: 34040 KB
* **v23.1, #3:** Time: 1949 ms, TotalMemory: 34039 KB
* **LWThemes v23.1, #1:** Time: 1475 ms, TotalMemory: 21629 KB
* **LWThemes v23.1, #2:** Time: 1673 ms, TotalMemory: 21629 KB
* **LWThemes v23.1, #3:** Time: 1219 ms, TotalMemory: 21641 KB

**Scheduler**
* **v22.2, #1:** Time: 1860 ms, TotalMemory: 35895 KB
* **v22.2, #2:** Time: 1750 ms, TotalMemory: 35895 KB
* **v22.2, #3:** Time: 1811 ms, TotalMemory: 35895 KB
* **v23.1, #1:** Time: 1726 ms, TotalMemory: 31751 KB
* **v23.1, #2:** Time: 1658 ms, TotalMemory: 31751 KB
* **v23.1, #3:** Time: 1718 ms, TotalMemory: 31751 KB
* **LWThemes v23.1, #1:** Time: 1260 ms, TotalMemory: 20653 KB
* **LWThemes v23.1, #2:** Time: 1253 ms, TotalMemory: 20647 KB
* **LWThemes v23.1, #3:** Time: 1259 ms, TotalMemory: 20646 KB

</details>



# ColdStart, NET 7, ReadyToRun

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


**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2, #1:** Time: 4998 ms, TotalMemory: 58458 KB
* **v22.2, #2:** Time: 5349 ms, TotalMemory: 58526 KB
* **v22.2, #3:** Time: 5029 ms, TotalMemory: 58686 KB
* **v23.1, #1:** Time: 4783 ms, TotalMemory: 46273 KB
* **v23.1, #2:** Time: 4401 ms, TotalMemory: 46236 KB
* **v23.1, #3:** Time: 4478 ms, TotalMemory: 44716 KB
* **LWThemes v23.1, #1:** Time: 3573 ms, TotalMemory: 41637 KB
* **LWThemes v23.1, #2:** Time: 3588 ms, TotalMemory: 41663 KB
* **LWThemes v23.1, #3:** Time: 3575 ms, TotalMemory: 36354 KB

**Bars**
* **v22.2, #1:** Time: 1972 ms, TotalMemory: 24380 KB
* **v22.2, #2:** Time: 2015 ms, TotalMemory: 24434 KB
* **v22.2, #3:** Time: 1965 ms, TotalMemory: 27798 KB
* **v23.1, #1:** Time: 1465 ms, TotalMemory: 19768 KB
* **v23.1, #2:** Time: 1481 ms, TotalMemory: 19671 KB
* **v23.1, #3:** Time: 1511 ms, TotalMemory: 19715 KB
* **LWThemes v23.1, #1:** Time: 1272 ms, TotalMemory: 16250 KB
* **LWThemes v23.1, #2:** Time: 1252 ms, TotalMemory: 17336 KB
* **LWThemes v23.1, #3:** Time: 1210 ms, TotalMemory: 16270 KB

**Charts**
* **v22.2, #1:** Time: 1598 ms, TotalMemory: 24615 KB
* **v22.2, #2:** Time: 1485 ms, TotalMemory: 24853 KB
* **v22.2, #3:** Time: 1438 ms, TotalMemory: 24605 KB
* **v23.1, #1:** Time: 1487 ms, TotalMemory: 15692 KB
* **v23.1, #2:** Time: 1318 ms, TotalMemory: 18154 KB
* **v23.1, #3:** Time: 1371 ms, TotalMemory: 18155 KB
* **LWThemes v23.1, #1:** Time: 1158 ms, TotalMemory: 10039 KB
* **LWThemes v23.1, #2:** Time: 1145 ms, TotalMemory: 10026 KB
* **LWThemes v23.1, #3:** Time: 1077 ms, TotalMemory: 10014 KB

**Editors**
* **v22.2, #1:** Time: 1640 ms, TotalMemory: 28174 KB
* **v22.2, #2:** Time: 1621 ms, TotalMemory: 28468 KB
* **v22.2, #3:** Time: 1654 ms, TotalMemory: 28192 KB
* **v23.1, #1:** Time: 1460 ms, TotalMemory: 16400 KB
* **v23.1, #2:** Time: 1447 ms, TotalMemory: 16451 KB
* **v23.1, #3:** Time: 1499 ms, TotalMemory: 16486 KB
* **LWThemes v23.1, #1:** Time: 1251 ms, TotalMemory: 16492 KB
* **LWThemes v23.1, #2:** Time: 1267 ms, TotalMemory: 15740 KB
* **LWThemes v23.1, #3:** Time: 1277 ms, TotalMemory: 16348 KB

**Grid**
* **v22.2, #1:** Time: 1868 ms, TotalMemory: 27129 KB
* **v22.2, #2:** Time: 1855 ms, TotalMemory: 27112 KB
* **v22.2, #3:** Time: 1841 ms, TotalMemory: 27108 KB
* **v23.1, #1:** Time: 1738 ms, TotalMemory: 20248 KB
* **v23.1, #2:** Time: 1675 ms, TotalMemory: 23746 KB
* **v23.1, #3:** Time: 1573 ms, TotalMemory: 23793 KB
* **LWThemes v23.1, #1:** Time: 1318 ms, TotalMemory: 15838 KB
* **LWThemes v23.1, #2:** Time: 1339 ms, TotalMemory: 15841 KB
* **LWThemes v23.1, #3:** Time: 1311 ms, TotalMemory: 15828 KB

**Ribbon**
* **v22.2, #1:** Time: 2814 ms, TotalMemory: 34602 KB
* **v22.2, #2:** Time: 2779 ms, TotalMemory: 34701 KB
* **v22.2, #3:** Time: 2774 ms, TotalMemory: 38071 KB
* **v23.1, #1:** Time: 2270 ms, TotalMemory: 26551 KB
* **v23.1, #2:** Time: 2268 ms, TotalMemory: 26609 KB
* **v23.1, #3:** Time: 2288 ms, TotalMemory: 26848 KB
* **LWThemes v23.1, #1:** Time: 1854 ms, TotalMemory: 21272 KB
* **LWThemes v23.1, #2:** Time: 1999 ms, TotalMemory: 19767 KB
* **LWThemes v23.1, #3:** Time: 1918 ms, TotalMemory: 19694 KB

**RichEdit**
* **v22.2, #1:** Time: 4456 ms, TotalMemory: 41918 KB
* **v22.2, #2:** Time: 3840 ms, TotalMemory: 41906 KB
* **v22.2, #3:** Time: 3241 ms, TotalMemory: 41879 KB
* **v23.1, #1:** Time: 4207 ms, TotalMemory: 39917 KB
* **v23.1, #2:** Time: 3955 ms, TotalMemory: 39805 KB
* **v23.1, #3:** Time: 4083 ms, TotalMemory: 39843 KB
* **LWThemes v23.1, #1:** Time: 2508 ms, TotalMemory: 28562 KB
* **LWThemes v23.1, #2:** Time: 2384 ms, TotalMemory: 28587 KB
* **LWThemes v23.1, #3:** Time: 2842 ms, TotalMemory: 28521 KB

**Scheduler**
* **v22.2, #1:** Time: 3007 ms, TotalMemory: 38982 KB
* **v22.2, #2:** Time: 2908 ms, TotalMemory: 39081 KB
* **v22.2, #3:** Time: 2934 ms, TotalMemory: 39048 KB
* **v23.1, #1:** Time: 2998 ms, TotalMemory: 35135 KB
* **v23.1, #2:** Time: 2801 ms, TotalMemory: 35113 KB
* **v23.1, #3:** Time: 2815 ms, TotalMemory: 35137 KB
* **LWThemes v23.1, #1:** Time: 2364 ms, TotalMemory: 23928 KB
* **LWThemes v23.1, #2:** Time: 2298 ms, TotalMemory: 23851 KB
* **LWThemes v23.1, #3:** Time: 2397 ms, TotalMemory: 23897 KB

</details>



# HotStart, .NET Framework 4.7.2

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

**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2, #1:** Time: 1070 ms
* **v22.2, #2:** Time: 1048 ms
* **LWThemes v23.1, #1:** Time: 880 ms
* **LWThemes v23.1, #2:** Time: 876 ms

**Bars**
* **v22.2, #1:** Time: 210 ms
* **v22.2, #2:** Time: 212 ms
* **LWThemes v23.1, #1:** Time: 165 ms
* **LWThemes v23.1, #2:** Time: 167 ms

**Charts**
* **v22.2, #1:** Time: 214 ms
* **v22.2, #2:** Time: 230 ms
* **LWThemes v23.1, #1:** Time: 196 ms
* **LWThemes v23.1, #2:** Time: 203 ms

**Editors**
* **v22.2, #1:** Time: 203 ms
* **v22.2, #2:** Time: 203 ms
* **LWThemes v23.1, #1:** Time: 184 ms
* **LWThemes v23.1, #2:** Time: 185 ms

**Grid**
* **v22.2, #1:** Time: 201 ms
* **v22.2, #2:** Time: 196 ms
* **LWThemes v23.1, #1:** Time: 172 ms
* **LWThemes v23.1, #2:** Time: 168 ms

**Ribbon**
* **v22.2, #1:** Time: 513 ms
* **v22.2, #2:** Time: 511 ms
* **LWThemes v23.1, #1:** Time: 381 ms
* **LWThemes v23.1, #2:** Time: 413 ms

**RichEdit**
* **v22.2, #1:** Time: 954 ms
* **v22.2, #2:** Time: 713 ms
* **LWThemes v23.1, #1:** Time: 688 ms
* **LWThemes v23.1, #2:** Time: 496 ms

**Scheduler**
* **v22.2, #1:** Time: 516 ms
* **v22.2, #2:** Time: 676 ms
* **LWThemes v23.1, #1:** Time: 599 ms
* **LWThemes v23.1, #2:** Time: 827 ms

</details>



# HotStart, NET 7

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

**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2, #1:** Time: 1161 ms
* **v22.2, #2:** Time: 1268 ms
* **LWThemes v23.1, #1:** Time: 978 ms
* **LWThemes v23.1, #2:** Time: 982 ms

**Bars**
* **v22.2, #1:** Time: 276 ms
* **v22.2, #2:** Time: 288 ms
* **LWThemes v23.1, #1:** Time: 221 ms
* **LWThemes v23.1, #2:** Time: 209 ms

**Charts**
* **v22.2, #1:** Time: 263 ms
* **v22.2, #2:** Time: 277 ms
* **LWThemes v23.1, #1:** Time: 254 ms
* **LWThemes v23.1, #2:** Time: 245 ms

**Editors**
* **v22.2, #1:** Time: 279 ms
* **v22.2, #2:** Time: 267 ms
* **LWThemes v23.1, #1:** Time: 240 ms
* **LWThemes v23.1, #2:** Time: 231 ms

**Grid**
* **v22.2, #1:** Time: 259 ms
* **v22.2, #2:** Time: 264 ms
* **LWThemes v23.1, #1:** Time: 224 ms
* **LWThemes v23.1, #2:** Time: 233 ms

**Ribbon**
* **v22.2, #1:** Time: 616 ms
* **v22.2, #2:** Time: 600 ms
* **LWThemes v23.1, #1:** Time: 478 ms
* **LWThemes v23.1, #2:** Time: 500 ms

**RichEdit**
* **v22.2, #1:** Time: 855 ms
* **v22.2, #2:** Time: 884 ms
* **LWThemes v23.1, #1:** Time: 807 ms
* **LWThemes v23.1, #2:** Time: 651 ms

**Scheduler**
* **v22.2, #1:** Time: 692 ms
* **v22.2, #2:** Time: 593 ms
* **LWThemes v23.1, #1:** Time: 563 ms
* **LWThemes v23.1, #2:** Time: 549 ms

</details>



# HotStart, .NET Framework 4.7.2, Ngen

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

**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2, #1:** Time: 1082 ms
* **v22.2, #2:** Time: 1078 ms
* **LWThemes v23.1, #1:** Time: 896 ms
* **LWThemes v23.1, #2:** Time: 893 ms

**Bars**
* **v22.2, #1:** Time: 220 ms
* **v22.2, #2:** Time: 211 ms
* **LWThemes v23.1, #1:** Time: 162 ms
* **LWThemes v23.1, #2:** Time: 165 ms

**Charts**
* **v22.2, #1:** Time: 228 ms
* **v22.2, #2:** Time: 220 ms
* **LWThemes v23.1, #1:** Time: 216 ms
* **LWThemes v23.1, #2:** Time: 208 ms

**Editors**
* **v22.2, #1:** Time: 207 ms
* **v22.2, #2:** Time: 207 ms
* **LWThemes v23.1, #1:** Time: 188 ms
* **LWThemes v23.1, #2:** Time: 186 ms

**Grid**
* **v22.2, #1:** Time: 195 ms
* **v22.2, #2:** Time: 202 ms
* **LWThemes v23.1, #1:** Time: 175 ms
* **LWThemes v23.1, #2:** Time: 166 ms

**Ribbon**
* **v22.2, #1:** Time: 514 ms
* **v22.2, #2:** Time: 515 ms
* **LWThemes v23.1, #1:** Time: 384 ms
* **LWThemes v23.1, #2:** Time: 384 ms

**RichEdit**
* **v22.2, #1:** Time: 729 ms
* **v22.2, #2:** Time: 719 ms
* **LWThemes v23.1, #1:** Time: 710 ms
* **LWThemes v23.1, #2:** Time: 888 ms

**Scheduler**
* **v22.2, #1:** Time: 515 ms
* **v22.2, #2:** Time: 639 ms
* **LWThemes v23.1, #1:** Time: 500 ms
* **LWThemes v23.1, #2:** Time: 452 ms

</details>



# HotStart, NET 7, ReadyToRun

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

**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2, #1:** Time: 1102 ms
* **v22.2, #2:** Time: 1104 ms
* **LWThemes v23.1, #1:** Time: 951 ms
* **LWThemes v23.1, #2:** Time: 1069 ms

**Bars**
* **v22.2, #1:** Time: 283 ms
* **v22.2, #2:** Time: 261 ms
* **LWThemes v23.1, #1:** Time: 204 ms
* **LWThemes v23.1, #2:** Time: 210 ms

**Charts**
* **v22.2, #1:** Time: 251 ms
* **v22.2, #2:** Time: 241 ms
* **LWThemes v23.1, #1:** Time: 253 ms
* **LWThemes v23.1, #2:** Time: 243 ms

**Editors**
* **v22.2, #1:** Time: 254 ms
* **v22.2, #2:** Time: 249 ms
* **LWThemes v23.1, #1:** Time: 231 ms
* **LWThemes v23.1, #2:** Time: 224 ms

**Grid**
* **v22.2, #1:** Time: 381 ms
* **v22.2, #2:** Time: 252 ms
* **LWThemes v23.1, #1:** Time: 233 ms
* **LWThemes v23.1, #2:** Time: 221 ms

**Ribbon**
* **v22.2, #1:** Time: 590 ms
* **v22.2, #2:** Time: 653 ms
* **LWThemes v23.1, #1:** Time: 475 ms
* **LWThemes v23.1, #2:** Time: 480 ms

**RichEdit**
* **v22.2, #1:** Time: 729 ms
* **v22.2, #2:** Time: 736 ms
* **LWThemes v23.1, #1:** Time: 698 ms
* **LWThemes v23.1, #2:** Time: 658 ms

**Scheduler**
* **v22.2, #1:** Time: 723 ms
* **v22.2, #2:** Time: 609 ms
* **LWThemes v23.1, #1:** Time: 616 ms
* **LWThemes v23.1, #2:** Time: 475 ms

</details>


