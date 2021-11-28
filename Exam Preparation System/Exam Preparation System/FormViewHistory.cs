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
        public FormViewHistory()
        {
            InitializeComponent();
        }

        private void FormViewHistory_Load(object sender, EventArgs e)
        {
            dgvHistory.AutoGenerateColumns = false;

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
            loadData();
        }

        private void loadData()
        {
            int subID = (int)cmbSubject.SelectedValue;
            var query = from er in context.EXAMRESULTS
                        where er.UserID == FormLogin.info.UserID
                        select new
                        {   er.EXAMQUESTION.ExamQuestionID,
                            er.EXAMQUESTION.Quantity,
                            er.EXAMQUESTION.ExecutionTime,
                            er.TimeComplete,
                            er.EXAMQUESTION.SUBJECT.SubName,
                            er.QuantityCorrect,
                            er.Points,
                            er.ExamDate,
                            filterBySub = er.EXAMQUESTION.SubjectID
                        };
            dgvHistory.DataSource = subID == -1 ? query.ToList() : query.Where(x => x.filterBySub == subID).ToList();
        }

        private void loadDataByID()
        {
            int examID = Convert.ToInt32(txtExamID.Text);
            var query = from er in context.EXAMRESULTS
                        where er.ExamQuestionID == examID
                        select new
                        {
                            er.EXAMQUESTION.ExamQuestionID,
                            er.EXAMQUESTION.Quantity,
                            er.EXAMQUESTION.ExecutionTime,
                            er.TimeComplete,
                            er.EXAMQUESTION.SUBJECT.SubName,
                            er.QuantityCorrect,
                            er.Points,
                            er.ExamDate,
                        };
            dgvHistory.DataSource = query.ToList();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtExamID.Text = "";
            btnReset.Visible = false;
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtExamID.Text == "")
                MessageBox.Show("Vui lòng nhập mã đề");
            else
            {
                btnReset.Visible = true;
                loadDataByID();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbSubject.SelectedValue = -1;
            txtExamID.Text = "";
            loadData();
            btnReset.Visible = false;
        }

        private void txtExamID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
