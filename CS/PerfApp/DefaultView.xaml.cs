using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;

namespace PerfApp {
    public partial class DefaultView : UserControl {
        public DefaultView() {
            InitializeComponent();
        }
        async void Button_Click(object sender, RoutedEventArgs e) {
            Button b = (Button)sender;
            var v = (TestView)Enum.Parse(typeof(TestView), b.Content.ToString());
            Stopwatch s = Stopwatch.StartNew();
            var w = App.CreateWindow(v);
            w.Show();
            await Dispatcher.DoEvents();
            s.Stop();
            w.Title = s.ElapsedMilliseconds.ToString();
        }
        async void Button_Click_1(object sender, RoutedEventArgs e) {
            Button b = (Button)sender;
            Stopwatch s = Stopwatch.StartNew();
            App.PreloadLegacyTheme();
            await Dispatcher.DoEvents();
            s.Stop();
            b.Content = $"Preload: {s.ElapsedMilliseconds}";
        }
        async void Button_Click_2(object sender, RoutedEventArgs e) {
            Theme.RegisterPredefinedPaletteThemes();

            Button b = (Button)sender;
            var theme = b.Content.ToString();
            var i = theme.IndexOf(":");
            if(i > 0) theme = theme.Substring(0, i);

            Stopwatch s = Stopwatch.StartNew();
            ApplicationThemeHelper.ApplicationThemeName = theme;
            await Dispatcher.DoEvents();
            s.Stop();
            b.Content = $"{theme}: {s.ElapsedMilliseconds}";
        }
        void Button_Click_4(object sender, RoutedEventArgs e) {
            //typeof(CommonThemeHelper)
            //    .GetMethod("InitializeLightweightThemeManagerForTests", BindingFlags.Static | BindingFlags.NonPublic)
            //    .Invoke(null, null);
        }
        void Button_Click_5(object sender, RoutedEventArgs e) {
            //typeof(CommonThemeHelper)
            //    .GetMethod("InitializeLegacyThemeManagerForTests", BindingFlags.Static | BindingFlags.NonPublic)
            //    .Invoke(null, null);
        }
    }
}
