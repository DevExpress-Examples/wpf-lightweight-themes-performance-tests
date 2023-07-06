# ColdStart, .NET Framework 4.7.2

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


**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2  (baseline), #1:** Time: 7510 ms, TotalMemory: 56470 KB
* **v22.2  (baseline), #2:** Time: 7554 ms, TotalMemory: 56429 KB
* **v22.2  (baseline), #3:** Time: 7527 ms, TotalMemory: 56385 KB
* **v22.2  (baseline), #4:** Time: 7529 ms, TotalMemory: 56675 KB
* **v23.1 , #1:** Time: 6808 ms, TotalMemory: 42984 KB
* **v23.1 , #2:** Time: 7058 ms, TotalMemory: 42897 KB
* **v23.1 , #3:** Time: 6833 ms, TotalMemory: 42703 KB
* **v23.1 , #4:** Time: 6832 ms, TotalMemory: 42905 KB
* **v23.1 LW Themes, #1:** Time: 6011 ms, TotalMemory: 35683 KB
* **v23.1 LW Themes, #2:** Time: 6016 ms, TotalMemory: 35626 KB
* **v23.1 LW Themes, #3:** Time: 6006 ms, TotalMemory: 35640 KB
* **v23.1 LW Themes, #4:** Time: 5957 ms, TotalMemory: 35683 KB

**Bars**
* **v22.2  (baseline), #1:** Time: 2738 ms, TotalMemory: 23569 KB
* **v22.2  (baseline), #2:** Time: 2678 ms, TotalMemory: 23569 KB
* **v22.2  (baseline), #3:** Time: 2711 ms, TotalMemory: 23569 KB
* **v22.2  (baseline), #4:** Time: 2699 ms, TotalMemory: 23569 KB
* **v23.1 , #1:** Time: 2125 ms, TotalMemory: 16055 KB
* **v23.1 , #2:** Time: 2126 ms, TotalMemory: 16055 KB
* **v23.1 , #3:** Time: 2222 ms, TotalMemory: 16053 KB
* **v23.1 , #4:** Time: 2164 ms, TotalMemory: 16052 KB
* **v23.1 LW Themes, #1:** Time: 1812 ms, TotalMemory: 11058 KB
* **v23.1 LW Themes, #2:** Time: 1805 ms, TotalMemory: 11061 KB
* **v23.1 LW Themes, #3:** Time: 1807 ms, TotalMemory: 11072 KB
* **v23.1 LW Themes, #4:** Time: 1794 ms, TotalMemory: 11059 KB

**Charts**
* **v22.2  (baseline), #1:** Time: 2237 ms, TotalMemory: 18590 KB
* **v22.2  (baseline), #2:** Time: 2213 ms, TotalMemory: 18590 KB
* **v22.2  (baseline), #3:** Time: 2270 ms, TotalMemory: 18589 KB
* **v22.2  (baseline), #4:** Time: 2238 ms, TotalMemory: 18588 KB
* **v23.1 , #1:** Time: 2011 ms, TotalMemory: 13296 KB
* **v23.1 , #2:** Time: 2013 ms, TotalMemory: 13296 KB
* **v23.1 , #3:** Time: 2022 ms, TotalMemory: 13296 KB
* **v23.1 , #4:** Time: 2033 ms, TotalMemory: 13296 KB
* **v23.1 LW Themes, #1:** Time: 1818 ms, TotalMemory: 9020 KB
* **v23.1 LW Themes, #2:** Time: 1828 ms, TotalMemory: 9020 KB
* **v23.1 LW Themes, #3:** Time: 1813 ms, TotalMemory: 9020 KB
* **v23.1 LW Themes, #4:** Time: 1794 ms, TotalMemory: 9021 KB

**Editors**
* **v22.2  (baseline), #1:** Time: 2367 ms, TotalMemory: 22092 KB
* **v22.2  (baseline), #2:** Time: 2326 ms, TotalMemory: 22093 KB
* **v22.2  (baseline), #3:** Time: 2374 ms, TotalMemory: 22092 KB
* **v22.2  (baseline), #4:** Time: 2355 ms, TotalMemory: 22093 KB
* **v23.1 , #1:** Time: 2059 ms, TotalMemory: 14860 KB
* **v23.1 , #2:** Time: 2107 ms, TotalMemory: 14943 KB
* **v23.1 , #3:** Time: 2062 ms, TotalMemory: 14901 KB
* **v23.1 , #4:** Time: 2053 ms, TotalMemory: 14859 KB
* **v23.1 LW Themes, #1:** Time: 1943 ms, TotalMemory: 11432 KB
* **v23.1 LW Themes, #2:** Time: 1897 ms, TotalMemory: 11432 KB
* **v23.1 LW Themes, #3:** Time: 1871 ms, TotalMemory: 11432 KB
* **v23.1 LW Themes, #4:** Time: 1820 ms, TotalMemory: 11431 KB

**Grid**
* **v22.2  (baseline), #1:** Time: 3003 ms, TotalMemory: 24903 KB
* **v22.2  (baseline), #2:** Time: 2945 ms, TotalMemory: 24903 KB
* **v22.2  (baseline), #3:** Time: 3266 ms, TotalMemory: 24903 KB
* **v22.2  (baseline), #4:** Time: 3155 ms, TotalMemory: 24903 KB
* **v23.1 , #1:** Time: 2974 ms, TotalMemory: 17566 KB
* **v23.1 , #2:** Time: 2882 ms, TotalMemory: 17567 KB
* **v23.1 , #3:** Time: 2755 ms, TotalMemory: 17567 KB
* **v23.1 , #4:** Time: 2780 ms, TotalMemory: 17567 KB
* **v23.1 LW Themes, #1:** Time: 2513 ms, TotalMemory: 13342 KB
* **v23.1 LW Themes, #2:** Time: 2511 ms, TotalMemory: 13344 KB
* **v23.1 LW Themes, #3:** Time: 2528 ms, TotalMemory: 13344 KB
* **v23.1 LW Themes, #4:** Time: 2466 ms, TotalMemory: 13344 KB

**Ribbon**
* **v22.2  (baseline), #1:** Time: 3757 ms, TotalMemory: 33273 KB
* **v22.2  (baseline), #2:** Time: 3736 ms, TotalMemory: 33272 KB
* **v22.2  (baseline), #3:** Time: 3721 ms, TotalMemory: 33272 KB
* **v22.2  (baseline), #4:** Time: 3737 ms, TotalMemory: 33273 KB
* **v23.1 , #1:** Time: 3149 ms, TotalMemory: 22914 KB
* **v23.1 , #2:** Time: 3084 ms, TotalMemory: 22927 KB
* **v23.1 , #3:** Time: 3082 ms, TotalMemory: 22914 KB
* **v23.1 , #4:** Time: 3077 ms, TotalMemory: 22915 KB
* **v23.1 LW Themes, #1:** Time: 2580 ms, TotalMemory: 16605 KB
* **v23.1 LW Themes, #2:** Time: 2599 ms, TotalMemory: 16605 KB
* **v23.1 LW Themes, #3:** Time: 2632 ms, TotalMemory: 16605 KB
* **v23.1 LW Themes, #4:** Time: 2570 ms, TotalMemory: 16676 KB

**RichEdit**
* **v22.2  (baseline), #1:** Time: 6327 ms, TotalMemory: 38050 KB
* **v22.2  (baseline), #2:** Time: 6120 ms, TotalMemory: 38050 KB
* **v22.2  (baseline), #3:** Time: 6529 ms, TotalMemory: 38049 KB
* **v22.2  (baseline), #4:** Time: 7064 ms, TotalMemory: 38050 KB
* **v23.1 , #1:** Time: 6848 ms, TotalMemory: 34039 KB
* **v23.1 , #2:** Time: 6034 ms, TotalMemory: 34050 KB
* **v23.1 , #3:** Time: 6743 ms, TotalMemory: 34038 KB
* **v23.1 , #4:** Time: 6240 ms, TotalMemory: 34038 KB
* **v23.1 LW Themes, #1:** Time: 5985 ms, TotalMemory: 22232 KB
* **v23.1 LW Themes, #2:** Time: 5704 ms, TotalMemory: 22232 KB
* **v23.1 LW Themes, #3:** Time: 5780 ms, TotalMemory: 22232 KB
* **v23.1 LW Themes, #4:** Time: 5873 ms, TotalMemory: 22232 KB

**Scheduler**
* **v22.2  (baseline), #1:** Time: 4399 ms, TotalMemory: 35893 KB
* **v22.2  (baseline), #2:** Time: 4421 ms, TotalMemory: 35892 KB
* **v22.2  (baseline), #3:** Time: 4380 ms, TotalMemory: 35893 KB
* **v22.2  (baseline), #4:** Time: 4424 ms, TotalMemory: 35893 KB
* **v23.1 , #1:** Time: 4295 ms, TotalMemory: 31714 KB
* **v23.1 , #2:** Time: 4355 ms, TotalMemory: 31714 KB
* **v23.1 , #3:** Time: 4227 ms, TotalMemory: 31714 KB
* **v23.1 , #4:** Time: 4232 ms, TotalMemory: 31713 KB
* **v23.1 LW Themes, #1:** Time: 3696 ms, TotalMemory: 20924 KB
* **v23.1 LW Themes, #2:** Time: 3603 ms, TotalMemory: 20923 KB
* **v23.1 LW Themes, #3:** Time: 3655 ms, TotalMemory: 20924 KB
* **v23.1 LW Themes, #4:** Time: 3621 ms, TotalMemory: 20923 KB

</details>



# ColdStart, .NET 7

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


**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2  (baseline), #1:** Time: 6433 ms, TotalMemory: 89029 KB
* **v22.2  (baseline), #2:** Time: 7995 ms, TotalMemory: 88844 KB
* **v22.2  (baseline), #3:** Time: 6946 ms, TotalMemory: 89000 KB
* **v22.2  (baseline), #4:** Time: 6575 ms, TotalMemory: 89028 KB
* **v23.1 , #1:** Time: 5684 ms, TotalMemory: 70648 KB
* **v23.1 , #2:** Time: 5729 ms, TotalMemory: 70460 KB
* **v23.1 , #3:** Time: 5791 ms, TotalMemory: 70642 KB
* **v23.1 , #4:** Time: 5713 ms, TotalMemory: 70584 KB
* **v23.1 LW Themes, #1:** Time: 4914 ms, TotalMemory: 60478 KB
* **v23.1 LW Themes, #2:** Time: 4935 ms, TotalMemory: 60400 KB
* **v23.1 LW Themes, #3:** Time: 4914 ms, TotalMemory: 60316 KB
* **v23.1 LW Themes, #4:** Time: 4939 ms, TotalMemory: 60357 KB

**Bars**
* **v22.2  (baseline), #1:** Time: 2500 ms, TotalMemory: 35547 KB
* **v22.2  (baseline), #2:** Time: 2533 ms, TotalMemory: 35548 KB
* **v22.2  (baseline), #3:** Time: 2627 ms, TotalMemory: 35528 KB
* **v22.2  (baseline), #4:** Time: 2542 ms, TotalMemory: 35550 KB
* **v23.1 , #1:** Time: 1805 ms, TotalMemory: 25438 KB
* **v23.1 , #2:** Time: 1786 ms, TotalMemory: 25422 KB
* **v23.1 , #3:** Time: 1800 ms, TotalMemory: 25433 KB
* **v23.1 , #4:** Time: 1779 ms, TotalMemory: 25439 KB
* **v23.1 LW Themes, #1:** Time: 1515 ms, TotalMemory: 18194 KB
* **v23.1 LW Themes, #2:** Time: 1522 ms, TotalMemory: 18180 KB
* **v23.1 LW Themes, #3:** Time: 1542 ms, TotalMemory: 18174 KB
* **v23.1 LW Themes, #4:** Time: 1534 ms, TotalMemory: 18182 KB

**Charts**
* **v22.2  (baseline), #1:** Time: 1978 ms, TotalMemory: 27858 KB
* **v22.2  (baseline), #2:** Time: 1801 ms, TotalMemory: 27886 KB
* **v22.2  (baseline), #3:** Time: 1778 ms, TotalMemory: 27893 KB
* **v22.2  (baseline), #4:** Time: 1800 ms, TotalMemory: 27919 KB
* **v23.1 , #1:** Time: 1818 ms, TotalMemory: 20480 KB
* **v23.1 , #2:** Time: 1629 ms, TotalMemory: 20480 KB
* **v23.1 , #3:** Time: 1641 ms, TotalMemory: 20480 KB
* **v23.1 , #4:** Time: 1634 ms, TotalMemory: 20473 KB
* **v23.1 LW Themes, #1:** Time: 1456 ms, TotalMemory: 14787 KB
* **v23.1 LW Themes, #2:** Time: 1475 ms, TotalMemory: 14783 KB
* **v23.1 LW Themes, #3:** Time: 1473 ms, TotalMemory: 14783 KB
* **v23.1 LW Themes, #4:** Time: 1486 ms, TotalMemory: 14787 KB

**Editors**
* **v22.2  (baseline), #1:** Time: 2216 ms, TotalMemory: 33269 KB
* **v22.2  (baseline), #2:** Time: 2214 ms, TotalMemory: 33191 KB
* **v22.2  (baseline), #3:** Time: 2215 ms, TotalMemory: 33181 KB
* **v22.2  (baseline), #4:** Time: 2216 ms, TotalMemory: 33258 KB
* **v23.1 , #1:** Time: 1735 ms, TotalMemory: 23471 KB
* **v23.1 , #2:** Time: 1756 ms, TotalMemory: 23464 KB
* **v23.1 , #3:** Time: 1888 ms, TotalMemory: 23409 KB
* **v23.1 , #4:** Time: 1804 ms, TotalMemory: 23437 KB
* **v23.1 LW Themes, #1:** Time: 1576 ms, TotalMemory: 18962 KB
* **v23.1 LW Themes, #2:** Time: 1561 ms, TotalMemory: 18927 KB
* **v23.1 LW Themes, #3:** Time: 1577 ms, TotalMemory: 18916 KB
* **v23.1 LW Themes, #4:** Time: 1565 ms, TotalMemory: 18882 KB

**Grid**
* **v22.2  (baseline), #1:** Time: 2413 ms, TotalMemory: 37688 KB
* **v22.2  (baseline), #2:** Time: 2326 ms, TotalMemory: 37692 KB
* **v22.2  (baseline), #3:** Time: 2306 ms, TotalMemory: 37611 KB
* **v22.2  (baseline), #4:** Time: 2332 ms, TotalMemory: 37692 KB
* **v23.1 , #1:** Time: 2163 ms, TotalMemory: 27405 KB
* **v23.1 , #2:** Time: 2145 ms, TotalMemory: 27406 KB
* **v23.1 , #3:** Time: 2134 ms, TotalMemory: 27400 KB
* **v23.1 , #4:** Time: 2143 ms, TotalMemory: 27427 KB
* **v23.1 LW Themes, #1:** Time: 1903 ms, TotalMemory: 22066 KB
* **v23.1 LW Themes, #2:** Time: 1900 ms, TotalMemory: 22049 KB
* **v23.1 LW Themes, #3:** Time: 1891 ms, TotalMemory: 22056 KB
* **v23.1 LW Themes, #4:** Time: 1890 ms, TotalMemory: 22058 KB

**Ribbon**
* **v22.2  (baseline), #1:** Time: 3366 ms, TotalMemory: 50831 KB
* **v22.2  (baseline), #2:** Time: 3393 ms, TotalMemory: 50838 KB
* **v22.2  (baseline), #3:** Time: 3432 ms, TotalMemory: 50835 KB
* **v22.2  (baseline), #4:** Time: 3420 ms, TotalMemory: 50792 KB
* **v23.1 , #1:** Time: 2741 ms, TotalMemory: 36794 KB
* **v23.1 , #2:** Time: 2809 ms, TotalMemory: 36801 KB
* **v23.1 , #3:** Time: 2792 ms, TotalMemory: 36788 KB
* **v23.1 , #4:** Time: 2801 ms, TotalMemory: 36821 KB
* **v23.1 LW Themes, #1:** Time: 2286 ms, TotalMemory: 27837 KB
* **v23.1 LW Themes, #2:** Time: 2334 ms, TotalMemory: 27840 KB
* **v23.1 LW Themes, #3:** Time: 2284 ms, TotalMemory: 27834 KB
* **v23.1 LW Themes, #4:** Time: 2344 ms, TotalMemory: 27840 KB

**RichEdit**
* **v22.2  (baseline), #1:** Time: 5571 ms, TotalMemory: 56189 KB
* **v22.2  (baseline), #2:** Time: 4735 ms, TotalMemory: 56214 KB
* **v22.2  (baseline), #3:** Time: 4632 ms, TotalMemory: 56196 KB
* **v22.2  (baseline), #4:** Time: 5201 ms, TotalMemory: 56218 KB
* **v23.1 , #1:** Time: 5366 ms, TotalMemory: 50425 KB
* **v23.1 , #2:** Time: 5147 ms, TotalMemory: 50412 KB
* **v23.1 , #3:** Time: 4955 ms, TotalMemory: 50419 KB
* **v23.1 , #4:** Time: 4243 ms, TotalMemory: 50427 KB
* **v23.1 LW Themes, #1:** Time: 3888 ms, TotalMemory: 34345 KB
* **v23.1 LW Themes, #2:** Time: 3639 ms, TotalMemory: 34395 KB
* **v23.1 LW Themes, #3:** Time: 3893 ms, TotalMemory: 34383 KB
* **v23.1 LW Themes, #4:** Time: 3910 ms, TotalMemory: 34338 KB

**Scheduler**
* **v22.2  (baseline), #1:** Time: 4160 ms, TotalMemory: 55728 KB
* **v22.2  (baseline), #2:** Time: 3948 ms, TotalMemory: 55643 KB
* **v22.2  (baseline), #3:** Time: 3948 ms, TotalMemory: 55769 KB
* **v22.2  (baseline), #4:** Time: 3688 ms, TotalMemory: 55772 KB
* **v23.1 , #1:** Time: 3625 ms, TotalMemory: 49708 KB
* **v23.1 , #2:** Time: 3411 ms, TotalMemory: 49691 KB
* **v23.1 , #3:** Time: 3404 ms, TotalMemory: 49684 KB
* **v23.1 , #4:** Time: 3435 ms, TotalMemory: 49677 KB
* **v23.1 LW Themes, #1:** Time: 2941 ms, TotalMemory: 34822 KB
* **v23.1 LW Themes, #2:** Time: 2974 ms, TotalMemory: 34834 KB
* **v23.1 LW Themes, #3:** Time: 2923 ms, TotalMemory: 34822 KB
* **v23.1 LW Themes, #4:** Time: 3008 ms, TotalMemory: 34815 KB

</details>



# ColdStart, .NET Framework 4.7.2, Ngen

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


**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2  (baseline), #1:** Time: 4126 ms, TotalMemory: 56762 KB
* **v22.2  (baseline), #2:** Time: 4273 ms, TotalMemory: 56841 KB
* **v22.2  (baseline), #3:** Time: 4024 ms, TotalMemory: 56842 KB
* **v22.2  (baseline), #4:** Time: 4422 ms, TotalMemory: 56881 KB
* **v23.1 , #1:** Time: 2915 ms, TotalMemory: 43696 KB
* **v23.1 , #2:** Time: 2820 ms, TotalMemory: 43256 KB
* **v23.1 , #3:** Time: 2995 ms, TotalMemory: 43704 KB
* **v23.1 , #4:** Time: 2810 ms, TotalMemory: 43240 KB
* **v23.1 LW Themes, #1:** Time: 2463 ms, TotalMemory: 36306 KB
* **v23.1 LW Themes, #2:** Time: 2460 ms, TotalMemory: 36305 KB
* **v23.1 LW Themes, #3:** Time: 2555 ms, TotalMemory: 36357 KB
* **v23.1 LW Themes, #4:** Time: 2428 ms, TotalMemory: 36260 KB

**Bars**
* **v22.2  (baseline), #1:** Time: 2312 ms, TotalMemory: 23490 KB
* **v22.2  (baseline), #2:** Time: 1286 ms, TotalMemory: 23490 KB
* **v22.2  (baseline), #3:** Time: 1269 ms, TotalMemory: 23490 KB
* **v22.2  (baseline), #4:** Time: 1267 ms, TotalMemory: 23490 KB
* **v23.1 , #1:** Time: 1047 ms, TotalMemory: 16049 KB
* **v23.1 , #2:** Time: 972 ms, TotalMemory: 16048 KB
* **v23.1 , #3:** Time: 972 ms, TotalMemory: 16186 KB
* **v23.1 , #4:** Time: 999 ms, TotalMemory: 16190 KB
* **v23.1 LW Themes, #1:** Time: 831 ms, TotalMemory: 11063 KB
* **v23.1 LW Themes, #2:** Time: 813 ms, TotalMemory: 11064 KB
* **v23.1 LW Themes, #3:** Time: 796 ms, TotalMemory: 11064 KB
* **v23.1 LW Themes, #4:** Time: 812 ms, TotalMemory: 11064 KB

**Charts**
* **v22.2  (baseline), #1:** Time: 1089 ms, TotalMemory: 18537 KB
* **v22.2  (baseline), #2:** Time: 761 ms, TotalMemory: 18538 KB
* **v22.2  (baseline), #3:** Time: 811 ms, TotalMemory: 18538 KB
* **v22.2  (baseline), #4:** Time: 809 ms, TotalMemory: 18536 KB
* **v23.1 , #1:** Time: 890 ms, TotalMemory: 13278 KB
* **v23.1 , #2:** Time: 669 ms, TotalMemory: 13278 KB
* **v23.1 , #3:** Time: 662 ms, TotalMemory: 13278 KB
* **v23.1 , #4:** Time: 636 ms, TotalMemory: 13278 KB
* **v23.1 LW Themes, #1:** Time: 512 ms, TotalMemory: 9008 KB
* **v23.1 LW Themes, #2:** Time: 528 ms, TotalMemory: 9008 KB
* **v23.1 LW Themes, #3:** Time: 497 ms, TotalMemory: 9008 KB
* **v23.1 LW Themes, #4:** Time: 498 ms, TotalMemory: 9008 KB

**Editors**
* **v22.2  (baseline), #1:** Time: 1077 ms, TotalMemory: 22085 KB
* **v22.2  (baseline), #2:** Time: 964 ms, TotalMemory: 22085 KB
* **v22.2  (baseline), #3:** Time: 1049 ms, TotalMemory: 22083 KB
* **v22.2  (baseline), #4:** Time: 924 ms, TotalMemory: 22042 KB
* **v23.1 , #1:** Time: 897 ms, TotalMemory: 14897 KB
* **v23.1 , #2:** Time: 859 ms, TotalMemory: 14856 KB
* **v23.1 , #3:** Time: 842 ms, TotalMemory: 14939 KB
* **v23.1 , #4:** Time: 837 ms, TotalMemory: 14898 KB
* **v23.1 LW Themes, #1:** Time: 685 ms, TotalMemory: 11507 KB
* **v23.1 LW Themes, #2:** Time: 685 ms, TotalMemory: 11466 KB
* **v23.1 LW Themes, #3:** Time: 689 ms, TotalMemory: 11466 KB
* **v23.1 LW Themes, #4:** Time: 684 ms, TotalMemory: 11466 KB

**Grid**
* **v22.2  (baseline), #1:** Time: 1021 ms, TotalMemory: 24904 KB
* **v22.2  (baseline), #2:** Time: 1048 ms, TotalMemory: 24904 KB
* **v22.2  (baseline), #3:** Time: 1028 ms, TotalMemory: 24904 KB
* **v22.2  (baseline), #4:** Time: 1045 ms, TotalMemory: 24904 KB
* **v23.1 , #1:** Time: 887 ms, TotalMemory: 17557 KB
* **v23.1 , #2:** Time: 883 ms, TotalMemory: 17557 KB
* **v23.1 , #3:** Time: 856 ms, TotalMemory: 17557 KB
* **v23.1 , #4:** Time: 903 ms, TotalMemory: 17557 KB
* **v23.1 LW Themes, #1:** Time: 665 ms, TotalMemory: 13341 KB
* **v23.1 LW Themes, #2:** Time: 670 ms, TotalMemory: 13341 KB
* **v23.1 LW Themes, #3:** Time: 687 ms, TotalMemory: 13341 KB
* **v23.1 LW Themes, #4:** Time: 677 ms, TotalMemory: 13341 KB

**Ribbon**
* **v22.2  (baseline), #1:** Time: 2730 ms, TotalMemory: 33225 KB
* **v22.2  (baseline), #2:** Time: 1941 ms, TotalMemory: 33224 KB
* **v22.2  (baseline), #3:** Time: 1934 ms, TotalMemory: 33226 KB
* **v22.2  (baseline), #4:** Time: 1960 ms, TotalMemory: 33225 KB
* **v23.1 , #1:** Time: 1461 ms, TotalMemory: 23223 KB
* **v23.1 , #2:** Time: 1409 ms, TotalMemory: 23230 KB
* **v23.1 , #3:** Time: 1411 ms, TotalMemory: 23227 KB
* **v23.1 , #4:** Time: 1421 ms, TotalMemory: 23231 KB
* **v23.1 LW Themes, #1:** Time: 1102 ms, TotalMemory: 17117 KB
* **v23.1 LW Themes, #2:** Time: 1080 ms, TotalMemory: 17149 KB
* **v23.1 LW Themes, #3:** Time: 1129 ms, TotalMemory: 17154 KB
* **v23.1 LW Themes, #4:** Time: 1104 ms, TotalMemory: 17151 KB

**RichEdit**
* **v22.2  (baseline), #1:** Time: 2967 ms, TotalMemory: 38022 KB
* **v22.2  (baseline), #2:** Time: 1722 ms, TotalMemory: 38021 KB
* **v22.2  (baseline), #3:** Time: 1735 ms, TotalMemory: 38021 KB
* **v22.2  (baseline), #4:** Time: 1713 ms, TotalMemory: 38022 KB
* **v23.1 , #1:** Time: 2395 ms, TotalMemory: 34034 KB
* **v23.1 , #2:** Time: 2921 ms, TotalMemory: 34036 KB
* **v23.1 , #3:** Time: 1956 ms, TotalMemory: 34035 KB
* **v23.1 , #4:** Time: 1652 ms, TotalMemory: 34047 KB
* **v23.1 LW Themes, #1:** Time: 1309 ms, TotalMemory: 22225 KB
* **v23.1 LW Themes, #2:** Time: 1367 ms, TotalMemory: 22237 KB
* **v23.1 LW Themes, #3:** Time: 2285 ms, TotalMemory: 22225 KB
* **v23.1 LW Themes, #4:** Time: 1826 ms, TotalMemory: 22225 KB

**Scheduler**
* **v22.2  (baseline), #1:** Time: 2081 ms, TotalMemory: 35914 KB
* **v22.2  (baseline), #2:** Time: 1833 ms, TotalMemory: 35914 KB
* **v22.2  (baseline), #3:** Time: 1817 ms, TotalMemory: 35914 KB
* **v22.2  (baseline), #4:** Time: 1790 ms, TotalMemory: 35914 KB
* **v23.1 , #1:** Time: 2489 ms, TotalMemory: 31761 KB
* **v23.1 , #2:** Time: 1674 ms, TotalMemory: 31760 KB
* **v23.1 , #3:** Time: 1651 ms, TotalMemory: 31761 KB
* **v23.1 , #4:** Time: 1664 ms, TotalMemory: 31760 KB
* **v23.1 LW Themes, #1:** Time: 1271 ms, TotalMemory: 20907 KB
* **v23.1 LW Themes, #2:** Time: 1268 ms, TotalMemory: 20906 KB
* **v23.1 LW Themes, #3:** Time: 1243 ms, TotalMemory: 20907 KB
* **v23.1 LW Themes, #4:** Time: 1258 ms, TotalMemory: 20906 KB

</details>



# ColdStart, .NET 7, ReadyToRun

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


**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2  (baseline), #1:** Time: 5321 ms, TotalMemory: 59876 KB
* **v22.2  (baseline), #2:** Time: 4922 ms, TotalMemory: 59361 KB
* **v22.2  (baseline), #3:** Time: 4930 ms, TotalMemory: 62190 KB
* **v22.2  (baseline), #4:** Time: 5342 ms, TotalMemory: 63034 KB
* **v23.1 , #1:** Time: 4453 ms, TotalMemory: 46573 KB
* **v23.1 , #2:** Time: 4520 ms, TotalMemory: 46457 KB
* **v23.1 , #3:** Time: 4442 ms, TotalMemory: 45947 KB
* **v23.1 , #4:** Time: 4392 ms, TotalMemory: 46340 KB
* **v23.1 LW Themes, #1:** Time: 3615 ms, TotalMemory: 38443 KB
* **v23.1 LW Themes, #2:** Time: 3536 ms, TotalMemory: 38159 KB
* **v23.1 LW Themes, #3:** Time: 3590 ms, TotalMemory: 38266 KB
* **v23.1 LW Themes, #4:** Time: 3601 ms, TotalMemory: 38408 KB

**Bars**
* **v22.2  (baseline), #1:** Time: 1949 ms, TotalMemory: 27877 KB
* **v22.2  (baseline), #2:** Time: 1944 ms, TotalMemory: 24378 KB
* **v22.2  (baseline), #3:** Time: 1909 ms, TotalMemory: 29854 KB
* **v22.2  (baseline), #4:** Time: 1943 ms, TotalMemory: 24369 KB
* **v23.1 , #1:** Time: 1460 ms, TotalMemory: 21821 KB
* **v23.1 , #2:** Time: 1465 ms, TotalMemory: 19861 KB
* **v23.1 , #3:** Time: 1430 ms, TotalMemory: 21865 KB
* **v23.1 , #4:** Time: 1456 ms, TotalMemory: 19780 KB
* **v23.1 LW Themes, #1:** Time: 1236 ms, TotalMemory: 16431 KB
* **v23.1 LW Themes, #2:** Time: 1215 ms, TotalMemory: 16519 KB
* **v23.1 LW Themes, #3:** Time: 1207 ms, TotalMemory: 16438 KB
* **v23.1 LW Themes, #4:** Time: 1243 ms, TotalMemory: 15859 KB

**Charts**
* **v22.2  (baseline), #1:** Time: 1686 ms, TotalMemory: 20997 KB
* **v22.2  (baseline), #2:** Time: 1459 ms, TotalMemory: 24523 KB
* **v22.2  (baseline), #3:** Time: 1488 ms, TotalMemory: 21014 KB
* **v22.2  (baseline), #4:** Time: 1446 ms, TotalMemory: 24785 KB
* **v23.1 , #1:** Time: 1372 ms, TotalMemory: 18235 KB
* **v23.1 , #2:** Time: 1315 ms, TotalMemory: 18303 KB
* **v23.1 , #3:** Time: 1314 ms, TotalMemory: 18233 KB
* **v23.1 , #4:** Time: 1340 ms, TotalMemory: 18240 KB
* **v23.1 LW Themes, #1:** Time: 1143 ms, TotalMemory: 10269 KB
* **v23.1 LW Themes, #2:** Time: 1156 ms, TotalMemory: 10262 KB
* **v23.1 LW Themes, #3:** Time: 1133 ms, TotalMemory: 10276 KB
* **v23.1 LW Themes, #4:** Time: 1116 ms, TotalMemory: 10256 KB

**Editors**
* **v22.2  (baseline), #1:** Time: 1640 ms, TotalMemory: 28222 KB
* **v22.2  (baseline), #2:** Time: 1636 ms, TotalMemory: 28408 KB
* **v22.2  (baseline), #3:** Time: 1655 ms, TotalMemory: 28379 KB
* **v22.2  (baseline), #4:** Time: 1639 ms, TotalMemory: 28393 KB
* **v23.1 , #1:** Time: 1475 ms, TotalMemory: 16433 KB
* **v23.1 , #2:** Time: 1445 ms, TotalMemory: 16426 KB
* **v23.1 , #3:** Time: 1477 ms, TotalMemory: 20581 KB
* **v23.1 , #4:** Time: 1469 ms, TotalMemory: 16449 KB
* **v23.1 LW Themes, #1:** Time: 1299 ms, TotalMemory: 13646 KB
* **v23.1 LW Themes, #2:** Time: 1276 ms, TotalMemory: 13670 KB
* **v23.1 LW Themes, #3:** Time: 1267 ms, TotalMemory: 13640 KB
* **v23.1 LW Themes, #4:** Time: 1263 ms, TotalMemory: 13641 KB

**Grid**
* **v22.2  (baseline), #1:** Time: 1854 ms, TotalMemory: 28797 KB
* **v22.2  (baseline), #2:** Time: 1826 ms, TotalMemory: 27140 KB
* **v22.2  (baseline), #3:** Time: 1823 ms, TotalMemory: 27020 KB
* **v22.2  (baseline), #4:** Time: 1853 ms, TotalMemory: 25741 KB
* **v23.1 , #1:** Time: 1583 ms, TotalMemory: 23754 KB
* **v23.1 , #2:** Time: 1588 ms, TotalMemory: 23798 KB
* **v23.1 , #3:** Time: 1627 ms, TotalMemory: 20215 KB
* **v23.1 , #4:** Time: 1575 ms, TotalMemory: 23820 KB
* **v23.1 LW Themes, #1:** Time: 1328 ms, TotalMemory: 16747 KB
* **v23.1 LW Themes, #2:** Time: 1296 ms, TotalMemory: 16743 KB
* **v23.1 LW Themes, #3:** Time: 1319 ms, TotalMemory: 16739 KB
* **v23.1 LW Themes, #4:** Time: 1332 ms, TotalMemory: 16742 KB

**Ribbon**
* **v22.2  (baseline), #1:** Time: 2779 ms, TotalMemory: 34733 KB
* **v22.2  (baseline), #2:** Time: 2997 ms, TotalMemory: 34691 KB
* **v22.2  (baseline), #3:** Time: 2806 ms, TotalMemory: 36504 KB
* **v22.2  (baseline), #4:** Time: 2772 ms, TotalMemory: 34636 KB
* **v23.1 , #1:** Time: 2253 ms, TotalMemory: 29090 KB
* **v23.1 , #2:** Time: 2244 ms, TotalMemory: 26732 KB
* **v23.1 , #3:** Time: 2266 ms, TotalMemory: 26804 KB
* **v23.1 , #4:** Time: 2278 ms, TotalMemory: 26785 KB
* **v23.1 LW Themes, #1:** Time: 1848 ms, TotalMemory: 20931 KB
* **v23.1 LW Themes, #2:** Time: 1811 ms, TotalMemory: 20979 KB
* **v23.1 LW Themes, #3:** Time: 1785 ms, TotalMemory: 23131 KB
* **v23.1 LW Themes, #4:** Time: 1808 ms, TotalMemory: 20935 KB

**RichEdit**
* **v22.2  (baseline), #1:** Time: 4042 ms, TotalMemory: 44310 KB
* **v22.2  (baseline), #2:** Time: 3506 ms, TotalMemory: 41870 KB
* **v22.2  (baseline), #3:** Time: 3842 ms, TotalMemory: 41873 KB
* **v22.2  (baseline), #4:** Time: 3064 ms, TotalMemory: 41867 KB
* **v23.1 , #1:** Time: 3611 ms, TotalMemory: 37671 KB
* **v23.1 , #2:** Time: 3701 ms, TotalMemory: 39948 KB
* **v23.1 , #3:** Time: 3489 ms, TotalMemory: 37714 KB
* **v23.1 , #4:** Time: 2959 ms, TotalMemory: 40075 KB
* **v23.1 LW Themes, #1:** Time: 3971 ms, TotalMemory: 27764 KB
* **v23.1 LW Themes, #2:** Time: 2975 ms, TotalMemory: 26683 KB
* **v23.1 LW Themes, #3:** Time: 3120 ms, TotalMemory: 26516 KB
* **v23.1 LW Themes, #4:** Time: 2438 ms, TotalMemory: 26863 KB

**Scheduler**
* **v22.2  (baseline), #1:** Time: 3075 ms, TotalMemory: 39063 KB
* **v22.2  (baseline), #2:** Time: 2835 ms, TotalMemory: 39192 KB
* **v22.2  (baseline), #3:** Time: 2906 ms, TotalMemory: 40798 KB
* **v22.2  (baseline), #4:** Time: 2896 ms, TotalMemory: 39079 KB
* **v23.1 , #1:** Time: 2902 ms, TotalMemory: 35289 KB
* **v23.1 , #2:** Time: 2742 ms, TotalMemory: 35311 KB
* **v23.1 , #3:** Time: 2748 ms, TotalMemory: 35274 KB
* **v23.1 , #4:** Time: 2743 ms, TotalMemory: 35280 KB
* **v23.1 LW Themes, #1:** Time: 2322 ms, TotalMemory: 24600 KB
* **v23.1 LW Themes, #2:** Time: 2255 ms, TotalMemory: 24623 KB
* **v23.1 LW Themes, #3:** Time: 2304 ms, TotalMemory: 24589 KB
* **v23.1 LW Themes, #4:** Time: 2266 ms, TotalMemory: 24618 KB

</details>



# HotStart, .NET Framework 4.7.2

**Perfomance**
|  Test | v22.2  (baseline) | v23.1  | v23.1 LW Themes |
|  ----- | ----- | ----- | ----- |
|  Main | 1054 ms | 1067 ms, -1.23% | 909 ms, 13.76% |
|  Bars | 210 ms | 206 ms, 1.90% | 166 ms, 20.95% |
|  Charts | 205 ms | 205 ms, 0.00% | 212 ms, -3.41% |
|  Editors | 198 ms | 193 ms, 2.53% | 189 ms, 4.55% |
|  Grid | 202 ms | 203 ms, -0.50% | 182 ms, 9.90% |
|  Ribbon | 491 ms | 492 ms, -0.20% | 406 ms, 17.31% |
|  RichEdit | 810 ms | 735 ms, 9.26% | 661 ms, 18.40% |
|  Scheduler | 539 ms | 559 ms, -3.71% | 480 ms, 10.95% |

**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2  (baseline), #1:** Time: 1045 ms
* **v22.2  (baseline), #2:** Time: 1075 ms
* **v22.2  (baseline), #3:** Time: 1044 ms
* **v23.1 , #1:** Time: 1051 ms
* **v23.1 , #2:** Time: 1055 ms
* **v23.1 , #3:** Time: 1097 ms
* **v23.1 LW Themes, #1:** Time: 909 ms
* **v23.1 LW Themes, #2:** Time: 914 ms
* **v23.1 LW Themes, #3:** Time: 905 ms

**Bars**
* **v22.2  (baseline), #1:** Time: 211 ms
* **v22.2  (baseline), #2:** Time: 208 ms
* **v22.2  (baseline), #3:** Time: 211 ms
* **v23.1 , #1:** Time: 204 ms
* **v23.1 , #2:** Time: 208 ms
* **v23.1 , #3:** Time: 206 ms
* **v23.1 LW Themes, #1:** Time: 167 ms
* **v23.1 LW Themes, #2:** Time: 167 ms
* **v23.1 LW Themes, #3:** Time: 164 ms

**Charts**
* **v22.2  (baseline), #1:** Time: 207 ms
* **v22.2  (baseline), #2:** Time: 201 ms
* **v22.2  (baseline), #3:** Time: 208 ms
* **v23.1 , #1:** Time: 204 ms
* **v23.1 , #2:** Time: 210 ms
* **v23.1 , #3:** Time: 202 ms
* **v23.1 LW Themes, #1:** Time: 218 ms
* **v23.1 LW Themes, #2:** Time: 210 ms
* **v23.1 LW Themes, #3:** Time: 210 ms

**Editors**
* **v22.2  (baseline), #1:** Time: 199 ms
* **v22.2  (baseline), #2:** Time: 199 ms
* **v22.2  (baseline), #3:** Time: 198 ms
* **v23.1 , #1:** Time: 194 ms
* **v23.1 , #2:** Time: 189 ms
* **v23.1 , #3:** Time: 197 ms
* **v23.1 LW Themes, #1:** Time: 191 ms
* **v23.1 LW Themes, #2:** Time: 188 ms
* **v23.1 LW Themes, #3:** Time: 189 ms

**Grid**
* **v22.2  (baseline), #1:** Time: 203 ms
* **v22.2  (baseline), #2:** Time: 201 ms
* **v22.2  (baseline), #3:** Time: 203 ms
* **v23.1 , #1:** Time: 207 ms
* **v23.1 , #2:** Time: 201 ms
* **v23.1 , #3:** Time: 201 ms
* **v23.1 LW Themes, #1:** Time: 177 ms
* **v23.1 LW Themes, #2:** Time: 176 ms
* **v23.1 LW Themes, #3:** Time: 193 ms

**Ribbon**
* **v22.2  (baseline), #1:** Time: 494 ms
* **v22.2  (baseline), #2:** Time: 489 ms
* **v22.2  (baseline), #3:** Time: 491 ms
* **v23.1 , #1:** Time: 500 ms
* **v23.1 , #2:** Time: 487 ms
* **v23.1 , #3:** Time: 489 ms
* **v23.1 LW Themes, #1:** Time: 394 ms
* **v23.1 LW Themes, #2:** Time: 405 ms
* **v23.1 LW Themes, #3:** Time: 420 ms

**RichEdit**
* **v22.2  (baseline), #1:** Time: 706 ms
* **v22.2  (baseline), #2:** Time: 1003 ms
* **v22.2  (baseline), #3:** Time: 723 ms
* **v23.1 , #1:** Time: 728 ms
* **v23.1 , #2:** Time: 754 ms
* **v23.1 , #3:** Time: 724 ms
* **v23.1 LW Themes, #1:** Time: 782 ms
* **v23.1 LW Themes, #2:** Time: 544 ms
* **v23.1 LW Themes, #3:** Time: 659 ms

**Scheduler**
* **v22.2  (baseline), #1:** Time: 511 ms
* **v22.2  (baseline), #2:** Time: 595 ms
* **v22.2  (baseline), #3:** Time: 511 ms
* **v23.1 , #1:** Time: 641 ms
* **v23.1 , #2:** Time: 509 ms
* **v23.1 , #3:** Time: 527 ms
* **v23.1 LW Themes, #1:** Time: 476 ms
* **v23.1 LW Themes, #2:** Time: 476 ms
* **v23.1 LW Themes, #3:** Time: 488 ms

</details>



# HotStart, .NET 7

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

**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2  (baseline), #1:** Time: 1094 ms
* **v22.2  (baseline), #2:** Time: 1088 ms
* **v22.2  (baseline), #3:** Time: 1099 ms
* **v23.1 , #1:** Time: 1093 ms
* **v23.1 , #2:** Time: 1067 ms
* **v23.1 , #3:** Time: 1075 ms
* **v23.1 LW Themes, #1:** Time: 949 ms
* **v23.1 LW Themes, #2:** Time: 964 ms
* **v23.1 LW Themes, #3:** Time: 942 ms

**Bars**
* **v22.2  (baseline), #1:** Time: 261 ms
* **v22.2  (baseline), #2:** Time: 260 ms
* **v22.2  (baseline), #3:** Time: 264 ms
* **v23.1 , #1:** Time: 256 ms
* **v23.1 , #2:** Time: 265 ms
* **v23.1 , #3:** Time: 249 ms
* **v23.1 LW Themes, #1:** Time: 196 ms
* **v23.1 LW Themes, #2:** Time: 197 ms
* **v23.1 LW Themes, #3:** Time: 192 ms

**Charts**
* **v22.2  (baseline), #1:** Time: 247 ms
* **v22.2  (baseline), #2:** Time: 244 ms
* **v22.2  (baseline), #3:** Time: 249 ms
* **v23.1 , #1:** Time: 246 ms
* **v23.1 , #2:** Time: 244 ms
* **v23.1 , #3:** Time: 240 ms
* **v23.1 LW Themes, #1:** Time: 249 ms
* **v23.1 LW Themes, #2:** Time: 239 ms
* **v23.1 LW Themes, #3:** Time: 242 ms

**Editors**
* **v22.2  (baseline), #1:** Time: 259 ms
* **v22.2  (baseline), #2:** Time: 254 ms
* **v22.2  (baseline), #3:** Time: 258 ms
* **v23.1 , #1:** Time: 231 ms
* **v23.1 , #2:** Time: 228 ms
* **v23.1 , #3:** Time: 239 ms
* **v23.1 LW Themes, #1:** Time: 229 ms
* **v23.1 LW Themes, #2:** Time: 228 ms
* **v23.1 LW Themes, #3:** Time: 226 ms

**Grid**
* **v22.2  (baseline), #1:** Time: 234 ms
* **v22.2  (baseline), #2:** Time: 287 ms
* **v22.2  (baseline), #3:** Time: 250 ms
* **v23.1 , #1:** Time: 231 ms
* **v23.1 , #2:** Time: 227 ms
* **v23.1 , #3:** Time: 232 ms
* **v23.1 LW Themes, #1:** Time: 227 ms
* **v23.1 LW Themes, #2:** Time: 219 ms
* **v23.1 LW Themes, #3:** Time: 238 ms

**Ribbon**
* **v22.2  (baseline), #1:** Time: 548 ms
* **v22.2  (baseline), #2:** Time: 550 ms
* **v22.2  (baseline), #3:** Time: 573 ms
* **v23.1 , #1:** Time: 522 ms
* **v23.1 , #2:** Time: 538 ms
* **v23.1 , #3:** Time: 520 ms
* **v23.1 LW Themes, #1:** Time: 446 ms
* **v23.1 LW Themes, #2:** Time: 449 ms
* **v23.1 LW Themes, #3:** Time: 464 ms

**RichEdit**
* **v22.2  (baseline), #1:** Time: 712 ms
* **v22.2  (baseline), #2:** Time: 665 ms
* **v22.2  (baseline), #3:** Time: 852 ms
* **v23.1 , #1:** Time: 700 ms
* **v23.1 , #2:** Time: 784 ms
* **v23.1 , #3:** Time: 652 ms
* **v23.1 LW Themes, #1:** Time: 748 ms
* **v23.1 LW Themes, #2:** Time: 602 ms
* **v23.1 LW Themes, #3:** Time: 638 ms

**Scheduler**
* **v22.2  (baseline), #1:** Time: 513 ms
* **v22.2  (baseline), #2:** Time: 536 ms
* **v22.2  (baseline), #3:** Time: 617 ms
* **v23.1 , #1:** Time: 549 ms
* **v23.1 , #2:** Time: 521 ms
* **v23.1 , #3:** Time: 516 ms
* **v23.1 LW Themes, #1:** Time: 503 ms
* **v23.1 LW Themes, #2:** Time: 472 ms
* **v23.1 LW Themes, #3:** Time: 472 ms

</details>



# HotStart, .NET Framework 4.7.2, Ngen

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

**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2  (baseline), #1:** Time: 1121 ms
* **v22.2  (baseline), #2:** Time: 1096 ms
* **v22.2  (baseline), #3:** Time: 1087 ms
* **v23.1 , #1:** Time: 1107 ms
* **v23.1 , #2:** Time: 1114 ms
* **v23.1 , #3:** Time: 1107 ms
* **v23.1 LW Themes, #1:** Time: 954 ms
* **v23.1 LW Themes, #2:** Time: 950 ms
* **v23.1 LW Themes, #3:** Time: 959 ms

**Bars**
* **v22.2  (baseline), #1:** Time: 220 ms
* **v22.2  (baseline), #2:** Time: 222 ms
* **v22.2  (baseline), #3:** Time: 223 ms
* **v23.1 , #1:** Time: 216 ms
* **v23.1 , #2:** Time: 210 ms
* **v23.1 , #3:** Time: 223 ms
* **v23.1 LW Themes, #1:** Time: 177 ms
* **v23.1 LW Themes, #2:** Time: 172 ms
* **v23.1 LW Themes, #3:** Time: 171 ms

**Charts**
* **v22.2  (baseline), #1:** Time: 226 ms
* **v22.2  (baseline), #2:** Time: 219 ms
* **v22.2  (baseline), #3:** Time: 216 ms
* **v23.1 , #1:** Time: 218 ms
* **v23.1 , #2:** Time: 209 ms
* **v23.1 , #3:** Time: 220 ms
* **v23.1 LW Themes, #1:** Time: 221 ms
* **v23.1 LW Themes, #2:** Time: 215 ms
* **v23.1 LW Themes, #3:** Time: 222 ms

**Editors**
* **v22.2  (baseline), #1:** Time: 200 ms
* **v22.2  (baseline), #2:** Time: 196 ms
* **v22.2  (baseline), #3:** Time: 197 ms
* **v23.1 , #1:** Time: 198 ms
* **v23.1 , #2:** Time: 201 ms
* **v23.1 , #3:** Time: 193 ms
* **v23.1 LW Themes, #1:** Time: 193 ms
* **v23.1 LW Themes, #2:** Time: 192 ms
* **v23.1 LW Themes, #3:** Time: 195 ms

**Grid**
* **v22.2  (baseline), #1:** Time: 207 ms
* **v22.2  (baseline), #2:** Time: 204 ms
* **v22.2  (baseline), #3:** Time: 198 ms
* **v23.1 , #1:** Time: 202 ms
* **v23.1 , #2:** Time: 204 ms
* **v23.1 , #3:** Time: 338 ms
* **v23.1 LW Themes, #1:** Time: 184 ms
* **v23.1 LW Themes, #2:** Time: 179 ms
* **v23.1 LW Themes, #3:** Time: 186 ms

**Ribbon**
* **v22.2  (baseline), #1:** Time: 500 ms
* **v22.2  (baseline), #2:** Time: 511 ms
* **v22.2  (baseline), #3:** Time: 506 ms
* **v23.1 , #1:** Time: 503 ms
* **v23.1 , #2:** Time: 513 ms
* **v23.1 , #3:** Time: 505 ms
* **v23.1 LW Themes, #1:** Time: 405 ms
* **v23.1 LW Themes, #2:** Time: 403 ms
* **v23.1 LW Themes, #3:** Time: 400 ms

**RichEdit**
* **v22.2  (baseline), #1:** Time: 746 ms
* **v22.2  (baseline), #2:** Time: 730 ms
* **v22.2  (baseline), #3:** Time: 961 ms
* **v23.1 , #1:** Time: 832 ms
* **v23.1 , #2:** Time: 674 ms
* **v23.1 , #3:** Time: 767 ms
* **v23.1 LW Themes, #1:** Time: 661 ms
* **v23.1 LW Themes, #2:** Time: 698 ms
* **v23.1 LW Themes, #3:** Time: 705 ms

**Scheduler**
* **v22.2  (baseline), #1:** Time: 525 ms
* **v22.2  (baseline), #2:** Time: 748 ms
* **v22.2  (baseline), #3:** Time: 504 ms
* **v23.1 , #1:** Time: 507 ms
* **v23.1 , #2:** Time: 500 ms
* **v23.1 , #3:** Time: 511 ms
* **v23.1 LW Themes, #1:** Time: 483 ms
* **v23.1 LW Themes, #2:** Time: 499 ms
* **v23.1 LW Themes, #3:** Time: 476 ms

</details>



# HotStart, .NET 7, ReadyToRun

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

**Plain Results**
<details>
<summary>Results</summary>

**Main**
* **v22.2  (baseline), #1:** Time: 1082 ms
* **v22.2  (baseline), #2:** Time: 1049 ms
* **v22.2  (baseline), #3:** Time: 1048 ms
* **v23.1 , #1:** Time: 1047 ms
* **v23.1 , #2:** Time: 1048 ms
* **v23.1 , #3:** Time: 1043 ms
* **v23.1 LW Themes, #1:** Time: 957 ms
* **v23.1 LW Themes, #2:** Time: 1022 ms
* **v23.1 LW Themes, #3:** Time: 1014 ms

**Bars**
* **v22.2  (baseline), #1:** Time: 246 ms
* **v22.2  (baseline), #2:** Time: 253 ms
* **v22.2  (baseline), #3:** Time: 257 ms
* **v23.1 , #1:** Time: 266 ms
* **v23.1 , #2:** Time: 251 ms
* **v23.1 , #3:** Time: 251 ms
* **v23.1 LW Themes, #1:** Time: 206 ms
* **v23.1 LW Themes, #2:** Time: 202 ms
* **v23.1 LW Themes, #3:** Time: 206 ms

**Charts**
* **v22.2  (baseline), #1:** Time: 248 ms
* **v22.2  (baseline), #2:** Time: 242 ms
* **v22.2  (baseline), #3:** Time: 236 ms
* **v23.1 , #1:** Time: 246 ms
* **v23.1 , #2:** Time: 245 ms
* **v23.1 , #3:** Time: 232 ms
* **v23.1 LW Themes, #1:** Time: 247 ms
* **v23.1 LW Themes, #2:** Time: 268 ms
* **v23.1 LW Themes, #3:** Time: 249 ms

**Editors**
* **v22.2  (baseline), #1:** Time: 247 ms
* **v22.2  (baseline), #2:** Time: 235 ms
* **v22.2  (baseline), #3:** Time: 229 ms
* **v23.1 , #1:** Time: 238 ms
* **v23.1 , #2:** Time: 229 ms
* **v23.1 , #3:** Time: 250 ms
* **v23.1 LW Themes, #1:** Time: 232 ms
* **v23.1 LW Themes, #2:** Time: 227 ms
* **v23.1 LW Themes, #3:** Time: 234 ms

**Grid**
* **v22.2  (baseline), #1:** Time: 237 ms
* **v22.2  (baseline), #2:** Time: 241 ms
* **v22.2  (baseline), #3:** Time: 233 ms
* **v23.1 , #1:** Time: 251 ms
* **v23.1 , #2:** Time: 258 ms
* **v23.1 , #3:** Time: 236 ms
* **v23.1 LW Themes, #1:** Time: 223 ms
* **v23.1 LW Themes, #2:** Time: 224 ms
* **v23.1 LW Themes, #3:** Time: 225 ms

**Ribbon**
* **v22.2  (baseline), #1:** Time: 556 ms
* **v22.2  (baseline), #2:** Time: 566 ms
* **v22.2  (baseline), #3:** Time: 559 ms
* **v23.1 , #1:** Time: 516 ms
* **v23.1 , #2:** Time: 518 ms
* **v23.1 , #3:** Time: 553 ms
* **v23.1 LW Themes, #1:** Time: 442 ms
* **v23.1 LW Themes, #2:** Time: 456 ms
* **v23.1 LW Themes, #3:** Time: 445 ms

**RichEdit**
* **v22.2  (baseline), #1:** Time: 604 ms
* **v22.2  (baseline), #2:** Time: 850 ms
* **v22.2  (baseline), #3:** Time: 763 ms
* **v23.1 , #1:** Time: 768 ms
* **v23.1 , #2:** Time: 761 ms
* **v23.1 , #3:** Time: 722 ms
* **v23.1 LW Themes, #1:** Time: 708 ms
* **v23.1 LW Themes, #2:** Time: 683 ms
* **v23.1 LW Themes, #3:** Time: 724 ms

**Scheduler**
* **v22.2  (baseline), #1:** Time: 532 ms
* **v22.2  (baseline), #2:** Time: 516 ms
* **v22.2  (baseline), #3:** Time: 507 ms
* **v23.1 , #1:** Time: 521 ms
* **v23.1 , #2:** Time: 546 ms
* **v23.1 , #3:** Time: 471 ms
* **v23.1 LW Themes, #1:** Time: 570 ms
* **v23.1 LW Themes, #2:** Time: 446 ms
* **v23.1 LW Themes, #3:** Time: 438 ms

</details>



Test execution complete. Duration: 01:11:58
