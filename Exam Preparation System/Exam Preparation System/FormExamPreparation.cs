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
    public partial class FormExamPreparation : Form
    {
        private ContextDB context = Program.context;
        private int examID;
        public FormExamPreparation(int examID)
        {
            InitializeComponent();
            this.examID = examID;
        }

        private void loadData()
        {
            var queryQuestion = context.LISTQUESTIONs.Where(x => x.ExamQuestionID == examID).Select(x => x.QUESTION);
            int height = 10;
            queryQuestion.ToList().ForEach(question =>
            {
                Guna.UI2.WinForms.Guna2HtmlLabel lblQuestion = new Guna.UI2.WinForms.Guna2HtmlLabel();
                lblQuestion.BackColor = System.Drawing.Color.Transparent;
                lblQuestion.Location = new System.Drawing.Point(65, height);
                lblQuestion.Name = question.QuestionID.ToString();
                lblQuestion.Size = new System.Drawing.Size(86, 15);
                lblQuestion.Text = question.Contents.ToString();
                height += 90;
                pnlExam.Controls.Add(lblQuestion);           
            });
        }

        private void FormExamPreparation_Load(object sender, EventArgs e)
        {

            loadData();
        }
    }
}
