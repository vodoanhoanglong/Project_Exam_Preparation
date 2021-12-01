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
        private int totalQuestion, totalCorrect, totalWrong;
        private ContextDB context = Program.context;
        public FormRanking()
        {
            InitializeComponent();
        }

        private void FormStatistical_Load(object sender, EventArgs e)
        {

            transition.ShowSync(shapeOne);

            transition.ShowSync(shapeTwo);

            transition.ShowSync(shapeThree);
        }
        private void loadData()
        {
            
        }
    }
}
