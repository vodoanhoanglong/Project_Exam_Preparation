
namespace Exam_Preparation_System
{
    partial class FormExamPreparation
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
            this.components = new System.ComponentModel.Container();
            this.pnlExamContainer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlExam = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFinished = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTimeExam = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblCodeExam = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFullName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlExamContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlExamContainer
            // 
            this.pnlExamContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlExamContainer.Controls.Add(this.pnlExam);
            this.pnlExamContainer.FillColor = System.Drawing.Color.White;
            this.pnlExamContainer.Location = new System.Drawing.Point(0, 130);
            this.pnlExamContainer.Name = "pnlExamContainer";
            this.pnlExamContainer.Radius = 3;
            this.pnlExamContainer.ShadowColor = System.Drawing.Color.Black;
            this.pnlExamContainer.ShadowShift = 0;
            this.pnlExamContainer.Size = new System.Drawing.Size(1200, 482);
            this.pnlExamContainer.TabIndex = 0;
            // 
            // pnlExam
            // 
            this.pnlExam.AutoScroll = true;
            this.pnlExam.Location = new System.Drawing.Point(0, 0);
            this.pnlExam.Name = "pnlExam";
            this.pnlExam.ShadowDecoration.Parent = this.pnlExam;
            this.pnlExam.Size = new System.Drawing.Size(1201, 482);
            this.pnlExam.TabIndex = 0;
            // 
            // btnFinished
            // 
            this.btnFinished.BorderRadius = 10;
            this.btnFinished.CheckedState.Parent = this.btnFinished;
            this.btnFinished.CustomImages.Parent = this.btnFinished;
            this.btnFinished.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinished.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinished.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinished.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinished.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinished.DisabledState.Parent = this.btnFinished;
            this.btnFinished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinished.ForeColor = System.Drawing.Color.White;
            this.btnFinished.HoverState.Parent = this.btnFinished;
            this.btnFinished.Location = new System.Drawing.Point(1025, 78);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.ShadowDecoration.Parent = this.btnFinished;
            this.btnFinished.Size = new System.Drawing.Size(136, 32);
            this.btnFinished.TabIndex = 15;
            this.btnFinished.Text = "Nộp bài";
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // txtTimeExam
            // 
            this.txtTimeExam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTimeExam.BorderRadius = 4;
            this.txtTimeExam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeExam.DefaultText = "00:00:00";
            this.txtTimeExam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimeExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimeExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeExam.DisabledState.Parent = this.txtTimeExam;
            this.txtTimeExam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeExam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeExam.FocusedState.Parent = this.txtTimeExam;
            this.txtTimeExam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtTimeExam.ForeColor = System.Drawing.Color.DimGray;
            this.txtTimeExam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeExam.HoverState.Parent = this.txtTimeExam;
            this.txtTimeExam.Location = new System.Drawing.Point(1025, 14);
            this.txtTimeExam.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeExam.MaxLength = 8;
            this.txtTimeExam.Name = "txtTimeExam";
            this.txtTimeExam.PasswordChar = '\0';
            this.txtTimeExam.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTimeExam.PlaceholderText = "";
            this.txtTimeExam.SelectedText = "";
            this.txtTimeExam.SelectionStart = 8;
            this.txtTimeExam.ShadowDecoration.Parent = this.txtTimeExam;
            this.txtTimeExam.Size = new System.Drawing.Size(136, 49);
            this.txtTimeExam.TabIndex = 16;
            this.txtTimeExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblCodeExam
            // 
            this.lblCodeExam.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeExam.Font = new System.Drawing.Font("SVN-Neutraface 2", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeExam.Location = new System.Drawing.Point(532, 12);
            this.lblCodeExam.Name = "lblCodeExam";
            this.lblCodeExam.Size = new System.Drawing.Size(96, 36);
            this.lblCodeExam.TabIndex = 17;
            this.lblCodeExam.Text = "Bài Làm";
            // 
            // lblSubject
            // 
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(12, 78);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(67, 22);
            this.lblSubject.TabIndex = 18;
            this.lblSubject.Text = "Môn thi: ";
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(12, 41);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(125, 22);
            this.lblFullName.TabIndex = 19;
            this.lblFullName.Text = "Họ tên thí sinh: ";
            // 
            // FormExamPreparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 614);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblCodeExam);
            this.Controls.Add(this.txtTimeExam);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.pnlExamContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExamPreparation";
            this.Text = "Luyện thi";
            this.Load += new System.EventHandler(this.FormExamPreparation_Load);
            this.pnlExamContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlExamContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlExam;
        private Guna.UI2.WinForms.Guna2GradientButton btnFinished;
        private Guna.UI2.WinForms.Guna2TextBox txtTimeExam;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCodeExam;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubject;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullName;
    }
}