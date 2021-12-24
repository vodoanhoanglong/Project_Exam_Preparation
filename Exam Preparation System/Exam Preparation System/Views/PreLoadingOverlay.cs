using Exam_Preparation_System.Models;
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

namespace Exam_Preparation_System.Views
{
    public partial class PreLoadingOverlay : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nRightRect,
                int nTopRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );
        private string UserName { get; set; }
        private string Password { get; set; }
        public PreLoadingOverlay()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public PreLoadingOverlay(string userName, string password)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.UserName = userName;
            this.Password = password;  
        }
        public bool checkAccount(string username, string password)
        {
            USER user = Program.context.USERS.FirstOrDefault(u => u.UserID == username && u.Password == password);
            if (user == null)
                return false;
            FormLogin.info = user;

            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (!checkAccount(this.UserName,this.Password))
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();         
                }
                else
                {
                    timer1.Enabled = false;
                    FormMainMenu menu = new FormMainMenu();
                    menu.Show();
                    this.Visible = false;
                    FormLogin.instance.Visible = false;
                }          
        }

    }
}
