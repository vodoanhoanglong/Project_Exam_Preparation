using System;
using System.Drawing;
using System.Windows;
using Guna.Charts.WinForms;

namespace Chart
{
    class Radar
    {
        public static int[] data;
        public static void loadChart(Guna.Charts.WinForms.GunaChart chart)
        {
            string[] labels = { "Tổng câu hỏi đã làm", "Tổng câu đúng", "Tổng câu sai" };

            //Chart configuration  
            chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaRadarDataset();
            dataset.Label = "Số câu hỏi";
            dataset.BorderWidth = 2;
            dataset.PointBorderWidth = 1;

            dataset.PointStyle = PointStyle.Circle;
           

            for (int i = 0; i < labels.Length; i++)
                dataset.DataPoints.Add(labels[i], data[i]);

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }

    }
}
