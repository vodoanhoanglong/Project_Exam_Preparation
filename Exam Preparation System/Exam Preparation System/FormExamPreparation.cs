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
        private List<string> result = new List<string>();
        private int examID;
        public FormExamPreparation(int examID)
        {
            InitializeComponent();
            this.examID = examID;
        }

        private IEnumerable<Control> GetControlHierarchy(Control root)
        {
            var queue = new Queue<Control>();

            queue.Enqueue(root);

            do
            {
                var control = queue.Dequeue();

                yield return control;

                foreach (var child in control.Controls.OfType<Control>())
                    queue.Enqueue(child);

            } while (queue.Count > 0);

        }


        private void FormExamPreparation_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var queryQuestion = context.LISTQUESTIONs.Where(x => x.ExamQuestionID == examID).Select(x => x.QUESTION);
            int height = 25;
            int noQ = 1;

            queryQuestion.ToList().ForEach(question =>
            {
                int noA = 68;
                var queryAnswer = context.ANSWERS.Where(x => x.QuestionID == question.QuestionID);

                Guna.UI2.WinForms.Guna2HtmlLabel lblQuestion = new Guna.UI2.WinForms.Guna2HtmlLabel();
                Guna.UI2.WinForms.Guna2Panel pnlQuestion = new Guna.UI2.WinForms.Guna2Panel();

                result.Add(queryAnswer.Where(x => x.isCorrect).FirstOrDefault().AnswersContent);

                pnlQuestion.Location = new System.Drawing.Point(4, height);
                pnlQuestion.Name = "pnlQuestion" + question.QuestionID.ToString();
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

                for(int i = queryAnswer.ToList().Count - 1; i >= 0; i--)
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


        private void btnFinished_Click(object sender, EventArgs e)
        {
            /*string str = "";
            foreach (var control in GetControlHierarchy(pnlExam))
            {
                str += control.Name + "\n";
                *//*if (control is RadioButton)
                {
                    RadioButton radioValue = (RadioButton)control;
                    if (radioValue.Checked == true)
                        MessageBox.Show(radioValue.Text);
                }*//*
            }
            MessageBox.Show(str);*/

            var children = pnlExam.Controls.OfType<Control>();
            children.ToList().ForEach(x =>
            {
                int count = 0;
                var childrens = x.Controls.OfType<RadioButton>();
                childrens.ToList().ForEach(radio =>
                {  
                    if (radio.Checked == true)
                        MessageBox.Show(radio.Text);
                    else
                        count++;
                });
                if(count == 4)
                {
                    MessageBox.Show("Câu chưa chọn " + x.Name);
                    return;
                }    
            });
        }
    }
}
