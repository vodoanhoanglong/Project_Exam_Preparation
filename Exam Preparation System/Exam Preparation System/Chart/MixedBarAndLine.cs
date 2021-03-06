using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exam_Preparation_System.Chart
{
    class MixedBarAndLine
    {
        public static List<int> data;
        public static List<double> percent;
        public static void loadChart(Guna.Charts.WinForms.GunaChart chart)
        {
            List<string> dayOfWeek = new List<string>();
            int index = 6;
            while (index >= 0)
                dayOfWeek.Add(DateTime.Today.AddDays(-index--).DayOfWeek.ToString());

            //Chart configuration 
            chart.Misc.BarCornerRadius = 10;
            chart.YAxes.GridLines.Display = false;

            //Create new barDataset
            var barDataset = new Guna.Charts.WinForms.GunaBarDataset();
            barDataset.Label = "Tỷ lệ đúng";

            /* Real Data from Database*/
            for (int i = 0; i < dayOfWeek.Count; i++)
                barDataset.DataPoints.Add(dayOfWeek[i], percent[i]);

            /* Phà kè Data*/
            //var r = new Random();
            //for (int i = 0; i < dayOfWeek.Count; i++)
            //{
            //    //random number
            //    int num = r.Next(5, 200);

            //    barDataset.DataPoints.Add(dayOfWeek[i], num);
            //}


            //Create new areaDataset
            var lineDataset = new Guna.Charts.WinForms.GunaSplineDataset();
            lineDataset.FillColor = Color.FromArgb(84, 193, 254);
            lineDataset.Label = "Lượt làm bài ";
            lineDataset.BorderColor = lineDataset.FillColor;
            lineDataset.PointRadius = 5;
            lineDataset.PointStyle = PointStyle.Circle;

            /* Real Data from Database*/
            for (int i = 0; i < dayOfWeek.Count; i++)
                lineDataset.DataPoints.Add(dayOfWeek[i], data[i]);


            /* Phà kè Data*/
            //for (int i = 0; i < dayOfWeek.Count; i++)
            //{
            //    //random number
            //    int num = r.Next(10, 100);

            //    lineDataset.DataPoints.Add(dayOfWeek[i], num);
            //}


            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(lineDataset);
            chart.Datasets.Add(barDataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
