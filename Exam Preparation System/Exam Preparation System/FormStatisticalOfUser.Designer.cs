
namespace Exam_Preparation_System
{
    partial class FormStatisticalOfUser
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
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(251, 170);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(665, 424);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "pieChart";
            // 
            // FormStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1189, 809);
            this.Controls.Add(this.pieChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStatistical";
            this.Text = "Thống kê câu hỏi";
            this.Load += new System.EventHandler(this.FormStatistical_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart;
    }
}