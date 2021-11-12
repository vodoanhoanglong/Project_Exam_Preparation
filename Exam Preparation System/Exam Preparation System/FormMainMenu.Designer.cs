
namespace Exam_Preparation_System
{
    partial class FormMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.iconCurrChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnChart = new FontAwesome.Sharp.IconButton();
            this.btnExamManager = new FontAwesome.Sharp.IconButton();
            this.btnExam = new FontAwesome.Sharp.IconButton();
            this.btnExercise = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.materialDivider1);
            this.panelMenu.Controls.Add(this.btnChart);
            this.panelMenu.Controls.Add(this.btnExamManager);
            this.panelMenu.Controls.Add(this.btnExam);
            this.panelMenu.Controls.Add(this.btnExercise);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(3, 24);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 997);
            this.panelMenu.TabIndex = 0;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Black;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.Location = new System.Drawing.Point(0, 985);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(220, 12);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 61);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(87, 17);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(69, 25);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "UTC2";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.iconCurrChildForm);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(223, 24);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1214, 61);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(62, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Home";
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(223, 85);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1214, 936);
            this.panelContent.TabIndex = 2;
            // 
            // iconCurrChildForm
            // 
            this.iconCurrChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.iconCurrChildForm.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.iconCurrChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrChildForm.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconCurrChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrChildForm.Location = new System.Drawing.Point(15, 17);
            this.iconCurrChildForm.Name = "iconCurrChildForm";
            this.iconCurrChildForm.Size = new System.Drawing.Size(41, 32);
            this.iconCurrChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCurrChildForm.TabIndex = 0;
            this.iconCurrChildForm.TabStop = false;
            // 
            // btnChart
            // 
            this.btnChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.Color.White;
            this.btnChart.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnChart.IconColor = System.Drawing.Color.White;
            this.btnChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChart.IconSize = 32;
            this.btnChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChart.Location = new System.Drawing.Point(0, 241);
            this.btnChart.Name = "btnChart";
            this.btnChart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChart.Size = new System.Drawing.Size(220, 60);
            this.btnChart.TabIndex = 5;
            this.btnChart.Text = "Phổ điểm";
            this.btnChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnExamManager
            // 
            this.btnExamManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExamManager.FlatAppearance.BorderSize = 0;
            this.btnExamManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamManager.ForeColor = System.Drawing.Color.White;
            this.btnExamManager.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.btnExamManager.IconColor = System.Drawing.Color.White;
            this.btnExamManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExamManager.IconSize = 32;
            this.btnExamManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamManager.Location = new System.Drawing.Point(0, 181);
            this.btnExamManager.Name = "btnExamManager";
            this.btnExamManager.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExamManager.Size = new System.Drawing.Size(220, 60);
            this.btnExamManager.TabIndex = 4;
            this.btnExamManager.Text = "Thi trực tuyến";
            this.btnExamManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExamManager.UseVisualStyleBackColor = true;
            this.btnExamManager.Click += new System.EventHandler(this.btnExamManager_Click);
            // 
            // btnExam
            // 
            this.btnExam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExam.FlatAppearance.BorderSize = 0;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.ForeColor = System.Drawing.Color.White;
            this.btnExam.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.btnExam.IconColor = System.Drawing.Color.White;
            this.btnExam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExam.IconSize = 32;
            this.btnExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExam.Location = new System.Drawing.Point(0, 121);
            this.btnExam.Name = "btnExam";
            this.btnExam.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExam.Size = new System.Drawing.Size(220, 60);
            this.btnExam.TabIndex = 2;
            this.btnExam.Text = "Kho đề";
            this.btnExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnExercise
            // 
            this.btnExercise.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExercise.FlatAppearance.BorderSize = 0;
            this.btnExercise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercise.ForeColor = System.Drawing.Color.White;
            this.btnExercise.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnExercise.IconColor = System.Drawing.Color.White;
            this.btnExercise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExercise.IconSize = 32;
            this.btnExercise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExercise.Location = new System.Drawing.Point(0, 61);
            this.btnExercise.Name = "btnExercise";
            this.btnExercise.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExercise.Size = new System.Drawing.Size(220, 60);
            this.btnExercise.TabIndex = 1;
            this.btnExercise.Text = "Trang chủ";
            this.btnExercise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExercise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExercise.UseVisualStyleBackColor = true;
            this.btnExercise.Click += new System.EventHandler(this.btnExercise_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exam_Preparation_System.Properties.Resources.utc2icon;
            this.pictureBox1.Location = new System.Drawing.Point(2, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "FormMainMenu";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống thi và luyện thi trực tuyến";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnExercise;
        private FontAwesome.Sharp.IconButton btnExamManager;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrChildForm;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnChart;
        private FontAwesome.Sharp.IconButton btnExam;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

