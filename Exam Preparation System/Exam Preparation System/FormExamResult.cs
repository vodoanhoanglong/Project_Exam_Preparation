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

            lblCodeExam.Text += codeExam;
            lblSubject.Text += subjectExam;
            lblFullName.Text += FormLogin.info.FullName;

            progressBar.Value = totalCorrect;
            progressBar.Maximum = totalQuestion;
            progressBar.Text = totalCorrect.ToString() + "/" + totalQuestion.ToString();
        }
    }
}
