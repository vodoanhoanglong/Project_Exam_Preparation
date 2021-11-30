
namespace Exam_Preparation_System
{
    partial class FormStatisticalOfAdmin
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
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.cmbExamID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // cartesianChart
            // 
            this.cartesianChart.Location = new System.Drawing.Point(113, 190);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(959, 541);
            this.cartesianChart.TabIndex = 0;
            this.cartesianChart.Text = "cartesianChart";
            // 
            // cmbExamID
            // 
            this.cmbExamID.BackColor = System.Drawing.Color.Transparent;
            this.cmbExamID.BorderRadius = 10;
            this.cmbExamID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cmbExamID.BorderThickness = 2;
            this.cmbExamID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbExamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExamID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbExamID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbExamID.FocusedState.Parent = this.cmbExamID;
            this.cmbExamID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbExamID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbExamID.HoverState.Parent = this.cmbExamID;
            this.cmbExamID.ItemHeight = 30;
            this.cmbExamID.ItemsAppearance.Parent = this.cmbExamID;
            this.cmbExamID.Location = new System.Drawing.Point(437, 31);
            this.cmbExamID.Name = "cmbExamID";
            this.cmbExamID.ShadowDecoration.Parent = this.cmbExamID;
            this.cmbExamID.Size = new System.Drawing.Size(326, 36);
            this.cmbExamID.TabIndex = 12;
            this.cmbExamID.SelectedIndexChanged += new System.EventHandler(this.cmbExamID_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(280, 35);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(137, 27);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Lọc theo mã đề";
            // 
            // FormStatisticalOfAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1173, 770);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cmbExamID);
            this.Controls.Add(this.cartesianChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStatisticalOfAdmin";
            this.Text = "Thống kê số lượng thi";
            this.Load += new System.EventHandler(this.FormStatisticalOfAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private Guna.UI2.WinForms.Guna2ComboBox cmbExamID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}