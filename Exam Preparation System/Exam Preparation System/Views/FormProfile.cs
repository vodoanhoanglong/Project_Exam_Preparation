using Exam_Preparation_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Preparation_System
{
    public partial class FormProfile : Form
    {
        private ContextDB context = Program.context;
        String kiemTra = FormLogin.info.UserID;
        USER infoUser = FormLogin.info;
        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            PanelEditPass.Visible = false;
            txtUserID.Text = infoUser.UserID;
            txtFullName.Text = infoUser.FullName;
            DateTime dateTime = infoUser.BirthDay;
            String date = String.Format("{0: dd/MM/yyyy}", dateTime);
            txtBirthDay.Text = date;
            Boolean sex = infoUser.Sex;
            txtSex.Text = sex ? "Nam" : "Nữ";
            txtPhone.Text = infoUser.Phone;
        }

        private void btnEditPass_Click(object sender, EventArgs e)
        {
            PanelEditPass.Visible = true;
            txtPasswordCu.Text = infoUser.Password;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(txtPassWordMoi.Text == "")
                MessageBox.Show("Vui lòng nhập mật khẩu mới!!!");
            else if(txtNhaplaiPassWord.Text == "")
                MessageBox.Show("Vui lòng nhập lại mật khẩu!!!");
            else if (txtPassWordMoi.Text != txtNhaplaiPassWord.Text)
                MessageBox.Show("Mật khẩu không trùng khớp!!!");
            else if (txtPasswordCu.Text == txtPassWordMoi.Text)
                MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ!!!");
            else
            {
                USER user = context.USERS.Where(p => p.UserID == infoUser.UserID).FirstOrDefault();
                user.Password = txtPassWordMoi.Text;
                MessageBox.Show("Đổi mật khẩu thành công!!!");
                context.SaveChanges();
                infoUser = user;
                txtPassWordMoi.Text = "";
                txtNhaplaiPassWord.Text = "";
                PanelEditPass.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            PanelEditPass.Visible = false;
        }
    }
}
