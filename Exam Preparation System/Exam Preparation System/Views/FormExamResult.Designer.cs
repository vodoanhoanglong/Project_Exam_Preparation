
namespace Exam_Preparation_System
{
    partial class FormExamResult
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
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.progressBar = new CircularProgressBar.CircularProgressBar();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCodeExam = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFullName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPoint = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnViewAnswer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // ShadowForm
            // 
            this.ShadowForm.BorderRadius = 20;
            this.ShadowForm.ShadowColor = System.Drawing.Color.DarkGray;
            this.ShadowForm.TargetForm = this;
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // progressBar
            // 
            this.progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar.AnimationSpeed = 500;
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.progressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.progressBar.InnerMargin = 2;
            this.progressBar.InnerWidth = -1;
            this.progressBar.Location = new System.Drawing.Point(298, 39);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.progressBar.OuterMargin = -25;
            this.progressBar.OuterWidth = 26;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressBar.ProgressWidth = 10;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBar.Size = new System.Drawing.Size(194, 185);
            this.progressBar.StartAngle = 270;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar.SubscriptText = "";
            this.progressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar.SuperscriptText = "";
            this.progressBar.TabIndex = 0;
            this.progressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBar.Value = 68;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(263, 283);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(264, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Số câu đúng / Tổng số câu";
            // 
            // lblCodeExam
            // 
            this.lblCodeExam.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblCodeExam.Location = new System.Drawing.Point(12, 6);
            this.lblCodeExam.Name = "lblCodeExam";
            this.lblCodeExam.Size = new System.Drawing.Size(3, 2);
            this.lblCodeExam.TabIndex = 2;
            this.lblCodeExam.Text = null;
            // 
            // lblSubject
            // 
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblSubject.Location = new System.Drawing.Point(12, 39);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(3, 2);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = null;
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblFullName.Location = new System.Drawing.Point(322, 250);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(148, 27);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Họ tên thí sinh:  ";
            // 
            // lblPoint
            // 
            this.lblPoint.BackColor = System.Drawing.Color.Transparent;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblPoint.Location = new System.Drawing.Point(298, 316);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(88, 27);
            this.lblPoint.TabIndex = 5;
            this.lblPoint.Text = "Điểm thi: ";
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
            this.btnBack.Location = new System.Drawing.Point(404, 356);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(136, 32);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Trở về ";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewAnswer
            // 
            this.btnViewAnswer.BorderRadius = 10;
            this.btnViewAnswer.CheckedState.Parent = this.btnViewAnswer;
            this.btnViewAnswer.CustomImages.Parent = this.btnViewAnswer;
            this.btnViewAnswer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAnswer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewAnswer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewAnswer.DisabledState.Parent = this.btnViewAnswer;
            this.btnViewAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewAnswer.ForeColor = System.Drawing.Color.White;
            this.btnViewAnswer.HoverState.Parent = this.btnViewAnswer;
            this.btnViewAnswer.Location = new System.Drawing.Point(234, 356);
            this.btnViewAnswer.Name = "btnViewAnswer";
            this.btnViewAnswer.ShadowDecoration.Parent = this.btnViewAnswer;
            this.btnViewAnswer.Size = new System.Drawing.Size(136, 32);
            this.btnViewAnswer.TabIndex = 18;
            this.btnViewAnswer.Text = "Xem đáp án";
            this.btnViewAnswer.Click += new System.EventHandler(this.btnViewAnswer_Click);
            // 
            // FormExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewAnswer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblCodeExam);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExamResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormExamResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private CircularProgressBar.CircularProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubject;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCodeExam;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPoint;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnViewAnswer;
    }
}