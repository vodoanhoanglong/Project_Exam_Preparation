using Chart;
using Config;
using Exam_Preparation_System.Models;
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
    public partial class FormViewHistory : Form
    {
        ContextDB context = Program.context;
        private int totalQuestion, totalCorrect, totalWrong;
        private string currKey = "";
        public FormViewHistory()
        {
            InitializeComponent();
        }

        private void FormViewHistory_Load(object sender, EventArgs e)
        {
            dgvHistory.AutoGenerateColumns = false;
            dgvHistory.Columns["ExamDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            DataTable table = new DataTable();
            table.Columns.Add("SubjectID", typeof(int));
            table.Columns.Add("SubName", typeof(string));

            context.SUBJECTS.ToList().ForEach(x =>
            {
                var rowDT = table.NewRow();
                rowDT["SubjectID"] = x.SubjectID;
                rowDT["SubName"] = x.SubName;
                table.Rows.Add(rowDT);
            });
            // create new row for "Value default"
            DataRow row = table.NewRow();
            row["SubjectID"] = -1;
            row["SubName"] = "Tất cả các môn";
            // insert the row at the top of the table
            table.Rows.InsertAt(row, 0);
            // do the databinding
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";
            cmbSubject.DataSource = table;

            loadChart();
        }

        private void loadData(int subID = -1)
        {
            string userID = FormLogin.info.UserID;
            var query = !currKey.Equals("")
                ? context.EXAMRESULTS
                .AsEnumerable()
                .Where(x => x.UserID == userID 
                && x.ExamQuestionID == Convert.ToInt32(currKey))
                : subID == -1 ?
                context.EXAMRESULTS.Where(x => x.UserID == userID)
                : context.EXAMRESULTS.Where(x => x.UserID == userID
                && x.EXAMQUESTION.SubjectID == subID);

            dgvHistory.DataSource = query.OrderByDescending(x => x.ExamDate)
                        .Select(er => new
                        {
                            er.EXAMQUESTION.ExamQuestionID,
                            er.EXAMQUESTION.Quantity,
                            er.EXAMQUESTION.ExecutionTime,
                            er.TimeComplete,
                            er.EXAMQUESTION.SUBJECT.SubName,
                            er.QuantityCorrect,
                            er.Points,
                            er.ExamDate,
                        }).ToList();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currKey.Equals(""))
                txtExamID.Text = "";
            loadData((int)cmbSubject.SelectedValue);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtExamID.Text == "")
                MessageBox.Show("Vui lòng nhập mã đề");
            else
            {
                currKey = txtExamID.Text;
                if (cmbSubject.SelectedIndex != 0)
                    cmbSubject.SelectedIndex = 0;
                else loadData();
                currKey = "";
            }
        }


        private void txtExamID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void loadChart()
        {
            int[] arr = new int[3];
            var query = context.EXAMRESULTS.Where(x => x.UserID == FormLogin.info.UserID);
            totalQuestion = query.Select(x => x.EXAMQUESTION.Quantity).AsEnumerable().Sum();
            totalCorrect = query.Select(x => x.QuantityCorrect).AsEnumerable().Sum();
            totalWrong = totalQuestion - totalCorrect;

            arr[0] = totalQuestion;
            arr[1] = totalCorrect;
            arr[2] = totalWrong;

            chart.Datasets.Clear();
            chart.ApplyConfig(ConfigChart.Config(), Color.FromArgb(239, 242, 249));
            Radar.data = arr;
            Radar.loadChart(chart);
        }
    }
}
