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
        private ContextDB context = Program.context;
        private List<SUBJECT> subject = null;
        private const int MaxRows = 4;
        public static FormWarehouse instance;
        public FormWarehouse()
        {
            InitializeComponent();
            instance = this;
        }

        private void resetInput()
        {
            txtAnswer.Text = "";
            txtQuestion.Text = "";
            dgvAnswer.Rows.Clear();
            dgvAnswer.Refresh();

        }

        public void loadData()
        {
            // get data with correct answer
            var query = from question in context.QUESTIONS
                         join answer in context.ANSWERS on question.QuestionID equals answer.QuestionID
                         where answer.isCorrect == true
                         select new { questionID = question.QuestionID, subjectID = question.SUBJECT.SubjectID, subject = question.SUBJECT.SubName, question = question.Contents, answerCorrect = answer.AnswersContent };

            dgvQuestion.DataSource = query.ToList();
        }

        private void FormWarehouse_Load(object sender, EventArgs e)
        {
            dgvQuestion.AutoGenerateColumns = false;

            subject = context.SUBJECTS.ToList();
            cmbSubject.DataSource = subject;
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";

            dgvQuestion.Columns["QuestionID"].DataPropertyName = "questionID";
            dgvQuestion.Columns["SubjectName"].DataPropertyName = "subject";
            dgvQuestion.Columns["Question"].DataPropertyName = "question";
            dgvQuestion.Columns["isCorrect"].DataPropertyName = "answerCorrect";
            dgvQuestion.Columns["SubjectID"].DataPropertyName = "subjectID";

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

        private void dgvQuestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                e.RowIndex >= 0)
            {
                int questionID = Convert.ToInt32(dgvQuestion.Rows[e.RowIndex].Cells[0].Value);
                int subjectID = Convert.ToInt32(dgvQuestion.Rows[e.RowIndex].Cells[5].Value);
                string contentQuestion = dgvQuestion.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditQuestion dialog = new FormEditQuestion(questionID, subjectID, contentQuestion, subject);
                dialog.ShowDialog();
            }
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

        private void saveData()
        {
            QUESTION newQuestion = new QUESTION();
            ANSWER newAnswer = new ANSWER();
            newQuestion.Contents = txtQuestion.Text;
            newQuestion.SubjectID = Convert.ToInt32(cmbSubject.SelectedValue);
            context.QUESTIONS.Add(newQuestion);
            foreach(DataGridViewRow row in dgvAnswer.Rows)
            {
                newAnswer.AnswersContent = row.Cells[0].Value.ToString();
                newAnswer.isCorrect = Convert.ToBoolean(row.Cells[1].Value);
                newAnswer.QuestionID = newQuestion.QuestionID;
                context.ANSWERS.Add(newAnswer);
                context.SaveChanges();
            }
            context.SaveChanges();
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
                saveData();
                resetInput();
                loadData();
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            foreach (var r in dgvQuestion.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow))
            {
                int quesID = Convert.ToInt32(r.Cells[0].Value.ToString());
                QUESTION delQuestion = context.QUESTIONS.Where(st => st.QuestionID == quesID).SingleOrDefault();
                context.ANSWERS.Where(x => x.QuestionID == quesID).ToList().ForEach(item => context.ANSWERS.Remove(item));
                context.QUESTIONS.Remove(delQuestion);
                context.SaveChanges();
            }
            loadData();
        }
    }
}
