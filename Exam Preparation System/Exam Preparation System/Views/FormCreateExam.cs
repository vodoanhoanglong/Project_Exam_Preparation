using Exam_Preparation_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Preparation_System
{
    public partial class FormCreateExam : Form
    {
        ContextDB context = Program.context;
        private string currKey = "";
        private List<SUBJECT> subject = null;
        public static FormCreateExam instance = null;
        public FormCreateExam()
        {
            InitializeComponent();
            instance = this;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                         (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        public void loadData(int subID = -1)
        {
            MessageBox.Show(currKey);
            var query = !currKey.Equals("")
                ? context.EXAMQUESTIONS
                .AsEnumerable()
                .Where(x => x.ExamQuestionID == Convert.ToInt32(currKey))
                : subID == -1 ? 
                context.EXAMQUESTIONS
                : context.EXAMQUESTIONS.Where(x => x.SubjectID == subID);

            dgvListContests.DataSource = query
            .Select(x => new
            {
                x.ExamQuestionID,
                x.Quantity,
                x.ExecutionTime,
                x.SubjectID,
                x.SUBJECT.SubName,
                x.LISTQUESTIONs
                        .FirstOrDefault(ele => ele.ExamQuestionID == x.ExamQuestionID)
                        .CreateDate
            })
            .OrderByDescending(x => x.ExamQuestionID)
            .ToList();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currKey.Equals(""))
                txtSearch.Text = "";
            loadData((int)cmbFilter.SelectedValue);
        }

        private void FormCreateExam_Load(object sender, EventArgs e)
        {
            dgvQuestion.AutoGenerateColumns = false;

            subject = context.SUBJECTS.ToList();
            cmbSubject.DataSource = subject;
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";

            DataTable table = new DataTable();
            table.Columns.Add("SubjectID", typeof(int));
            table.Columns.Add("SubName", typeof(string));

            subject.ForEach(x =>
            {
                var rowDT = table.NewRow();
                rowDT["SubjectID"] = x.SubjectID;
                rowDT["SubName"] = x.SubName;
                table.Rows.Add(rowDT);
            });

            DataRow row = table.NewRow();
            row["SubjectID"] = -1;
            row["SubName"] = "Tất cả các môn";

            table.Rows.InsertAt(row, 0);

            cmbFilter.ValueMember = "SubjectID";
            cmbFilter.DisplayMember = "SubName";
            cmbFilter.DataSource = table;

            dgvListContests.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }

        public void randomQuestion(DataGridView table, int quantity, int subjectID)
        {
            var currQuantity = context.QUESTIONS.Where(s => s.SubjectID == subjectID).Count();
            if (quantity == 0)
                MessageBox.Show("Số lượng câu hỏi phải lớn hơn 0");
            else if (quantity > currQuantity)
                MessageBox.Show("Số lượng câu hỏi trong kho không đủ");
            else
            {
                Random random = new Random();

                var rnd = random.NextDouble();
                var question = context.QUESTIONS
                    .Where(x => x.SubjectID == subjectID)
                    .Select(x => new
                    {
                        x.QuestionID,
                        x.SUBJECT.SubName,
                        x.Contents,
                        x.ANSWERS
                        .FirstOrDefault(a => a.QuestionID == x.QuestionID
                        && a.isCorrect).AnswersContent
                    })
                    .OrderBy(p => SqlFunctions.Checksum(p.QuestionID * rnd))
                    .Take(quantity);

                table.DataSource = question.ToList();
            }
            
        }

        private void btnRandomQuestion_Click(object sender, EventArgs e)
        {
            randomQuestion(instance.dgvQuestion, (int)instance.nudQuantity.Value,
                (int)instance.cmbSubject.SelectedValue);
        }

        private void resetInput()
        {
            nudQuantity.Value = 0;
            txtTimeExam.Text = "00:00:00";
            dgvQuestion.DataSource = null;
        }

        private void addData()
        {
            var currDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
            var currDateParse = DateTime.ParseExact(currDate, "yyyy-MM-dd HH:mm:ss:fff", CultureInfo.InvariantCulture);
            EXAMQUESTION examQuestion = new EXAMQUESTION();
            examQuestion.Quantity = (int)nudQuantity.Value;
            examQuestion.ExecutionTime = txtTimeExam.Text;
            examQuestion.SubjectID = (int)cmbSubject.SelectedValue;
            context.EXAMQUESTIONS.Add(examQuestion);
            foreach (DataGridViewRow row in dgvQuestion.Rows)
            {
                // table have 2 primary key 
                LISTQUESTION question = new LISTQUESTION();
                question.CreateDate = currDateParse;
                question.ExamQuestionID = examQuestion.ExamQuestionID;
                question.QuestionID = Convert.ToInt32(row.Cells[0].Value);
                context.LISTQUESTIONs.Add(question);
                context.SaveChanges();
            }
            context.SaveChanges();
            resetInput();
            loadData();
        }

        private void btnAddExamQuestion_Click(object sender, EventArgs e)
        {
            if (txtTimeExam.Text == "00:00:00")
                MessageBox.Show("Vui lòng nhập thời lượng đề thi");
            else if (dgvQuestion.Rows.Count == 0)
                MessageBox.Show("Số lượng câu hỏi phải lớn hơn 0");
            else
            {
                MessageBox.Show("Thêm đề thi thành công");
                addData();
            }
        }

        private void txtTimeExam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvListContests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                e.RowIndex >= 0)
            {
                int examID = Convert.ToInt32(dgvListContests.Rows[e.RowIndex].Cells["ExamID"].Value);
                int subjectID = Convert.ToInt32(dgvListContests.Rows[e.RowIndex].Cells["SubjectID"].Value);
                FormEditContest dialog = new FormEditContest(examID, subjectID, subject);
                dialog.ShowDialog();
            }
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvQuestion.DataSource = null;
        }

        private void btnDeleteExamQuestion_Click(object sender, EventArgs e)
        {
            foreach (var r in dgvListContests.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow))
            {
                int examID = Convert.ToInt32(r.Cells["ExamID"].Value);
                EXAMQUESTION delExamQuestion = context.EXAMQUESTIONS.Where(st => st.ExamQuestionID == examID).SingleOrDefault();
                context.LISTQUESTIONs.Where(x => x.ExamQuestionID == examID).ToList().ForEach(item => context.LISTQUESTIONs.Remove(item));
                context.EXAMQUESTIONS.Remove(delExamQuestion);
                context.SaveChanges();
            }
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text;
            if (key.Equals(""))
                MessageBox.Show("Vui lòng nhập mã đề cần tìm");
            else
            {
                currKey = key;
                if (cmbFilter.SelectedIndex != 0)
                    cmbFilter.SelectedIndex = 0;
                else loadData();
                currKey = "";
            }    
        }
    }
}
