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
    public partial class FormExamResult : Form
    {
        private List<int> yourChoice;
        private int totalCorrect, totalQuestion, examID;
        public FormExamResult(int totalCorrect, int totalQuestion, string codeExam, List<int> yourChoice)
        {
            InitializeComponent();
            this.yourChoice = yourChoice;
            this.totalCorrect = totalCorrect;
            this.totalQuestion = totalQuestion;

            double point = (10 * totalCorrect) / totalQuestion;

            lblCodeExam.Text = codeExam;
            lblFullName.Text = FormLogin.info.FullName;
            lblPoint.Text += Math.Round(point, 1).ToString();

            progressBar.Value = totalCorrect;
            progressBar.Maximum = totalQuestion;
            progressBar.Text = totalCorrect.ToString() + "/" + totalQuestion.ToString();
            this.examID = Convert.ToInt32(codeExam.Split(' ')[2]);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMainMenu.instance.openChildForm(new FormViewExam());
            this.Close();
        }

        private void btnViewAnswer_Click(object sender, EventArgs e)
        {
            FormMainMenu.instance.openChildForm(new FormViewAnswer(yourChoice, examID, totalCorrect, totalQuestion));
            this.Close();
        }
    }
}
