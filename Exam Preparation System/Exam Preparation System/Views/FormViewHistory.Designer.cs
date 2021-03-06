
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
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            this.dgvHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCorrect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcuteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExamID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSubject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chart = new Guna.Charts.WinForms.GunaChart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistory.ColumnHeadersHeight = 20;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamID,
            this.Quantity,
            this.QuantityCorrect,
            this.ExcuteTime,
            this.timeCompleted,
            this.SubName,
            this.ExamDate,
            this.point});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistory.EnableHeadersVisualStyles = false;
            this.dgvHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistory.Location = new System.Drawing.Point(-1, 224);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(1200, 391);
            this.dgvHistory.TabIndex = 10;
            this.dgvHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistory.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHistory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHistory.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvHistory.ThemeStyle.ReadOnly = false;
            this.dgvHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHistory.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ExamID
            // 
            this.ExamID.DataPropertyName = "ExamQuestionID";
            this.ExamID.DividerWidth = 1;
            this.ExamID.FillWeight = 41.40887F;
            this.ExamID.HeaderText = "Mã đề";
            this.ExamID.Name = "ExamID";
            this.ExamID.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.DividerWidth = 1;
            this.Quantity.FillWeight = 84.64045F;
            this.Quantity.HeaderText = "Số câu hỏi";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // QuantityCorrect
            // 
            this.QuantityCorrect.DataPropertyName = "QuantityCorrect";
            this.QuantityCorrect.DividerWidth = 1;
            this.QuantityCorrect.FillWeight = 88.27848F;
            this.QuantityCorrect.HeaderText = "Số câu đúng";
            this.QuantityCorrect.Name = "QuantityCorrect";
            this.QuantityCorrect.ReadOnly = true;
            // 
            // ExcuteTime
            // 
            this.ExcuteTime.DataPropertyName = "ExecutionTime";
            this.ExcuteTime.DividerWidth = 1;
            this.ExcuteTime.FillWeight = 127.3452F;
            this.ExcuteTime.HeaderText = "Thời gian làm bài";
            this.ExcuteTime.Name = "ExcuteTime";
            this.ExcuteTime.ReadOnly = true;
            // 
            // timeCompleted
            // 
            this.timeCompleted.DataPropertyName = "TimeComplete";
            this.timeCompleted.DividerWidth = 1;
            this.timeCompleted.FillWeight = 138.3493F;
            this.timeCompleted.HeaderText = "Thời gian hoàn thành";
            this.timeCompleted.Name = "timeCompleted";
            this.timeCompleted.ReadOnly = true;
            // 
            // SubName
            // 
            this.SubName.DataPropertyName = "SubName";
            this.SubName.DividerWidth = 1;
            this.SubName.FillWeight = 191.3521F;
            this.SubName.HeaderText = "Môn";
            this.SubName.Name = "SubName";
            this.SubName.ReadOnly = true;
            // 
            // ExamDate
            // 
            this.ExamDate.DataPropertyName = "ExamDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "dd/MM/yyyy hh:mm:ss";
            this.ExamDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExamDate.DividerWidth = 1;
            this.ExamDate.FillWeight = 158.0014F;
            this.ExamDate.HeaderText = "Ngày thi";
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.ReadOnly = true;
            // 
            // point
            // 
            this.point.DataPropertyName = "Points";
            this.point.DividerWidth = 1;
            this.point.FillWeight = 40.16722F;
            this.point.HeaderText = "Điểm";
            this.point.Name = "point";
            this.point.ReadOnly = true;
            // 
            // txtExamID
            // 
            this.txtExamID.Animated = true;
            this.txtExamID.BackColor = System.Drawing.Color.Transparent;
            this.txtExamID.BorderRadius = 5;
            this.txtExamID.BorderThickness = 0;
            this.txtExamID.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.txtExamID.IconRight = global::Exam_Preparation_System.Properties.Resources.search;
            this.txtExamID.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtExamID.Location = new System.Drawing.Point(350, 182);
            this.txtExamID.Name = "txtExamID";
            this.txtExamID.PasswordChar = '\0';
            this.txtExamID.PlaceholderText = "Tìm kiếm theo Mã đề";
            this.txtExamID.SelectedText = "";
            this.txtExamID.ShadowDecoration.BorderRadius = 15;
            this.txtExamID.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.txtExamID.ShadowDecoration.Depth = 10;
            this.txtExamID.ShadowDecoration.Enabled = true;
            this.txtExamID.ShadowDecoration.Parent = this.txtExamID;
            this.txtExamID.Size = new System.Drawing.Size(294, 36);
            this.txtExamID.TabIndex = 17;
            this.txtExamID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExamID_KeyPress);
            this.txtExamID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExamID_KeyUp);
            // 
            // cmbSubject
            // 
            this.cmbSubject.BackColor = System.Drawing.Color.Transparent;
            this.cmbSubject.BorderRadius = 5;
            this.cmbSubject.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cmbSubject.BorderThickness = 0;
            this.cmbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSubject.FocusedState.Parent = this.cmbSubject;
            this.cmbSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cmbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSubject.HoverState.Parent = this.cmbSubject;
            this.cmbSubject.ItemHeight = 30;
            this.cmbSubject.ItemsAppearance.Parent = this.cmbSubject;
            this.cmbSubject.Location = new System.Drawing.Point(94, 182);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.ShadowDecoration.BorderRadius = 15;
            this.cmbSubject.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.cmbSubject.ShadowDecoration.Depth = 10;
            this.cmbSubject.ShadowDecoration.Enabled = true;
            this.cmbSubject.ShadowDecoration.Parent = this.cmbSubject;
            this.cmbSubject.Size = new System.Drawing.Size(238, 36);
            this.cmbSubject.TabIndex = 16;
            this.cmbSubject.SelectionChangeCommitted += new System.EventHandler(this.cmbSubject_SelectionChangeCommitted);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 186);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(89, 30);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Lọc Môn:";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.White;
            chartFont1.FontName = "Arial";
            this.chart.Legend.LabelFont = chartFont1;
            this.chart.Location = new System.Drawing.Point(665, 0);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(534, 218);
            this.chart.TabIndex = 21;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chart.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            this.chart.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chart.Tooltips.TitleFont = chartFont4;
            this.chart.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            this.chart.XAxes.Ticks = tick1;
            this.chart.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            this.chart.YAxes.Ticks = tick2;
            this.chart.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            this.chart.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            this.chart.ZAxes.Ticks = tick3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Neutraface 2", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lịch Sử Làm Bài";
            // 
            // FormViewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.txtExamID);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewHistory";
            this.Text = "Lịch sử luyện thi";
            this.Load += new System.EventHandler(this.FormViewHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtExamID;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSubject;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.Charts.WinForms.GunaChart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCorrect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcuteTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
    }
}