﻿using Exam_Preparation_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Preparation_System
{
    public partial class FormCreateExam : Form
    {
        ContextDB context = Program.context;
        public FormCreateExam()
        {
            InitializeComponent();
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                         (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void loadData()
        {
            var query = from lq in context.LISTQUESTIONs
                        group lq by lq.ExamQuestionID into lqs
                        join eq in context.EXAMQUESTIONS
                        on lqs.FirstOrDefault().ExamQuestionID equals eq.ExamQuestionID    
                        select new 
                        { eq.ExamQuestionID, eq.Quantity, eq.ExecutionTime, eq.SubjectID, lqs.FirstOrDefault().CreateDate };
            dgvListContests.DataSource = query.ToList();
        }

        private void FormCreateExam_Load(object sender, EventArgs e)
        {
            dgvQuestion.AutoGenerateColumns = false;

            List<SUBJECT> subject = context.SUBJECTS.ToList();
            cmbSubject.DataSource = subject;
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";

            dgvQuestion.Columns["QuestionID"].DataPropertyName = "questionID";
            dgvQuestion.Columns["SubjectName"].DataPropertyName = "subject";
            dgvQuestion.Columns["Question"].DataPropertyName = "question";

            loadData();
        }

        private void btnRandomQuestion_Click(object sender, EventArgs e)
        {
            var currQuantity = context.QUESTIONS.Where(s => s.SubjectID == (int)cmbSubject.SelectedValue).Count();
            if (nudQuantity.Value == 0)
                MessageBox.Show("Số lượng câu hỏi phải lớn hơn 0");
            else if (nudQuantity.Value > currQuantity)
                MessageBox.Show("Số lượng câu hỏi trong kho không đủ");
            else
            {
                Random random = new Random();

                int quantity = (int)nudQuantity.Value;
                int seed = random.Next();
                var q = (from question in context.QUESTIONS
                         where question.SubjectID == (int)cmbSubject.SelectedValue
                         select new { questionID = question.QuestionID, subject = question.SUBJECT.SubName, question = question.Contents })
                         .OrderBy(s => (~(s.questionID & seed)) & (s.questionID | seed)).Take(quantity);

                dgvQuestion.DataSource = q.ToList();
            }
        }

        private void btnAddExamQuestion_Click(object sender, EventArgs e)
        {
            if (txtTimeExam.Text == "00:00:00")
                MessageBox.Show("Vui lòng nhập thời lượng đề thi");
            else if (dgvQuestion.Rows.Count == 0)
                MessageBox.Show("Số lượng câu hỏi phải lớn hơn 0");
            else
            {
                MessageBox.Show("Thêm đề thi thành công");
                EXAMQUESTION examQuestion = new EXAMQUESTION();
                examQuestion.Quantity = (int)nudQuantity.Value;
                examQuestion.ExecutionTime = txtTimeExam.Text;
                examQuestion.SubjectID = (int)cmbSubject.SelectedValue;
                context.EXAMQUESTIONS.Add(examQuestion);
                foreach (DataGridViewRow row in dgvQuestion.Rows)
                {
                    // table have 2 primary key 
                    LISTQUESTION question = new LISTQUESTION();
                    question.ExamQuestionID = examQuestion.ExamQuestionID;
                    question.QuestionID = Convert.ToInt32(row.Cells[0].Value);
                    context.LISTQUESTIONs.Add(question);
                    context.SaveChanges();
                }
                context.SaveChanges();
                loadData();
            }
        }

        private void txtTimeExam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvListContests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                
            }
        }
    }
}
