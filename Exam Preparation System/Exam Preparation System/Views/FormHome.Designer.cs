
namespace Exam_Preparation_System
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gettingstarted = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SVN-Neutraface 2", 50.24999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 218);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thống luyện thi trắc nghiệm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(611, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(22, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(583, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giải pháp hỗ trợ học sinh ôn tập và cũng cố kiến thức ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_gettingstarted
            // 
            this.btn_gettingstarted.BackColor = System.Drawing.Color.Transparent;
            this.btn_gettingstarted.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_gettingstarted.CheckedState.Parent = this.btn_gettingstarted;
            this.btn_gettingstarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gettingstarted.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_gettingstarted.HoverState.ImageSize = new System.Drawing.Size(240, 55);
            this.btn_gettingstarted.HoverState.Parent = this.btn_gettingstarted;
            this.btn_gettingstarted.Image = ((System.Drawing.Image)(resources.GetObject("btn_gettingstarted.Image")));
            this.btn_gettingstarted.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_gettingstarted.ImageRotate = 0F;
            this.btn_gettingstarted.ImageSize = new System.Drawing.Size(240, 55);
            this.btn_gettingstarted.Location = new System.Drawing.Point(27, 397);
            this.btn_gettingstarted.Name = "btn_gettingstarted";
            this.btn_gettingstarted.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_gettingstarted.PressedState.ImageSize = new System.Drawing.Size(240, 55);
            this.btn_gettingstarted.PressedState.Parent = this.btn_gettingstarted;
            this.btn_gettingstarted.ShadowDecoration.Parent = this.btn_gettingstarted;
            this.btn_gettingstarted.Size = new System.Drawing.Size(240, 55);
            this.btn_gettingstarted.TabIndex = 3;
            this.btn_gettingstarted.Click += new System.EventHandler(this.btn_gettingstarted_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1190, 555);
            this.Controls.Add(this.btn_gettingstarted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btn_gettingstarted;
    }
}