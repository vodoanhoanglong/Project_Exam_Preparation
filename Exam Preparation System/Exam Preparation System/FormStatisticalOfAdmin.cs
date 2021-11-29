using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Exam_Preparation_System
{
    public partial class FormStatisticalOfAdmin : Form
    {
        public FormStatisticalOfAdmin()
        {
            InitializeComponent();
        }

        private void FormStatisticalOfAdmin_Load(object sender, EventArgs e)
        {
            
            SeriesCollection cartesianChartData = new SeriesCollection
                {
                    new LineSeries
                    {
                        Values = new ChartValues<double> {3, 5, 19 , 7, 6 , 7 , 9},
                        StrokeThickness=4,
                        StrokeDashArray = new System.Windows.Media.DoubleCollection(50),
                        LineSmoothness = 2,
                        PointGeometrySize=10,
                    },
                };
            cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = new [] {"Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun"},
            });

            cartesianChart.Series = cartesianChartData;
            cartesianChart.LegendLocation = LegendLocation.Top;
        }
    }
}
