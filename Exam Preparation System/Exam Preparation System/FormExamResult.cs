﻿using System;
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
        public FormExamResult(int totalCorrect, int totalQuestion, string codeExam, string subjectExam, List<int> yourChoice)
        {
            InitializeComponent();

            this.yourChoice = yourChoice;
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

        private void btnViewAnswer_Click(object sender, EventArgs e)
        {
            FormMainMenu.instance.openChildForm(new FormViewAnswer(yourChoice, Convert.ToInt32(lblCodeExam.Text.Split(' ')[2])));
            this.Close();
        }
    }
}
