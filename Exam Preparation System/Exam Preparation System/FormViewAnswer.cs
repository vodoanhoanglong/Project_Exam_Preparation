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
    public partial class FormViewAnswer : Form
    {
        private ContextDB context = Program.context;
        private int examID;
        private List<int> yourChoice;
        public FormViewAnswer(List<int> yourChoice, int examID)
        {
            InitializeComponent();
            this.yourChoice = yourChoice;
            this.examID = examID;
        }

        private void FormViewAnswer_Load(object sender, EventArgs e)
        {
            var queryQuestion = context.LISTQUESTIONs.Where(x => x.ExamQuestionID == examID).Select(x => x.QUESTION).ToList();
            int height = 25, noQ = 1;

            queryQuestion.ForEach(question =>
            {
                int noA = 68, index = 0;
                var queryAnswer = context.ANSWERS.Where(x => x.QuestionID == question.QuestionID).ToList();

                Guna.UI2.WinForms.Guna2HtmlLabel lblQuestion = new Guna.UI2.WinForms.Guna2HtmlLabel();
                Guna.UI2.WinForms.Guna2Panel pnlQuestion = new Guna.UI2.WinForms.Guna2Panel();

                pnlQuestion.Location = new System.Drawing.Point(4, height);
                pnlQuestion.Name = "pnlQuestion." + question.QuestionID.ToString();
                pnlQuestion.ShadowDecoration.Parent = pnlQuestion;
                pnlQuestion.Size = new System.Drawing.Size(1100, 200);

                pnlExam.Controls.Add(pnlQuestion);

                lblQuestion.BackColor = System.Drawing.Color.Transparent;
                lblQuestion.Dock = DockStyle.Top;
                lblQuestion.Name = "lblQuestion" + question.QuestionID.ToString();
                lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                lblQuestion.Size = new System.Drawing.Size(86, 15);
                lblQuestion.Text = noQ++ + ". " + question.Contents.ToString();
                lblQuestion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);

                if (yourChoice[index] == -1)
                    lblQuestion.Text += "\n" + "(Không chọn)";
                MessageBox.Show(yourChoice[index].ToString());
                for (int i = queryAnswer.Count - 1; i >= 0; i--)
                {
                    RJRadioButton radio = new RJRadioButton();

                    if (yourChoice[index] == queryAnswer.ToList()[i].AnswersID)
                    {
                        radio.Checked = true;
                        if (queryAnswer.ToList()[i].isCorrect == true)
                            radio.CheckedColor = Color.Green;
                        else radio.CheckedColor = Color.Red;
                    }

                    if (queryAnswer.ToList()[i].isCorrect == true)
                    {
                        radio.Checked = true;
                        radio.CheckedColor = Color.Green;
                    }

                    radio.AutoSize = true;
                    radio.BackColor = System.Drawing.Color.White;
                    radio.CheckedColor = System.Drawing.Color.MediumSlateBlue;
                    radio.MinimumSize = new System.Drawing.Size(0, 21);
                    radio.Name = queryAnswer.ToList()[i].AnswersID.ToString();
                    radio.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
                    radio.Size = new System.Drawing.Size(105, 21);
                    radio.Dock = DockStyle.Top;
                    radio.Text = (char)noA-- + ". " + queryAnswer.ToList()[i].AnswersContent.ToString();
                    radio.UnCheckedColor = System.Drawing.Color.Gray;
                    radio.UseVisualStyleBackColor = false;

                    pnlQuestion.Controls.Add(radio);
                }

                pnlQuestion.Controls.Add(lblQuestion);
                height += 200;
                index++;
            });
        }
    }
}
