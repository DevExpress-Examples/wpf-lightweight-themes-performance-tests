﻿using DevExpress.Xpf.Core;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.LayoutControl;
using DevExpress.Xpf.PropertyGrid;
using DevExpress.Xpf.Ribbon;
using PerfApp.BarsModule;
using PerfApp.ChartsModule;
using PerfApp.EditorsModule;
using PerfApp.GridModule;
using PerfApp.MainModule;
using PerfApp.RibbonModule;
using PerfApp.RichEditModule;
using PerfApp.SchedulerModule;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace PerfApp {
    public enum TestView { Editors, Grid, Ribbon, Bars, RichEdit, Scheduler, Charts, Main, Default }
    public enum TestType { ColdStart, HotStart }
    public enum TestMode { LightweightThemes, LegacyThemes, LegacyThemesAfterPreload }

    public partial class App : Application {
        public static bool IsTestRun { get; private set; } = false;
        public static TestView TestView { get; private set; } = TestView.Main;
        public static TestType TestType { get; private set; } = TestType.ColdStart;
        public static TestMode TestMode { get; private set; } = TestMode.LightweightThemes;
        public static bool AutoClose => IsTestRun;
        public static string ThemeName = "Office2019Colorful";
        public static bool MemoryMonitoring => IsTestRun && TestType == TestType.ColdStart;
        static int HotStartRunCount => 8;

        static int ElapsedMs;
        static int PreloadMs;
        static int TotalMemoryKB;
        static Assembly[] PreloadAssemblies;

        protected override void OnStartup(StartupEventArgs e) {
            IsTestRun = e.Args.Count() > 0;
            if(IsTestRun) {
                TestView = (TestView)Enum.Parse(typeof(TestView), e.Args[0]);
                TestType = (TestType)Enum.Parse(typeof(TestType), e.Args[1]);
                TestMode = (TestMode)Enum.Parse(typeof(TestMode), e.Args[2]);
            }

#if v22_2
            if(TestMode == TestMode.LightweightThemes)
                TestMode = TestMode.LegacyThemes;
#else
            CompatibilitySettings.UseLightweightThemes = TestMode == TestMode.LightweightThemes;
            if (TestMode == TestMode.LegacyThemesAfterPreload)
                CompatibilitySettings.AllowThemePreload = true;
#endif

            ApplicationThemeHelper.ApplicationThemeName = ThemeName;
            base.OnStartup(e);
            if (TestType == TestType.ColdStart)
                StartColdStartTest();
            else StartHotStartTest();
        }
        protected override void OnExit(ExitEventArgs e) {
            Console.WriteLine($"ElapsedMilliseconds: {ElapsedMs}");
            if(PreloadMs > 0)
                Console.WriteLine($"PreloadElapsedMilliseconds: {PreloadMs}");
            if (MemoryMonitoring)
                Console.WriteLine($"TotalMemoryKB: {TotalMemoryKB}");
            base.OnExit(e);
        }
        async void StartColdStartTest() {
            if(TestMode == TestMode.LegacyThemesAfterPreload)
                PreloadLegacyTheme();

            var s = Stopwatch.StartNew();
            MainWindow = CreateWindow(TestView);
            MainWindow.Show();
            await Dispatcher.DoEvents();
            s.Stop();
            ElapsedMs = (int)s.ElapsedMilliseconds;
            MainWindow.Title = TestMode == TestMode.LegacyThemesAfterPreload 
                ? $"ColdStart: {ElapsedMs}, Preload: {PreloadMs}"
                : $"ColdStart: {ElapsedMs}";

            if (MemoryMonitoring) {
                await Dispatcher.DoEvents();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                await Dispatcher.DoEvents();
                GC.GetTotalMemory(true);
                await Dispatcher.DoEvents();
                TotalMemoryKB = (int)(GC.GetTotalMemory(true) / 1024);
            }
            
            if (AutoClose) {
                ShutdownMode = ShutdownMode.OnExplicitShutdown;
                MainWindow.Close();
                Shutdown();
            }
        }
        async void StartHotStartTest() {
            ShutdownMode = ShutdownMode.OnExplicitShutdown;
            var w = CreateWindow(TestView);
            w.Show();
            w.Close();
            await Dispatcher.DoEvents();

            List<int> elapsed = new List<int>();
            for (int i = 0; i < HotStartRunCount; i++) {
                await Dispatcher.DoEvents();
                GC.GetTotalMemory(true);

                var s = Stopwatch.StartNew();
                w = CreateWindow(TestView);
                w.Show();
                await Dispatcher.DoEvents();
                s.Stop();
                w.Close();
                elapsed.Add((int)s.ElapsedMilliseconds);
            }

            ElapsedMs = elapsed.Sum() / elapsed.Count;
            if (AutoClose) {
                Shutdown();
                return;
            }

            MainWindow = CreateWindow(TestView);
            MainWindow.Show();
            MainWindow.Title = $"HotStart: {ElapsedMs}";
            ShutdownMode = ShutdownMode.OnMainWindowClose;
        }

        internal static void PreloadLegacyTheme() {
            if (TestMode == TestMode.LightweightThemes) return;
            var s = Stopwatch.StartNew();
            PreloadAssemblies = new[] {
                typeof(GridControl).Assembly,
                typeof(RibbonControl).Assembly,
                typeof(PropertyGridControl).Assembly,
                typeof(LayoutControl).Assembly,
                typeof(ThemedWindow).Assembly,
                typeof(DockLayoutManager).Assembly,
            };
            ThemeManager.PreloadThemeResource(ThemeName);
            s.Stop();
            PreloadMs = (int)s.ElapsedMilliseconds;
        }
        internal static Window CreateWindow(TestView testView) {
            var res = new ThemedWindow() {
                Title = "MainWindow",
                Height = 800,
                Width = 1200,
            };
            switch(testView) {
                case TestView.Editors: res.Content = new EditorsView(); break;
                case TestView.Grid: res.Content = new GridView(); break;
                case TestView.Ribbon: res.Content = new RibbonView(); break;
                case TestView.Bars: res.Content = new BarsView(); break;
                case TestView.RichEdit: res.Content = new RichEditView(); break;
                case TestView.Scheduler: res.Content = new SchedulerView(); break;
                case TestView.Charts: res.Content = new ChartsView(); break;
                case TestView.Main: res.Content = new MainView(); break;
                case TestView.Default: res.Content = new DefaultView(); break;
                default: throw new Exception();
            }
            return res;
        }
    }
    public static class DispatcherExtensions {
        public static async Task DoEvents(this Dispatcher dispatcher) {
            await dispatcher.InvokeAsync(() => { }, DispatcherPriority.ApplicationIdle);
        }
    }
}
