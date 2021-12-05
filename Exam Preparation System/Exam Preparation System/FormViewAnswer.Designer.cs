
namespace Exam_Preparation_System
{
    partial class FormViewAnswer
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
            this.pnlExamContainer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlExam = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblFullName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCorrectQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlExamContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlExamContainer
            // 
            this.pnlExamContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlExamContainer.Controls.Add(this.pnlExam);
            this.pnlExamContainer.FillColor = System.Drawing.Color.White;
            this.pnlExamContainer.Location = new System.Drawing.Point(1, 61);
            this.pnlExamContainer.Name = "pnlExamContainer";
            this.pnlExamContainer.Radius = 5;
            this.pnlExamContainer.ShadowColor = System.Drawing.Color.Black;
            this.pnlExamContainer.Size = new System.Drawing.Size(1152, 702);
            this.pnlExamContainer.TabIndex = 1;
            // 
            // pnlExam
            // 
            this.pnlExam.AutoScroll = true;
            this.pnlExam.Location = new System.Drawing.Point(12, 9);
            this.pnlExam.Name = "pnlExam";
            this.pnlExam.ShadowDecoration.Parent = this.pnlExam;
            this.pnlExam.Size = new System.Drawing.Size(1148, 688);
            this.pnlExam.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(534, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 27);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Đáp án";
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 10;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.DisabledState.Parent = this.btnBack;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(1009, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(136, 32);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Trở về ";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(12, 3);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(125, 22);
            this.lblFullName.TabIndex = 20;
            this.lblFullName.Text = "Họ tên thí sinh: ";
            // 
            // lblCorrectQuantity
            // 
            this.lblCorrectQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrectQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectQuantity.Location = new System.Drawing.Point(12, 33);
            this.lblCorrectQuantity.Name = "lblCorrectQuantity";
            this.lblCorrectQuantity.Size = new System.Drawing.Size(109, 22);
            this.lblCorrectQuantity.TabIndex = 21;
            this.lblCorrectQuantity.Text = "Số câu đúng: ";
            // 
            // FormViewAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1157, 770);
            this.Controls.Add(this.lblCorrectQuantity);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlExamContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewAnswer";
            this.Text = "FormViewAnswer";
            this.Load += new System.EventHandler(this.FormViewAnswer_Load);
            this.pnlExamContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlExamContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlExam;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCorrectQuantity;
    }
}