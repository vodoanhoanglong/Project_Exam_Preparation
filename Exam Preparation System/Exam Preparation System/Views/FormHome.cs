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
    public partial class FormHome : Form
    {
      
        public FormHome()
        {
            InitializeComponent();
           
        }

        private void btn_gettingstarted_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormMainMenu.instance.activateButton(FormMainMenu.instance.btnExamManager);
            if (FormLogin.info.UserID == FormMainMenu.admin)
            {
                FormMainMenu.instance.openChildForm(new FormCreateExam());
            }
            else
            {
                FormMainMenu.instance.openChildForm(new FormViewExam());
            }
        }
    }
}
