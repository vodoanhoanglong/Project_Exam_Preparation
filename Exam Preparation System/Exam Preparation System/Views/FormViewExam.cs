﻿using Exam_Preparation_System.Models;
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
    public partial class FormViewExam : Form
    {
        private ContextDB context = Program.context;
        private string currKey = "";
        public FormViewExam()
        {
            InitializeComponent();
        }

        private void FormViewExam_Load(object sender, EventArgs e)
        {
            dgvListContests.AutoGenerateColumns = false;
            dgvListContests.Columns["CreateDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            DataTable table = new DataTable();
            table.Columns.Add("SubjectID", typeof(int));
            table.Columns.Add("SubName", typeof(string));

            context.SUBJECTS.ToList().ForEach(x =>
            {
                var rowDT = table.NewRow();
                rowDT["SubjectID"] = x.SubjectID;
                rowDT["SubName"] = x.SubName;
                table.Rows.Add(rowDT);
            });
            // create new row for "Value default"
            DataRow row = table.NewRow();
            row["SubjectID"] = -1;
            row["SubName"] = "Tất cả các môn";
            // insert the row at the top of the table
            table.Rows.InsertAt(row, 0);
            // do the databinding
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubName";
            cmbSubject.DataSource = table;
        }

        private void loadData(int subID = -1)
        {
            var query = !currKey.Equals("")
                ? context.EXAMQUESTIONS
                .AsEnumerable()
                .Where(x => x.ExamQuestionID == Convert.ToInt32(currKey))
                : subID == -1 ?
                context.EXAMQUESTIONS
                : context.EXAMQUESTIONS.Where(x => x.SubjectID == subID);

            dgvListContests.DataSource = query
            .Select(x => new
            {
                x.ExamQuestionID,
                x.Quantity,
                x.ExecutionTime,
                x.SubjectID,
                x.SUBJECT.SubName,
                x.LISTQUESTIONs
                        .FirstOrDefault(ele => ele.ExamQuestionID == x.ExamQuestionID)
                        .CreateDate
            })
            .ToList();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currKey.Equals(""))
                txtExamID.Text = "";
            loadData((int)cmbSubject.SelectedValue);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtExamID.Text == "")
                MessageBox.Show("Vui lòng nhập mã đề");
            else
            {
                currKey = txtExamID.Text;
                if (cmbSubject.SelectedIndex != 0)
                    cmbSubject.SelectedIndex = 0;
                else loadData();
                currKey = "";
            }    
        }

        private void txtExamID_KeyPress(object sender, KeyPressEventArgs e)
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
                int examID = Convert.ToInt32(dgvListContests.Rows[e.RowIndex].Cells["ExamID"].Value);
                FormMainMenu.instance.openChildForm(new FormExamPreparation(examID));
            }
        }
    }
}
