using Exam_Preparation_System.Models;
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

namespace Exam_Preparation_System
{
    public partial class FormStatisticalOfUser : Form
    {
        private int totalQuestion, totalCorrect, totalWrong;
        private ContextDB context = Program.context;
        public FormStatisticalOfUser()
        {
            InitializeComponent();
        }

        private void FormStatistical_Load(object sender, EventArgs e)
        {
                loadData();
                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
                SeriesCollection piechartData = new SeriesCollection
                {
                    new PieSeries
                    {
                        Title = "Tổng câu hỏi đã làm",
                        Values = new ChartValues<double> {totalQuestion},
                        DataLabels = true,
                        LabelPoint = labelPoint,
                    },
                    new PieSeries
                    {
                        Title = "Tổng câu đúng",
                        Values = new ChartValues<double> {totalCorrect},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Tổng câu sai",
                        Values = new ChartValues<double> {totalWrong},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                };

                pieChart.Series = piechartData;
                pieChart.LegendLocation = LegendLocation.Bottom;
        }
        private void loadData()
        {
            var query = context.EXAMRESULTS.Where(x => x.UserID == FormLogin.info.UserID);
            totalQuestion = query.Select(x => x.EXAMQUESTION.Quantity).AsEnumerable().Sum();
            totalCorrect = query.Select(x => x.QuantityCorrect).AsEnumerable().Sum();
            totalWrong = totalQuestion - totalCorrect;
        }
    }
}
