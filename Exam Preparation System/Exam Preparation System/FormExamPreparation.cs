using Exam_Preparation_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Exam_Preparation_System
{
    public partial class FormExamPreparation : Form
    {
        private ContextDB context = Program.context;
        private List<string> result = new List<string>();
        private int examID;

        private int totalSeconds;
        public FormExamPreparation(int examID)
        {
            InitializeComponent();
            this.examID = examID;
        }

        private void FormExamPreparation_Load(object sender, EventArgs e)
        {
            loadData();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                int hours = totalSeconds / 3600;
                int minutes = (totalSeconds - (hours * 3600)) / 60;
                int seconds = totalSeconds - (hours * 3600) - (minutes * 60) ;
                txtTimeExam.Text = string.Format("{0}:{1}:{2}", hours.ToString().PadLeft(2, '0'), minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'));
                totalSeconds--;
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Hết giờ");
            }
        }

        private void loadData()
        {
            var queryQuestion = context.LISTQUESTIONs.Where(x => x.ExamQuestionID == examID).Select(x => x.QUESTION).ToList();
            var queryTime = context.EXAMQUESTIONS.Where(x => x.ExamQuestionID == examID).Select(x => x.ExecutionTime).ToList()[0];
            int height = 25, noQ = 1, h, m, s;
            string[] splitTime = queryTime.ToString().Split(':');

            h = Convert.ToInt32(splitTime[0]);
            m = Convert.ToInt32(splitTime[1]);
            s = Convert.ToInt32(splitTime[2]);
            totalSeconds = (h * 3600) + (m * 60) + s;

            queryQuestion.ForEach(question =>
            {
                int noA = 68;
                var queryAnswer = context.ANSWERS.Where(x => x.QuestionID == question.QuestionID).ToList();

                Guna.UI2.WinForms.Guna2HtmlLabel lblQuestion = new Guna.UI2.WinForms.Guna2HtmlLabel();
                Guna.UI2.WinForms.Guna2Panel pnlQuestion = new Guna.UI2.WinForms.Guna2Panel();

                result.Add(queryAnswer.Where(x => x.isCorrect).FirstOrDefault().AnswersContent);

                pnlQuestion.Location = new System.Drawing.Point(4, height);
                pnlQuestion.Name = "pnlQuestion." + question.QuestionID.ToString();
                pnlQuestion.ShadowDecoration.Parent = pnlQuestion;
                pnlQuestion.Size = new System.Drawing.Size(1100, 200);

                pnlExam.Controls.Add(pnlQuestion);

                lblQuestion.BackColor = System.Drawing.Color.Transparent;
                lblQuestion.Dock = DockStyle.Top;
                lblQuestion.Name = question.QuestionID.ToString();
                lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                lblQuestion.Size = new System.Drawing.Size(86, 15);
                lblQuestion.Text = noQ++ + ". " + question.Contents.ToString();
                lblQuestion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);

                for(int i = queryAnswer.Count - 1; i >= 0; i--)
                {
                    RJRadioButton radio = new RJRadioButton();

                    radio.AutoSize = true;
                    radio.BackColor = System.Drawing.Color.White;
                    radio.CheckedColor = System.Drawing.Color.MediumSlateBlue;
                    radio.MinimumSize = new System.Drawing.Size(0, 21);
                    radio.Name = "radio" + queryAnswer.ToList()[i].AnswersID.ToString();
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
            });
        }

        

        private bool checkPoint(string value , int index)
        {
            if (result[index].Equals(value.Remove(0, 3)))
                return true;
            return false;
        }


        private void btnFinished_Click(object sender, EventArgs e)
        {
            string noChoice = "";
            int index = 0, correctQuantity = 0;
            var children = pnlExam.Controls.OfType<Control>();

            children.ToList().ForEach(pnlQuestion =>
            {
                int count = 0;
                var grandChildren = pnlQuestion.Controls.OfType<Control>();
                grandChildren.ToList().ForEach(control =>
                {
                    if (control is RadioButton)
                    {
                        RadioButton radio = (RadioButton)control;
                        if (radio.Checked == true)
                            correctQuantity = checkPoint(radio.Text, index++) ? ++correctQuantity : correctQuantity;
                        else
                            count++;
                    }
                    if (count == 4)
                        noChoice += control is Guna.UI2.WinForms.Guna2HtmlLabel ? control.Text.Split('.')[0] + " " : null;
                });
                if (count == 4)
                    index++;
            });

            if (noChoice == "")
                MessageBox.Show("Số câu đúng là: " + correctQuantity.ToString());
            else
            {
                DialogResult dlr = MessageBox.Show("Câu chưa chọn: " + noChoice + "\nNhấn OK để nộp bài", "", MessageBoxButtons.OKCancel);
                if (dlr == DialogResult.OK)
                    MessageBox.Show("Số câu đúng là: " + correctQuantity.ToString());
                else return;
            }         
        }
    }
}
