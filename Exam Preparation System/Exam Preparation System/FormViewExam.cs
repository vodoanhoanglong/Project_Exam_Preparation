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
    public partial class FormViewExam : Form
    {
        private ContextDB context = Program.context;
        public FormViewExam()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            int subID = (int)cmbSubject.SelectedValue;
            var query = from lq in context.LISTQUESTIONs
                        group lq by lq.ExamQuestionID into lqs
                        join eq in context.EXAMQUESTIONS
                        on lqs.FirstOrDefault().ExamQuestionID equals eq.ExamQuestionID
                        select new
                        { eq.ExamQuestionID, eq.Quantity, eq.ExecutionTime, eq.SubjectID, eq.SUBJECT.SubName, CreateDate = lqs.FirstOrDefault().CreateDate };
            dgvListContests.DataSource = subID == -1 ? query.ToList() : query.Where(x => x.SubjectID == subID).ToList();
        }

        private void loadDataByID()
        {
            int examID = Convert.ToInt32(txtExamID.Text);
            var query = from lq in context.LISTQUESTIONs
                        group lq by lq.ExamQuestionID into lqs
                        join eq in context.EXAMQUESTIONS
                        on lqs.FirstOrDefault().ExamQuestionID equals eq.ExamQuestionID
                        where lqs.FirstOrDefault().ExamQuestionID == examID
                        select new
                        { eq.ExamQuestionID, eq.Quantity, eq.ExecutionTime, eq.SubjectID, eq.SUBJECT.SubName, CreateDate = lqs.FirstOrDefault().CreateDate };
            dgvListContests.DataSource = query.ToList();
        }

        private void FormViewExam_Load(object sender, EventArgs e)
        {
            dgvListContests.AutoGenerateColumns = false;

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

        private void txtExamID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbSubject.SelectedValue = -1;
            txtExamID.Text = "";
            loadData();
            btnReset.Visible = false;
        }

        private void dgvListContests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int examID = Convert.ToInt32(dgvListContests.Rows[e.RowIndex].Cells["ExamID"].Value);
                /*int subjectID = Convert.ToInt32(dgvListContests.Rows[e.RowIndex].Cells["SubjectID"].Value);*/
                /*FormMainMenu.instance.openChildForm(new FormExamPreparation());*/
                FormExamPreparation form = new FormExamPreparation(examID);
                form.Show();
            }
        }
    }
}
