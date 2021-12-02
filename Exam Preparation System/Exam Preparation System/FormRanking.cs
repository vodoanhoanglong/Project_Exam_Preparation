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
    public partial class FormRanking : Form
    {
        private ContextDB context = Program.context;
        private List<EXAMRESULT> listTopRanking = new List<EXAMRESULT>();
        public FormRanking()
        {
            InitializeComponent();
        }

        private void FormStatistical_Load(object sender, EventArgs e)
        {

            transition.HideSync(ptbCrown);
            transition.HideSync(shapeOne);
            transition.HideSync(shapeTwo);
            transition.HideSync(shapeThree);

            transition.TimeStep = 0.01F;
            transition.ShowSync(ptbCrown);
            transition.ShowSync(shapeOne);
            guna2HtmlLabel1.Visible = true;
            guna2HtmlLabel9.Visible = true;
            guna2HtmlLabel10.Visible = true;
            transition.ShowSync(shapeTwo);
            guna2HtmlLabel2.Visible = true;
            guna2HtmlLabel7.Visible = true;
            guna2HtmlLabel8.Visible = true;
            transition.ShowSync(shapeThree);
            guna2HtmlLabel3.Visible = true;
            guna2HtmlLabel11.Visible = true;
            guna2HtmlLabel12.Visible = true;

        }
        private void loadData()
        {
            var query = context.EXAMRESULTS.Where(x => x.ExamQuestionID == 1).ToList();
                        
            query.ForEach(x =>
            {
                query.ForEach(person =>
                {

                });
            });
        }
    }
}
