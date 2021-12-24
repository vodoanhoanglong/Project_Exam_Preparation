﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Guna.Charts.WinForms;

namespace Config
{
    class ConfigChart
    {
        public static ChartConfig Config()
        {
            ChartConfig config = new ChartConfig();
            Color gridColor = Color.FromArgb(49, 52, 82);
            Color foreColor = Color.FromArgb(177, 182, 205);
            List<Color> colors = new List<Color>() 
            { 
                Color.FromArgb(150, 140, 81, 165),  
            };
            List<Color> colorsPoint = new List<Color>() { Color.FromArgb(254, 65, 111) };

            var chartFont = new Guna.Charts.WinForms.ChartFont()
            {
                FontName = "Segoe UI",
                Size = 12,
                Style = Guna.Charts.WinForms.ChartFontStyle.Bold
            };

            config.Title.ForeColor = foreColor;

            config.Legend.LabelFont = chartFont;
            config.Legend.LabelForeColor = foreColor;

            config.XAxes.GridLines.Color = gridColor;
            config.XAxes.GridLines.ZeroLineColor = gridColor;
            config.XAxes.Ticks.Font = chartFont;
            config.XAxes.Ticks.ForeColor = foreColor;

            config.YAxes.GridLines.Color = gridColor;
            config.YAxes.GridLines.ZeroLineColor = gridColor;
            config.YAxes.Ticks.Font = chartFont;
            config.YAxes.Ticks.ForeColor = foreColor;

            config.ZAxes.GridLines.Color = gridColor;
            config.ZAxes.GridLines.ZeroLineColor = gridColor;
            config.ZAxes.Ticks.Font = chartFont;
            config.ZAxes.Ticks.ForeColor = foreColor;
            config.ZAxes.PointLabels.Font = chartFont;
            config.ZAxes.PointLabels.ForeColor = foreColor;

            config.PaletteCustomColors.FillColors.AddRange(colors);
            config.PaletteCustomColors.BorderColors.AddRange(colors);
            config.PaletteCustomColors.PointFillColors.AddRange(colorsPoint);
            config.PaletteCustomColors.PointBorderColors.AddRange(colorsPoint);

            return config;
        }

    }
}
