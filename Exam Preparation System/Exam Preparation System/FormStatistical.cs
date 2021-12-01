using Chart;
using Config;
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

            loadData();

        }

        private void loadData()
        {
            int examID = Convert.ToInt32(cmbExamID.SelectedValue);
            int total, day = 5;
            List<int> arr = new List<int>();
            DateTime endDate = DateTime.Now.Date;
            DateTime startDate = DateTime.Today.AddDays(-6).Date;
            var query = context.EXAMRESULTS
                .Where(x => DbFunctions.TruncateTime(x.ExamDate) >= startDate && DbFunctions.TruncateTime(x.ExamDate) <= endDate);
            /*.GroupBy(
             p => DbFunctions.TruncateTime(p.ExamDate),
             p => p.ExamResultID,
            (key, g) => new { ExamDate = key, ExamResultID = g.ToList() });*/
            if (examID != -1)
                query = query.Where(x => x.ExamQuestionID == examID);
            while (day >= 0)
            {
                total = query.Where(x => DbFunctions.TruncateTime(x.ExamDate) == startDate).ToList().Count;
                arr.Add(total);
                startDate = DateTime.Today.AddDays(-day--).Date;
            };

            total = query.Where(x => DbFunctions.TruncateTime(x.ExamDate) == endDate).ToList().Count;
            arr.Add(total);

            chart.Datasets.Clear();
            chart.ApplyConfig(ConfigChart.Config(), System.Drawing.Color.FromArgb(239, 242, 249));
            SplineArea.data = arr;
            SplineArea.loadChart(chart);
        }

        private void cmbExamID_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();           
        }
    }
}
