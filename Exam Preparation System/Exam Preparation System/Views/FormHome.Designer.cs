
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
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_gettingstarted = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 5;
            this.guna2PictureBox1.Image = global::Exam_Preparation_System.Properties.Resources.Illustration_1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(611, 112);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.BorderRadius = 5;
            this.guna2PictureBox1.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.guna2PictureBox1.ShadowDecoration.Depth = 10;
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(572, 340);
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
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
            this.btn_gettingstarted.ShadowDecoration.BorderRadius = 15;
            this.btn_gettingstarted.ShadowDecoration.Depth = 15;
            this.btn_gettingstarted.ShadowDecoration.Enabled = true;
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
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btn_gettingstarted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btn_gettingstarted;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}