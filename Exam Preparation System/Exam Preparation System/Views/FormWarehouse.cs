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
        private string currKey = "";
        public FormWarehouse()
        {
            InitializeComponent();
            instance = this;
        }

        private void resetInput()
        {
            txtAnswer.Text = "";
            txtQuestion.Text = "";
            txtSearch.Text = "";
            cmbFilter.SelectedIndex = 0;
            dgvAnswer.Rows.Clear();
            dgvAnswer.Refresh();
        }

        public void loadData(int subID = -1)
        {
      
            var query = subID == -1 ?
                context.QUESTIONS
                : context.QUESTIONS.Where(x => x.SubjectID == subID);

            dgvQuestion.DataSource = query.OrderByDescending(x => x.QuestionID)
                .Select(x => new 
                { 
                    x.QuestionID,
                    x.SubjectID,
                    x.SUBJECT.SubName,
                    x.Contents,
                    x.ANSWERS.FirstOrDefault(ele => ele.isCorrect).AnswersContent
                }).ToList();
        }

        private void loadDataByQuestion()
        {
            var data = !currKey.Equals("")
                ? context.QUESTIONS
                .Where(x => x.Contents.Contains(currKey))
                : context.QUESTIONS;

            dgvQuestion.DataSource = data.OrderByDescending(x => x.QuestionID)
                .Select(x => new
                {
                    x.QuestionID,
                    x.SubjectID,
                    x.SUBJECT.SubName,
                    x.Contents,
                    x.ANSWERS.FirstOrDefault(ele => ele.isCorrect).AnswersContent
                }).ToList();
        }

        private void FormWarehouse_Load(object sender, EventArgs e)
        {
            dgvQuestion.AutoGenerateColumns = false;

            subject = context.SUBJECTS.ToList();
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";
            cmbSubject.DataSource = subject;

            DataTable table = new DataTable();
            table.Columns.Add("SubjectID", typeof(int));
            table.Columns.Add("SubName", typeof(string));

            subject.ForEach(x =>
            {
                var rowDT = table.NewRow();
                rowDT["SubjectID"] = x.SubjectID;
                rowDT["SubName"] = x.SubName;
                table.Rows.Add(rowDT);
            });

            DataRow row = table.NewRow();
            row["SubjectID"] = -1;
            row["SubName"] = "Tất cả các môn";

            table.Rows.InsertAt(row, 0);

            cmbFilter.ValueMember = "SubjectID";
            cmbFilter.DisplayMember = "SubName";
            cmbFilter.DataSource = table;

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
                resetInput();
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
                MessageBox.Show("Thêm câu hỏi thành công");
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            foreach (var r in dgvQuestion.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow))
            {
                int quesID = Convert.ToInt32(r.Cells[0].Value);
                QUESTION delQuestion = context.QUESTIONS.Where(st => st.QuestionID == quesID).SingleOrDefault();
                context.ANSWERS.Where(x => x.QuestionID == quesID).ToList().ForEach(item => context.ANSWERS.Remove(item));
                context.QUESTIONS.Remove(delQuestion);
                context.LISTQUESTIONs.Where(x => x.QuestionID == quesID).ToList().ForEach(item =>
                {
                    context.EXAMQUESTIONS.Where(x => x.ExamQuestionID == item.ExamQuestionID).ToList()
                    .ForEach(ele => ele.Quantity -= 1);
                    context.LISTQUESTIONs.Remove(item);
                });
                context.SaveChanges();
            }
            resetInput();
            loadData();
        }


        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
            currKey = txtSearch.Text;
            loadDataByQuestion();
            currKey = "";
        }

        private void cmbFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            loadData((int)cmbFilter.SelectedValue);
        }
    }
}
