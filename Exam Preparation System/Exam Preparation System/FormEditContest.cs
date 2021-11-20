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

        private void FormEditContest_Load(object sender, EventArgs e)
        {
            // query sai
            var query = from exam in context.LISTQUESTIONs
                        group exam by exam.ExamQuestionID into exams
                        join examQuestion in context.EXAMQUESTIONS
                        on exams.FirstOrDefault().ExamQuestionID equals examQuestion.ExamQuestionID
                        join question in context.QUESTIONS
                        on exams.FirstOrDefault().ExamQuestionID equals question.QuestionID
                        join answer in context.ANSWERS
                        on question.QuestionID equals answer.QuestionID
                        where answer.isCorrect == true 
                        select new { question.QuestionID, question.Contents, answer.AnswersContent ,question.SUBJECT.SubName };
            var queryExam = context.EXAMQUESTIONS.Find(examID);

            nudQuantity.Value = queryExam.Quantity;
            txtTimeExam.Text = queryExam.ExecutionTime;

            cmbSubject.DataSource = subject;
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";
            cmbSubject.SelectedValue = subjectID;

            dgvQuestion.DataSource = query.ToList();

        }
    }
}
