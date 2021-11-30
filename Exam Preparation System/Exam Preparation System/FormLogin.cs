using Exam_Preparation_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Preparation_System
{
    public partial class FormLogin : Form
    {
        public static Form instance;
        public static USER info;
        ContextDB context = new ContextDB();
        public FormLogin()
        {
            InitializeComponent();
            instance = this;
            // center screen
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void gtsShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (gtsShowPassword.Checked)
                gtxtPassword.UseSystemPasswordChar = false;
            else
                gtxtPassword.UseSystemPasswordChar = true;
        }

        private void gtxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            gtxtUserName.MaxLength = 10;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;   
        }

        private Boolean checkAccount()
        {   
            try
            {
                USER user = context.USERS.Where(u => u.UserID == gtxtUserName.Text && u.Password == gtxtPassword.Text).FirstOrDefault();
                if (user == null)
                    return false;
                info = user;
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }



        private void gbtnLogin_Click(object sender, EventArgs e)
        {
            if (gtxtUserName.Text == "" || gtxtPassword.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else if (!checkAccount())
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
            else
            {
                FormMainMenu menu = new FormMainMenu();
                menu.Show();
                this.Visible = false;
            }
        }
    }
}
