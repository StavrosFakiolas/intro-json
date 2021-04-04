using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace IntroductionToJsonFull.App
{
    public partial class Display : Form
    {
        public Display(SortedDictionary<int,int> data)
        {
            InitializeComponent();
            var chartValues = new ChartValues<ObservablePoint>();
            foreach (var item in data)
                chartValues.Add(new ObservablePoint(item.Key,item.Value));
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    /*Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(3,10), //first point of the first line
                        new ObservablePoint(4,7),  //second point
                        new ObservablePoint(5,3),  //etc.
                        new ObservablePoint(7,6),
                    },*/

                    Values = chartValues,
                    PointGeometrySize = 3
                }
            };
        }
    }
}
