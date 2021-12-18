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

        private void loadData()
        {
            var query = from q in context.QUESTIONS
                        join l in context.LISTQUESTIONs on q.QuestionID equals l.QuestionID
                        join a in context.ANSWERS on q.QuestionID equals a.QuestionID
                        where a.isCorrect == true && l.ExamQuestionID == examID
                        group new { q, a } by new { q.QuestionID, q.Contents, a.AnswersContent, q.SUBJECT.SubName }
                        into gr
                        select new
                        {
                            QuestionID = gr.Key.QuestionID,
                            Question = gr.Key.Contents,
                            AnswerCorrect = gr.Key.AnswersContent,
                            SubjectName = gr.Key.SubName
                        };
            var queryExam = context.EXAMQUESTIONS.Find(examID);

            nudQuantity.Value = queryExam.Quantity;
            txtTimeExam.Text = queryExam.ExecutionTime;

            cmbSubject.DataSource = subject;
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";
            cmbSubject.SelectedValue = subjectID;

            dgvQuestion.DataSource = query.ToList();
        }

        private void FormEditContest_Load(object sender, EventArgs e)
        {
            dgvQuestion.AutoGenerateColumns = false;
            lblExamID.Text = lblExamID.Text + examID.ToString();
            loadData();
        }

        private void btnRandomQuestion_Click(object sender, EventArgs e)
        {
            var currQuantity = context.QUESTIONS.Where(s => s.SubjectID == (int)cmbSubject.SelectedValue).Count();
            if (nudQuantity.Value == 0)
                MessageBox.Show("Số lượng câu hỏi phải lớn hơn 0");
            else if (nudQuantity.Value > currQuantity)
                MessageBox.Show("Số lượng câu hỏi trong kho không đủ");
            else
            {
                Random random = new Random();

                int quantity = (int)nudQuantity.Value;
                int seed = random.Next();
                var q = (from question in context.QUESTIONS
                         join answer in context.ANSWERS on question.QuestionID equals answer.QuestionID
                         where question.SubjectID == (int)cmbSubject.SelectedValue && answer.isCorrect == true
                         select new { questionID = question.QuestionID, subject = question.SUBJECT.SubName, question = question.Contents, answer = answer.AnswersContent })
                         .OrderBy(s => (~(s.questionID & seed)) & (s.questionID | seed)).Take(quantity);

                dgvQuestion.DataSource = q.ToList();
            }
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
