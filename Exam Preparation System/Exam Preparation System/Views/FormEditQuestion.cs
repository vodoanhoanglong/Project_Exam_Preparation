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
    public partial class FormEditQuestion : Form
    {
        private ContextDB context = Program.context;
        private List<SUBJECT> subject = null;
        private int questionID, subjectID;
        private string contentQuestion;
        public FormEditQuestion(int questionID,int subjectID, string contentQuestion, List<SUBJECT> subject)
        {
            InitializeComponent();
            this.subject = subject;
            this.questionID = questionID;
            this.subjectID = subjectID;
            this.contentQuestion = contentQuestion;
        }

        private void FormEditQuestion_Load(object sender, EventArgs e)
        {
            var query = from answer in context.ANSWERS
                        where answer.QuestionID == questionID
                        select new { answer.AnswersContent, answer.isCorrect, answer.AnswersID };

            cmbSubject.DataSource = subject;
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";
            cmbSubject.SelectedValue = subjectID;

            txtQuestion.Text = contentQuestion;

            query.ToList().ForEach(x =>
            {
                string firstColum = x.AnswersContent;
                string secondColum = x.isCorrect.ToString();
                string thirdColum = x.AnswersID.ToString();
                string[] row = { firstColum, secondColum, thirdColum };
                dgvAnswer.Rows.Add(row);
            });
        }

        private void dgvAnswer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAnswer.CurrentRow == null)
                return;
            foreach (DataGridViewRow row in dgvAnswer.Rows)
                row.Cells["Correct"].Value = false;
            dgvAnswer.CurrentRow.Cells["Correct"].Value = true;
        }

        private void updateData()
        {
            QUESTION question = context.QUESTIONS.Find(questionID);
            question.Contents = txtQuestion.Text;
            question.SubjectID = Convert.ToInt32(cmbSubject.SelectedValue);
            foreach (DataGridViewRow row in dgvAnswer.Rows)
            {
                int ansID = Convert.ToInt32(row.Cells[2].Value);
                ANSWER answer = context.ANSWERS.Find(ansID);
                answer.AnswersContent = row.Cells[0].Value.ToString();
                answer.isCorrect = Convert.ToBoolean(row.Cells[1].Value);
                context.SaveChanges();
            }
            context.SaveChanges();
        }

        private Boolean checkIsCorrect()
        {
            foreach (DataGridViewRow row in dgvAnswer.Rows)
                if (row.Cells["Correct"].Value != null)
                    if (Convert.ToBoolean(row.Cells["Correct"].Value) == true)
                        return true;
            return false;
        }
        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "")
                MessageBox.Show("Vui lòng nhập câu hỏi");
            else if (dgvAnswer.Rows.Count < 4)
                MessageBox.Show("Phải nhập ít nhất 4 câu trả lời");
            else if (!checkIsCorrect())
                MessageBox.Show("Hãy chọn câu trả lời đúng");
            else
            {
                updateData();
                FormWarehouse.instance.loadData();
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
