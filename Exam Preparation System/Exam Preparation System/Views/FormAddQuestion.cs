using Exam_Preparation_System.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Preparation_System.Views
{
    public partial class FormAddQuestion : Form
    {
        private ContextDB context = Program.context;
        private int subID;
        private DataTable ta;
        private DataGridView currDgv;
        private Guna2NumericUpDown currNud;
        private string currKey = "";
        public FormAddQuestion(int subID, DataGridView currDgv, Guna2NumericUpDown currNud)
        {
            InitializeComponent();
            this.subID = subID;
            this.currDgv = currDgv;
            this.currNud = currNud;
        }

        private void FormAddQuestion_Load(object sender, EventArgs e)
        {
            loadData();
            ta = currDgv.DataSource as DataTable;
            if(ta == null)
            {
                ta = new DataTable();
                ta.Columns.Add("QuestionID", typeof(int));
                ta.Columns.Add("SubName", typeof(string));
                ta.Columns.Add("Contents", typeof(string));
                ta.Columns.Add("AnswersContent", typeof(string));
            }
        }

        private void loadData()
        {
            var data = !currKey.Equals("")
                ? context.QUESTIONS
                .Where(x => x.SubjectID == this.subID && x.Contents.Contains(currKey))
                : context.QUESTIONS
                .Where(x => x.SubjectID == this.subID);

            dgvQuestion.DataSource = data
                .OrderByDescending(x => x.QuestionID)
                .Select(x => new
                {
                    x.QuestionID,
                    x.SUBJECT.SubName,
                    x.Contents,
                    x.ANSWERS.FirstOrDefault(ele => ele.isCorrect).AnswersContent
                })
                .ToList();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            currKey = txtSearch.Text;
            loadData();
            currKey = "";
        }

        private void addRow(int id, string subName, string contents, string answerContents)
        {           
            DataRow rowDT = ta.NewRow();
            rowDT["QuestionID"] = id;
            rowDT["SubName"] = subName;
            rowDT["Contents"] = contents;
            rowDT["AnswersContent"] = answerContents;

            ta.Rows.Add(rowDT);
            currDgv.DataSource = ta;
            currNud.Value += 1;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            foreach (var selectedRow in dgvQuestion.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Where(selectedRow => !selectedRow.IsNewRow))
            {
                int flag = 0;
                string newRow = selectedRow.Cells[0].Value.ToString();
                for(int i = 0; i < currDgv.Rows.Count; i++)
                {
                    string oldRow = currDgv.Rows[i].Cells[0].Value.ToString();
                    if (newRow.Equals(oldRow))
                    {
                        MessageBox.Show("Câu " + newRow + " đã có");
                        flag++; 
                        break;
                    }
                }
                if(flag == 0)
                    addRow((int)selectedRow.Cells[0].Value, selectedRow.Cells[1].Value.ToString(),
                    selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());
            }    

        }
    }
}
