
namespace Exam_Preparation_System
{
    partial class FormLogin
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.gtsShowPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.gbtnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gtxtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(499, 467);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(750, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(32, 25);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(788, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 25);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 6;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // gtsShowPassword
            // 
            this.gtsShowPassword.Animated = true;
            this.gtsShowPassword.CheckedState.BorderColor = System.Drawing.Color.White;
            this.gtsShowPassword.CheckedState.FillColor = System.Drawing.Color.White;
            this.gtsShowPassword.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(1)))), ((int)(((byte)(68)))));
            this.gtsShowPassword.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gtsShowPassword.CheckedState.Parent = this.gtsShowPassword;
            this.gtsShowPassword.Location = new System.Drawing.Point(549, 322);
            this.gtsShowPassword.Name = "gtsShowPassword";
            this.gtsShowPassword.ShadowDecoration.Parent = this.gtsShowPassword;
            this.gtsShowPassword.Size = new System.Drawing.Size(44, 20);
            this.gtsShowPassword.TabIndex = 4;
            this.gtsShowPassword.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.gtsShowPassword.UncheckedState.BorderThickness = 2;
            this.gtsShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gtsShowPassword.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.gtsShowPassword.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.gtsShowPassword.UncheckedState.Parent = this.gtsShowPassword;
            this.gtsShowPassword.CheckedChanged += new System.EventHandler(this.gtsShowPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(598, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Show Password";
            // 
            // gbtnLogin
            // 
            this.gbtnLogin.Animated = true;
            this.gbtnLogin.AutoRoundedCorners = true;
            this.gbtnLogin.BorderRadius = 16;
            this.gbtnLogin.CheckedState.Parent = this.gbtnLogin;
            this.gbtnLogin.CustomImages.Parent = this.gbtnLogin;
            this.gbtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnLogin.DisabledState.Parent = this.gbtnLogin;
            this.gbtnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(3)))), ((int)(((byte)(121)))));
            this.gbtnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.gbtnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbtnLogin.ForeColor = System.Drawing.Color.White;
            this.gbtnLogin.HoverState.Parent = this.gbtnLogin;
            this.gbtnLogin.Location = new System.Drawing.Point(549, 372);
            this.gbtnLogin.Name = "gbtnLogin";
            this.gbtnLogin.ShadowDecoration.Parent = this.gbtnLogin;
            this.gbtnLogin.Size = new System.Drawing.Size(243, 35);
            this.gbtnLogin.TabIndex = 7;
            this.gbtnLogin.Text = "LOGIN";
            this.gbtnLogin.Click += new System.EventHandler(this.gbtnLogin_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Exam_Preparation_System.Properties.Resources.BackgroundLogin;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = null;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-316, -31);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(814, 515);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Exam_Preparation_System.Properties.Resources.utc2icon;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(600, 58);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(141, 110);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // gtxtUserName
            // 
            this.gtxtUserName.Animated = true;
            this.gtxtUserName.AutoRoundedCorners = true;
            this.gtxtUserName.BorderColor = System.Drawing.Color.White;
            this.gtxtUserName.BorderRadius = 17;
            this.gtxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtUserName.DefaultText = "";
            this.gtxtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUserName.DisabledState.Parent = this.gtxtUserName;
            this.gtxtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gtxtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtUserName.FocusedState.Parent = this.gtxtUserName;
            this.gtxtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtUserName.ForeColor = System.Drawing.Color.White;
            this.gtxtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtUserName.HoverState.Parent = this.gtxtUserName;
            this.gtxtUserName.IconLeft = global::Exam_Preparation_System.Properties.Resources.username;
            this.gtxtUserName.Location = new System.Drawing.Point(549, 201);
            this.gtxtUserName.Name = "gtxtUserName";
            this.gtxtUserName.PasswordChar = '\0';
            this.gtxtUserName.PlaceholderText = "UserName";
            this.gtxtUserName.SelectedText = "";
            this.gtxtUserName.ShadowDecoration.Parent = this.gtxtUserName;
            this.gtxtUserName.Size = new System.Drawing.Size(243, 36);
            this.gtxtUserName.TabIndex = 2;
            this.gtxtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtxtUserName_KeyPress);
            // 
            // gtxtPassword
            // 
            this.gtxtPassword.Animated = true;
            this.gtxtPassword.AutoRoundedCorners = true;
            this.gtxtPassword.BorderColor = System.Drawing.Color.White;
            this.gtxtPassword.BorderRadius = 17;
            this.gtxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtPassword.DefaultText = "";
            this.gtxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPassword.DisabledState.Parent = this.gtxtPassword;
            this.gtxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.gtxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtPassword.FocusedState.Parent = this.gtxtPassword;
            this.gtxtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtPassword.ForeColor = System.Drawing.Color.White;
            this.gtxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtPassword.HoverState.Parent = this.gtxtPassword;
            this.gtxtPassword.IconLeft = global::Exam_Preparation_System.Properties.Resources._lock;
            this.gtxtPassword.Location = new System.Drawing.Point(549, 259);
            this.gtxtPassword.Name = "gtxtPassword";
            this.gtxtPassword.PasswordChar = '\0';
            this.gtxtPassword.PlaceholderText = "Password";
            this.gtxtPassword.SelectedText = "";
            this.gtxtPassword.ShadowDecoration.Parent = this.gtxtPassword;
            this.gtxtPassword.Size = new System.Drawing.Size(243, 36);
            this.gtxtPassword.TabIndex = 3;
            this.gtxtPassword.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(832, 467);
            this.Controls.Add(this.gbtnLogin);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.gtxtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gtxtPassword);
            this.Controls.Add(this.gtsShowPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch gtsShowPassword;
        private Guna.UI2.WinForms.Guna2TextBox gtxtPassword;
        private Guna.UI2.WinForms.Guna2TextBox gtxtUserName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton gbtnLogin;
    }
}