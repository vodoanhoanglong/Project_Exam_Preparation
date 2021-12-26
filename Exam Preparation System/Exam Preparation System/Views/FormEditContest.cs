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

            dgvQuestion.DataSource = query;
            lblSubName.Text += query[0].SubName;
            lblQuantity.Text += query[0].Quantity;
            lblExcutime.Text += query[0].ExecutionTime;
        }

        private void FormEditContest_Load(object sender, EventArgs e)
        {
            dgvQuestion.AutoGenerateColumns = false;
            lblExamID.Text = lblExamID.Text + examID.ToString();
            loadData();
        }
    }
}
