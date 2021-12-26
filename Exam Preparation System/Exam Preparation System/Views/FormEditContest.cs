using Exam_Preparation_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Preparation_System
{
    public partial class FormEditContest : Form
    {
        ContextDB context = Program.context;
        private int examID, subjectID;
        private List<SUBJECT> subject = null;
        public FormEditContest(int examID, int subjectID, List<SUBJECT> subject)
        {
            InitializeComponent();
            this.examID = examID;
            this.subjectID = subjectID;
            this.subject = subject;
        }

        public void setNudQuantity(int quanity)
        {
            this.nudQuantity.Value = quanity;
        }

        private void loadData()
        {
            var query = context.LISTQUESTIONs
                .Where(x => x.ExamQuestionID == this.examID)
                .Select(x => new
                {
                    x.QuestionID,
                    x.QUESTION.Contents,
                    x.EXAMQUESTION.SUBJECT.SubName,
                    x.QUESTION.ANSWERS.FirstOrDefault(ele => ele.isCorrect).AnswersContent,
                    x.EXAMQUESTION.Quantity,
                    x.EXAMQUESTION.ExecutionTime
                })
                .ToList();

            cmbSubject.DataSource = subject;
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";
            cmbSubject.SelectedValue = subjectID;

            nudQuantity.Value = query[0].Quantity;
            txtTimeExam.Text = query[0].ExecutionTime;

            dgvQuestion.DataSource = query;
        }

        private void FormEditContest_Load(object sender, EventArgs e)
        {
            dgvQuestion.AutoGenerateColumns = false;
            lblExamID.Text = lblExamID.Text + examID.ToString();
            loadData();
        }

        private void btnRandomQuestion_Click(object sender, EventArgs e)
        {
            FormCreateExam.instance.randomQuestion(this.dgvQuestion,
                (int)this.nudQuantity.Value,
                (int)this.cmbSubject.SelectedValue);
        }

        private void cmbSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvQuestion.DataSource = null;
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            dgvQuestion.DataSource = null;
        }

        private void updateData()
        {
            EXAMQUESTION exam = context.EXAMQUESTIONS.Find(examID);
            var currDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
            var currDateParse = DateTime.ParseExact(currDate, "yyyy-MM-dd HH:mm:ss:fff", CultureInfo.InvariantCulture);
            exam.SubjectID = Convert.ToInt32(cmbSubject.SelectedValue);
            exam.Quantity = Convert.ToInt32(nudQuantity.Value);
            exam.ExecutionTime = txtTimeExam.Text;
            context.LISTQUESTIONs.Where(x => x.ExamQuestionID == examID).ToList().ForEach(item => context.LISTQUESTIONs.Remove(item));
            foreach (DataGridViewRow row in dgvQuestion.Rows)
            {
                // table have 2 primary key 
                LISTQUESTION question = new LISTQUESTION();
                question.CreateDate = currDateParse;
                question.ExamQuestionID = examID;
                question.QuestionID = Convert.ToInt32(row.Cells[0].Value);
                context.LISTQUESTIONs.Add(question);
                context.SaveChanges();
            }
            context.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvQuestion.Rows.Count == 0)
                MessageBox.Show("Vui lòng trộn câu hỏi cho đề thi");
            else
            {
                updateData();
                FormCreateExam.instance.loadData();
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
