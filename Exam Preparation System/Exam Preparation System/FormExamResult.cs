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
        public FormExamResult(int totalCorrect, int totalQuestion, string codeExam, string subjectExam)
        {
            InitializeComponent();

            double point = (10 * totalCorrect) / totalQuestion;

            lblCodeExam.Text += codeExam;
            lblSubject.Text += subjectExam;
            lblFullName.Text += FormLogin.info.FullName;
            lblPoint.Text += Math.Round(point, 1).ToString();

            progressBar.Value = totalCorrect;
            progressBar.Maximum = totalQuestion;
            progressBar.Text = totalCorrect.ToString() + "/" + totalQuestion.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMainMenu.instance.openChildForm(new FormViewExam());
            this.Close();
        }
    }
}
