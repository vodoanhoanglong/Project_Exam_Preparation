using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Preparation_System
{

    public partial class FormMainMenu : Form
    {
        public static FormMainMenu instance;

        private const string admin = "6051071067";
        private Guna2Button currBtn;
        private Panel leftBorderBtn, currSubBtn;
        private Form currChildForm;

        private System.Drawing.Bitmap home = global::Exam_Preparation_System.Properties.Resources.home;
        private System.Drawing.Bitmap warehouse = global::Exam_Preparation_System.Properties.Resources.warehouse;
        private System.Drawing.Bitmap exam = global::Exam_Preparation_System.Properties.Resources.exam;
        private System.Drawing.Bitmap lineChart = global::Exam_Preparation_System.Properties.Resources.line_chart;

        private System.Drawing.Bitmap homeColor = global::Exam_Preparation_System.Properties.Resources.home_color;
        private System.Drawing.Bitmap warehouseColor = global::Exam_Preparation_System.Properties.Resources.warehouse_color;
        private System.Drawing.Bitmap examColor = global::Exam_Preparation_System.Properties.Resources.exam_color;
        private System.Drawing.Bitmap lineChartColor = global::Exam_Preparation_System.Properties.Resources.line_chart_color;

        private System.Drawing.Bitmap userIcon = global::Exam_Preparation_System.Properties.Resources.user;
        public FormMainMenu()
        {
            InitializeComponent();
            instance = this;

            // center screen
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            currSubBtn = panelSubMenu;

            /*if (FormLogin.info.UserID != admin)
            {
                panelSubMenu.Visible = false;
                currSubBtn = panelSubMenuStudent;
                btnChart.Visible = false;
                btnWarehouse.Visible = false;
            }
            else panelSubMenuStudent.Visible = false;*/

            currSubBtn.Visible = false;
            panelSubMenuStudent.Visible = false;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);


            openChildForm(new FormHome());
        }


        public void openChildForm(Form childForm)
        {
            if (currChildForm != null)
                currChildForm.Close();
            currChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(24, 161, 251);
        }

        private void setColorImage(string name)
        {
            bool checkColor = currBtn.ForeColor.ToArgb().Equals(Color.Black.ToArgb());
            switch (name)
            {
                case "btnHome":
                    currBtn.Image = checkColor ? homeColor : home;
                    break;
                case "btnWarehouse":
                    currBtn.Image = checkColor ? warehouseColor : warehouse;
                    break;
                case "btnExamManager":
                    currBtn.Image = checkColor ? examColor : exam;
                    break;
                default:
                    currBtn.Image = checkColor ? lineChartColor : lineChart;
                    break;
            }
        }

        private void activateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();
                currBtn = (Guna2Button)senderBtn;
                if (currBtn.Text == "Thi trực tuyến")
                    currSubBtn.Visible = true;

                setColorImage(currBtn.Name);
                currBtn.FillColor = Color.FromArgb(239, 242, 249);
                currBtn.ForeColor = color;
                iconCurrChildForm.Image = currBtn.Image;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currBtn.Location.Y);
                leftBorderBtn.Size = new Size(5,45);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void disableButton()
        {
            if (currBtn != null)
            {
                setColorImage(currBtn.Name);
                currBtn.FillColor = Color.White;
                currBtn.ForeColor = Color.Black;
                currSubBtn.Visible = false;
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color1);
            openChildForm(new FormHome());
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
            openChildForm(new FormWarehouse());
        }

        private void btnExamManager_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color3);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color4);
        }

        // Drag Form with pannel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        /*private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }*/



        private void btnCreateExam_Click(object sender, EventArgs e)
        {   
            currSubBtn.Visible = false;
            openChildForm(new FormCreateExam());
        }

        private void btnListExam_Click(object sender, EventArgs e)
        {
            currSubBtn.Visible = false;
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            currSubBtn.Visible = false;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            currSubBtn.Visible = false;
        }


        private void btnExercise_Click(object sender, EventArgs e)
        {
            currSubBtn.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            currSubBtn.Visible = false;
        }

        private void btnJoinExam_Click(object sender, EventArgs e)
        {
            currSubBtn.Visible = false;
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            currSubBtn.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin.instance.Visible = true;
            this.Dispose();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            currSubBtn.Visible = false;
            iconCurrChildForm.Image = userIcon;
            openChildForm(new FormProfile());
        }
    }
}
