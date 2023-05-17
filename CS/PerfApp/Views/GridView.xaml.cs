using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace PerfApp.GridModule {
    public partial class GridView : UserControl {
        public GridView() {
            DataContext = new GridData();
            InitializeComponent();
        }
    }
    public class GridItem {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Group { get; set; }
        public DateTime Date { get; set; }
        public bool IsChecked { get; set; }
    }
    public class GridData : BindableBase {
        public ObservableCollection<GridItem> Items { get; }
        public GridItem CurrentItem { get => GetValue<GridItem>(); set => SetValue(value); }
        public GridData() {
            var res = new List<GridItem>();
            for (int i = 0; i < 100; i++) {
                var item = new GridItem() {
                    Id = i,
                    Value = $"Value {i}",
                    Group = "Group " + ('A' + i % 10).ToString(),
                    Date = DateTime.Now,
                    IsChecked = i % 2 == 0,
                };
                res.Add(item);
            }
            Items = new ObservableCollection<GridItem>(res);
            CurrentItem = Items[0];
        }
    }
}
