using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class FormMainMenu : MaterialForm
    {
        private IconButton currBtn;
        private Panel leftBorderBtn;
        private Form currChildForm;

        public FormMainMenu()
        {
            InitializeComponent();
            // center screen
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
           
            reset();
            openChildForm(new FormHome());
        }


        private void openChildForm(Form childForm)
        {
            if(currChildForm != null)
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
            public static Color color4 = Color.FromArgb(24,161, 251);
            public static Color color5 = Color.FromArgb(249, 88, 155);
        }

        private void activateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();
                currBtn = (IconButton)senderBtn;
                if (currBtn.Text == "Thi trực tuyến")
                    panelSubmenu.Visible = true;
                currBtn.BackColor = Color.FromArgb(57, 56, 61);
                currBtn.ForeColor = color;
                currBtn.IconColor = color;


                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrChildForm.IconChar = currBtn.IconChar;
                iconCurrChildForm.IconColor = color;
            }
        }

        private void disableButton()
        {
            if(currBtn != null)
            {
                currBtn.BackColor = Color.FromArgb(50, 50, 50);
                currBtn.ForeColor = Color.White;
                currBtn.TextAlign = ContentAlignment.MiddleLeft;
                currBtn.IconColor = Color.White;
                currBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currBtn.ImageAlign = ContentAlignment.MiddleLeft;
                panelSubmenu.Visible = false;
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
        }

        private void btnExamManager_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color4);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color3);
        }

        // Drag Form with pannel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;
            panelSubmenu.Visible = false;
            iconCurrChildForm.IconChar = IconChar.Home;
            iconCurrChildForm.IconColor = RGBColors.color1;
            lblTitle.Text = "Trang chủ";
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = false;
         
        }

        private void btnListExam_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = false;

        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = false;

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = false;

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
