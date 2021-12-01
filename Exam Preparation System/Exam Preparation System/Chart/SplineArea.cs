using System;
using System.Collections.Generic;
using System.Drawing;
using Guna.Charts.WinForms;

namespace Chart
{
    class SplineArea
    {
        public static List<int> data;

        public static void loadChart(Guna.Charts.WinForms.GunaChart chart)
        {
            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            string[] dayOfWeek = { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun" };

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 3;
            dataset.PointStyle = PointStyle.Circle;

            for (int i = 0; i < dayOfWeek.Length; i++)
                dataset.DataPoints.Add(dayOfWeek[i], data[i]);

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
