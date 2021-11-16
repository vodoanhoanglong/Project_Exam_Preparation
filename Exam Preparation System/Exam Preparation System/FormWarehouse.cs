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
    public partial class FormWarehouse : Form
    {
        ContextDB context = new ContextDB();
        private const int MaxRows = 4;
        private DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();
        public FormWarehouse()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            // get data with correct answer
            var query1 = from question in context.QUESTIONS
                   join answer in context.ANSWERS on question.QuestionID equals answer.QuestionID
                   where answer.isCorrect == true
                   select new { subject = question.SUBJECT.SubName, question = question.Contents, answerCorrect = answer.AnswersContent };
            // get data with another answer
            var query2 = from question in context.QUESTIONS
                         join answer in context.ANSWERS on question.QuestionID equals answer.QuestionID
                         where answer.isCorrect == false
                         select new { answerID = answer.AnswersID, answer = answer.AnswersContent };

            cmbdgv.HeaderText = "Câu trả lời khác";
            cmbdgv.DataSource = query2.ToList();
            cmbdgv.ValueMember = "answerID";
            cmbdgv.DisplayMember = "answer";
            dgvQuestion.Columns["Subject"].DataPropertyName = "subject";
            dgvQuestion.Columns["Question"].DataPropertyName = "question";
            dgvQuestion.Columns["isCorrect"].DataPropertyName = "answerCorrect";
            dgvQuestion.Columns[0].ReadOnly = true;
            dgvQuestion.Columns[1].ReadOnly = true;
            dgvQuestion.Columns[2].ReadOnly = true;
            dgvQuestion.DataSource = query1.ToList();
            dgvQuestion.Columns.Add(cmbdgv);
        }

        private void FormWarehouse_Load(object sender, EventArgs e)
        {
            List<SUBJECT> subject = context.SUBJECTS.ToList();
            cmbSubject.DataSource = subject;
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";

            loadData();
        }


        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "")
                MessageBox.Show("Vui lòng nhập câu trả lời");  
            else if (dgvAnswer.Rows.Count < MaxRows)
            {
                string firstColum = txtAnswer.Text;
                string[] row = { firstColum };
                dgvAnswer.Rows.Add(row);
            }
            else MessageBox.Show("Tối đa chỉ 4 câu trả lời");
            txtAnswer.Text = "";
        }


        private void dgvAnswer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAnswer.CurrentRow == null)
                return;
            foreach (DataGridViewRow row in dgvAnswer.Rows)
                    row.Cells["Correct"].Value = false;
                dgvAnswer.CurrentRow.Cells["Correct"].Value = true;
        }

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (dgvAnswer.SelectedRows.Count == 0)
                MessageBox.Show("Chưa có dữ liệu để xóa");
            else
                foreach (var r in dgvAnswer.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow))
                    dgvAnswer.Rows.RemoveAt(r.Index);
        }

        private Boolean checkIsCorrect()
        {
            foreach (DataGridViewRow row in dgvAnswer.Rows)
                if (row.Cells["Correct"].Value != null)
                    if ((Boolean)row.Cells["Correct"].Value == true)
                        return true;  
            return false;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "")
                MessageBox.Show("Vui lòng nhập câu hỏi");
            else if (dgvAnswer.Rows.Count < 4)
                MessageBox.Show("Phải nhập ít nhất 4 câu trả lời");
            else if (!checkIsCorrect())
                MessageBox.Show("Hãy chọn câu trả lời đúng");
            else
            {

            }
        }
    }
}
