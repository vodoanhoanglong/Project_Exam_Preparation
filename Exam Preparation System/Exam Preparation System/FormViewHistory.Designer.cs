
namespace Exam_Preparation_System
{
    partial class FormViewHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListContests = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtExamID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSubject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnReset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityCorrect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcuteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListContests
            // 
            this.dgvListContests.AllowUserToAddRows = false;
            this.dgvListContests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListContests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListContests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListContests.BackgroundColor = System.Drawing.Color.White;
            this.dgvListContests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListContests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListContests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListContests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListContests.ColumnHeadersHeight = 20;
            this.dgvListContests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamID,
            this.Quantity,
            this.quantityCorrect,
            this.ExcuteTime,
            this.timeCompleted,
            this.SubName,
            this.point,
            this.CreateDate,
            this.SubjectID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListContests.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListContests.EnableHeadersVisualStyles = false;
            this.dgvListContests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListContests.Location = new System.Drawing.Point(12, 302);
            this.dgvListContests.Name = "dgvListContests";
            this.dgvListContests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListContests.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListContests.RowHeadersVisible = false;
            this.dgvListContests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListContests.Size = new System.Drawing.Size(1165, 495);
            this.dgvListContests.TabIndex = 10;
            this.dgvListContests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListContests.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListContests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvListContests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListContests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListContests.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListContests.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListContests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvListContests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListContests.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListContests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListContests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListContests.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvListContests.ThemeStyle.ReadOnly = false;
            this.dgvListContests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListContests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListContests.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListContests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListContests.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListContests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListContests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.DisabledState.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(786, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(136, 32);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // txtExamID
            // 
            this.txtExamID.BorderRadius = 10;
            this.txtExamID.BorderThickness = 2;
            this.txtExamID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExamID.DefaultText = "";
            this.txtExamID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExamID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExamID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExamID.DisabledState.Parent = this.txtExamID;
            this.txtExamID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExamID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExamID.FocusedState.Parent = this.txtExamID;
            this.txtExamID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExamID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExamID.HoverState.Parent = this.txtExamID;
            this.txtExamID.Location = new System.Drawing.Point(414, 154);
            this.txtExamID.Name = "txtExamID";
            this.txtExamID.PasswordChar = '\0';
            this.txtExamID.PlaceholderText = "Tìm kiếm theo Mã đề";
            this.txtExamID.SelectedText = "";
            this.txtExamID.ShadowDecoration.Parent = this.txtExamID;
            this.txtExamID.Size = new System.Drawing.Size(326, 36);
            this.txtExamID.TabIndex = 17;
            // 
            // cmbSubject
            // 
            this.cmbSubject.BackColor = System.Drawing.Color.Transparent;
            this.cmbSubject.BorderRadius = 10;
            this.cmbSubject.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cmbSubject.BorderThickness = 2;
            this.cmbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSubject.FocusedState.Parent = this.cmbSubject;
            this.cmbSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSubject.HoverState.Parent = this.cmbSubject;
            this.cmbSubject.ItemHeight = 30;
            this.cmbSubject.ItemsAppearance.Parent = this.cmbSubject;
            this.cmbSubject.Location = new System.Drawing.Point(414, 85);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.ShadowDecoration.Parent = this.cmbSubject;
            this.cmbSubject.Size = new System.Drawing.Size(326, 36);
            this.cmbSubject.TabIndex = 16;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(206, 85);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(121, 27);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Lọc theo môn";
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 10;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.DisabledState.Parent = this.btnReset;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(1043, 247);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(110, 32);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(481, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 27);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Danh sách các lần thi";
            // 
            // ExamID
            // 
            this.ExamID.DataPropertyName = "ExamQuestionID";
            this.ExamID.FillWeight = 113.9086F;
            this.ExamID.HeaderText = "Mã đề thi";
            this.ExamID.Name = "ExamID";
            this.ExamID.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 113.9086F;
            this.Quantity.HeaderText = "Số câu hỏi";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // quantityCorrect
            // 
            this.quantityCorrect.HeaderText = "Số câu đúng";
            this.quantityCorrect.Name = "quantityCorrect";
            this.quantityCorrect.ReadOnly = true;
            // 
            // ExcuteTime
            // 
            this.ExcuteTime.DataPropertyName = "ExecutionTime";
            this.ExcuteTime.FillWeight = 113.9086F;
            this.ExcuteTime.HeaderText = "Thời lượng cuộc thi";
            this.ExcuteTime.Name = "ExcuteTime";
            this.ExcuteTime.ReadOnly = true;
            // 
            // timeCompleted
            // 
            this.timeCompleted.HeaderText = "Thời gian hoàn thành";
            this.timeCompleted.Name = "timeCompleted";
            this.timeCompleted.ReadOnly = true;
            // 
            // SubName
            // 
            this.SubName.DataPropertyName = "SubName";
            this.SubName.FillWeight = 113.9086F;
            this.SubName.HeaderText = "Môn";
            this.SubName.Name = "SubName";
            this.SubName.ReadOnly = true;
            // 
            // point
            // 
            this.point.HeaderText = "Điểm";
            this.point.Name = "point";
            this.point.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "dd/MM/yyyy hh:mm:ss";
            this.CreateDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.CreateDate.FillWeight = 113.9086F;
            this.CreateDate.HeaderText = "Ngày thi";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "SubjectID";
            this.SubjectID.HeaderText = "SubjectID";
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.ReadOnly = true;
            this.SubjectID.Visible = false;
            // 
            // FormViewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1189, 809);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtExamID);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvListContests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewHistory";
            this.Text = "Lịch sử luyện thi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvListContests;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtExamID;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSubject;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityCorrect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcuteTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}