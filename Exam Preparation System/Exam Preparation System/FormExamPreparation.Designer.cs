
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
            this.pnlExamContainer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlExam = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFinished = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlExamContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlExamContainer
            // 
            this.pnlExamContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlExamContainer.Controls.Add(this.pnlExam);
            this.pnlExamContainer.FillColor = System.Drawing.Color.White;
            this.pnlExamContainer.Location = new System.Drawing.Point(1, 130);
            this.pnlExamContainer.Name = "pnlExamContainer";
            this.pnlExamContainer.Radius = 5;
            this.pnlExamContainer.ShadowColor = System.Drawing.Color.Black;
            this.pnlExamContainer.Size = new System.Drawing.Size(1171, 677);
            this.pnlExamContainer.TabIndex = 0;
            // 
            // pnlExam
            // 
            this.pnlExam.AutoScroll = true;
            this.pnlExam.Location = new System.Drawing.Point(12, 9);
            this.pnlExam.Name = "pnlExam";
            this.pnlExam.ShadowDecoration.Parent = this.pnlExam;
            this.pnlExam.Size = new System.Drawing.Size(1148, 658);
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
            this.btnFinished.Location = new System.Drawing.Point(1025, 71);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.ShadowDecoration.Parent = this.btnFinished;
            this.btnFinished.Size = new System.Drawing.Size(136, 32);
            this.btnFinished.TabIndex = 15;
            this.btnFinished.Text = "Nộp bài";
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // FormExamPreparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1173, 809);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.pnlExamContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExamPreparation";
            this.Text = "FormExamPreparation";
            this.Load += new System.EventHandler(this.FormExamPreparation_Load);
            this.pnlExamContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlExamContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlExam;
        private Guna.UI2.WinForms.Guna2GradientButton btnFinished;
    }
}