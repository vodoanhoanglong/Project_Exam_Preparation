using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
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
            chart.YAxes.GridLines.Display = false;

            //Create new barDataset
            var barDataset = new Guna.Charts.WinForms.GunaBarDataset();
            barDataset.Label = "Tỷ lệ đúng";

            for (int i = 0; i < dayOfWeek.Count; i++)
                barDataset.DataPoints.Add(dayOfWeek[i], percent[i]);

            //Create new areaDataset
            var lineDataset = new Guna.Charts.WinForms.GunaLineDataset();
            lineDataset.FillColor = System.Drawing.Color.Red;
            lineDataset.Label = "Số thí sinh tham gia";
            lineDataset.BorderColor = lineDataset.FillColor;
            lineDataset.PointRadius = 5;
            lineDataset.PointStyle = PointStyle.Circle;


            for (int i = 0; i < dayOfWeek.Count; i++)
                lineDataset.DataPoints.Add(dayOfWeek[i], data[i]);

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(lineDataset);
            chart.Datasets.Add(barDataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
