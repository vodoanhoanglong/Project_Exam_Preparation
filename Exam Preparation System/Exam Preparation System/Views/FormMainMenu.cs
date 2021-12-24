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

        private const string admin = "6051071012";
        private Guna2Button currBtn;
        private Panel leftBorderBtn;
        private Form currChildForm;

        private Bitmap userIcon = Properties.Resources.user;

        public FormMainMenu()
        {
            InitializeComponent();
            instance = this;

            // center screen
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            btnExamManager.Text = "Tạo đề thi";
            panelSubMenuStudent.Visible = false;
            if (FormLogin.info.UserID != admin)
            {
                btnWarehouse.Visible = false;
                btnChart.Visible = false;
                btnExamManager.Text = "Luyện tập";
            }
            else btnRanking.Visible = false;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            // constructor home page
            openChildForm(new FormHome());

            currBtn = btnHome;
            leftBorderBtn.Location = new Point(0, currBtn.Location.Y);
            leftBorderBtn.Size = new Size(5, 45);
            leftBorderBtn.BackColor = currBtn.CheckedState.ForeColor;
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();

            currBtn.FillColor = Color.FromArgb(239, 242, 249);
            currBtn.Checked = true;
            iconCurrChildForm.Image = currBtn.CheckedState.Image;
        }


        public void openChildForm(Form childForm)
        {
            if (currChildForm != null)
                currChildForm.Close();
            currChildForm = childForm;
            lblTitle.Text = childForm.Text;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void activateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                disableButton();
                currBtn = (Guna2Button)senderBtn;
                if (currBtn.Text == "Luyện tập")
                    lblTitle.Text = "Luyện tập";
                currBtn.FillColor = Color.FromArgb(239, 242, 249);
                currBtn.Checked = true;
                iconCurrChildForm.Image = currBtn.CheckedState.Image;

                leftBorderBtn.Location = new Point(0, currBtn.Location.Y);
                leftBorderBtn.Size = new Size(5, 45);
                leftBorderBtn.BackColor = currBtn.CheckedState.ForeColor;
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void disableButton()
        {
            if (currBtn != null)
            {
                currBtn.FillColor = Color.White;
                currBtn.ForeColor = Color.Black;
                currBtn.Checked = false;
                panelSubMenuStudent.Visible = false;

            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openChildForm(new FormHome());
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openChildForm(new FormWarehouse());
        }

        private void btnExamManager_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            if (FormLogin.info.UserID != admin)
                panelSubMenuStudent.Visible = true;
            else openChildForm(new FormCreateExam());
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openChildForm(new FormStatistical());
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openChildForm(new FormRanking());
        }
        private void btnExercise_Click(object sender, EventArgs e)
        {
            panelSubMenuStudent.Visible = false;
            openChildForm(new FormViewExam());
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            panelSubMenuStudent.Visible = false;
            openChildForm(new FormViewHistory());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin.instance.Visible = true;
            this.Dispose();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            panelSubMenuStudent.Visible = false;
            iconCurrChildForm.Image = userIcon;
            openChildForm(new FormProfile());
        }

        private void controlBox_Click(object sender, EventArgs e)
        {
            FormLogin.instance.Close();
        }

    }
}
