using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace PerfApp.ChartsModule {
    public partial class ChartsView : UserControl {
        public ChartsView() {
            DataContext = new ChartViewModel();
            InitializeComponent();
        }
    }
    public class ChartViewModel {
        public List<DataPoint> Data { get; private set; }
        public List<DataPoint> Data2 { get; private set; }
        public List<DataSeries3> Data3 { get; private set; }
        public ChartViewModel() {
            Data = new List<DataPoint> {
                        new DataPoint ("Bikes", 142345),
                        new DataPoint ("Accessories", 266344),
                        new DataPoint ("Components", 631359),
                        new DataPoint ("Clothing", 120007)
            };
            Data2 = new List<DataPoint> {
                        new DataPoint ("Visited a Web Site", 9152),
                        new DataPoint ("Downloaded a Trial", 6870),
                        new DataPoint ("Contacted to Support", 5121),
                        new DataPoint ("Subscribed", 2224),
                        new DataPoint ("Renewed", 1670)
            };
            Data3 = new List<DataSeries3> {
                new DataSeries3{
                    Name = "DevAV North",
                    Values = new List<DataPoint3> {
                        new DataPoint3 (new DateTime(2013,12,31), 362.5),
                        new DataPoint3 (new DateTime(2014,12,31), 348.4),
                        new DataPoint3 (new DateTime(2015,12,31), 279.0),
                        new DataPoint3 (new DateTime(2016,12,31), 230.9),
                        new DataPoint3 (new DateTime(2017,12,31), 203.5),
                        new DataPoint3 (new DateTime(2018,12,31), 197.1)
                    }
                },
                new DataSeries3{
                    Name = "DevAV South",
                    Values = new List<DataPoint3> {
                        new DataPoint3 (new DateTime(2013,12,31), 277.0),
                        new DataPoint3 (new DateTime(2014,12,31), 328.5),
                        new DataPoint3 (new DateTime(2015,12,31), 297.0),
                        new DataPoint3 (new DateTime(2016,12,31), 255.3),
                        new DataPoint3 (new DateTime(2017,12,31), 173.5),
                        new DataPoint3 (new DateTime(2018,12,31), 131.8)
                    }
                }
            };
        }
        public class DataPoint {
            public string Argument { get; private set; }
            public double Value { get; private set; }
            public DataPoint(string argument, double value) {
                Argument = argument;
                Value = value;
            }
        }

        public class DataSeries3 {
            public string Name { get; set; }
            public List<DataPoint3> Values { get; set; }
        }
        public class DataPoint3 {
            public DateTime Argument { get; set; }
            public double Value { get; set; }
            public DataPoint3(DateTime argument, double value) {
                Argument = argument;
                Value = value;
            }
        }
    }
}
