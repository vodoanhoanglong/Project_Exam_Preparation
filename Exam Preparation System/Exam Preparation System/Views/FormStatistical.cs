using Chart;
using Config;
using Exam_Preparation_System.Chart;
using Exam_Preparation_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Exam_Preparation_System
{
    public partial class FormStatistical : Form
    {
        ContextDB context = Program.context;
        public FormStatistical()
        {
            InitializeComponent();
        }

        private void FormStatisticalOfAdmin_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ExamQuestionID", typeof(int));
            table.Columns.Add("ExamID", typeof(string));

            context.EXAMQUESTIONS.ToList().ForEach(x =>
            {
                var rowDT = table.NewRow();
                rowDT["ExamQuestionID"] = x.ExamQuestionID;
                rowDT["ExamID"] = x.ExamQuestionID;
                table.Rows.Add(rowDT);
            });
            // create new row for "Value default"
            DataRow row = table.NewRow();
            row["ExamQuestionID"] = -1;
            row["ExamID"] = "Tất cả các mã đề";
            // insert the row at the top of the table
            table.Rows.InsertAt(row, 0);
            // do the databinding
            cmbExamID.ValueMember = "ExamQuestionID";
            cmbExamID.DisplayMember = "ExamID";
            cmbExamID.DataSource = table;

        }

        private void loadData()
        {
            int examID = Convert.ToInt32(cmbExamID.SelectedValue);
            int total, day = 6;
            double correctPercent, totalPoint;
            List<int> arr = new List<int>();
            List<double> arrPercent = new List<double>();
            DateTime startDate = DateTime.Today.AddDays(-day).Date;
            var query = examID != -1 ?
                context.EXAMRESULTS.Where(x => x.ExamQuestionID == examID)
                : context.EXAMRESULTS;

            while (day >= 0)
            {
                startDate = DateTime.Today.AddDays(-day--).Date;
                query = query.Where(x => DbFunctions.TruncateTime(x.ExamDate) == startDate);
                total = query.ToList().Count;

                totalPoint = query
                    .AsEnumerable()
                    .Sum(x => checkNaN(x.Points));

                correctPercent = (total * totalPoint / Math.Pow(total, 2) * 10);
                arrPercent.Add(Math.Round(checkNaN(correctPercent), 2));
                arr.Add(total);
            };

            chart.Datasets.Clear();
            chart.ApplyConfig(ConfigChart.Config(), System.Drawing.Color.FromArgb(239, 242, 249));
            MixedBarAndLine.data = arr;
            MixedBarAndLine.percent = arrPercent;
            MixedBarAndLine.loadChart(chart);
        }

        private double checkNaN(double value)
        {
            return double.IsNaN(value) ? 0 : value;
        }

        private void cmbExamID_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();           
        }
    }
}
