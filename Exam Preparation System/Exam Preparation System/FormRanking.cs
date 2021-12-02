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
        private List<TopRanking> listRanking = new List<TopRanking>();
        private string currUsesID = null;
        public FormRanking()
        {
            InitializeComponent();
        }

        private void FormStatistical_Load(object sender, EventArgs e)
        {
            var query = context.EXAMQUESTIONS.Select(x => x.ExamQuestionID).ToList();
            cmbExamID.ValueMember = "ExamQuestionID";
            cmbExamID.DisplayMember = "ExamQuestionID";
            cmbExamID.DataSource = query;


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

        private double toTotalSeconds(string[] timeValue)
        {
            double h, m, s;
            h = Convert.ToInt32(timeValue[0]) * 3600;
            m = Convert.ToInt32(timeValue[1]) * 60;
            s = Convert.ToInt32(timeValue[2]);
            return h + m + s;
        }

        private double calculatorTime(string totalTime, string timeComplete)
        {
            double totalSeconds = toTotalSeconds(totalTime.Split(':'));
            double totalCompleteSeconds = toTotalSeconds(timeComplete.Split(':'));
            return (totalSeconds - totalCompleteSeconds) / totalSeconds;
        }

        private double calculatorQuestion(double totalQuestion, double totalCorrectQuestion)
        {
            return totalCorrectQuestion / totalQuestion;
        }

        private double calculatorCriteria(int totalQuestion, int totalCorrectQuestion, 
            string totalTime, string timeComplete)
        {
            return calculatorQuestion(Convert.ToDouble(totalQuestion), Convert.ToDouble(totalCorrectQuestion))
                + calculatorTime(totalTime, timeComplete);
        }

        private void loadData()
        {
            int examID = Convert.ToInt32(cmbExamID.SelectedValue);
            // error null exception must join two table before
            var result =  from er in context.EXAMRESULTS 
                     join u in context.USERS on er.UserID equals u.UserID
                     where er.ExamQuestionID == examID
                     select new 
                     { 
                         er.ExamQuestionID, 
                         er.UserID, 
                         u.FullName, 
                         er.TimeComplete, 
                         er.EXAMQUESTION.ExecutionTime , 
                         er.EXAMQUESTION.Quantity, 
                         er.QuantityCorrect 
                     };
            // error is gone
            var query = result
                .OrderBy(x => x.UserID)
                .AsEnumerable()
                .Select(x => new TopRanking
                (
                    x.UserID,
                    x.FullName,
                    x.TimeComplete,
                    x.Quantity,
                    x.QuantityCorrect,
                    calculatorCriteria(x.Quantity, x.QuantityCorrect, x.ExecutionTime, x.TimeComplete)
                ));

            query.ToList().ForEach(x =>
            {
                if (currUsesID != x.UserID)
                    currUsesID = x.UserID;
                else return;
                var max = query.Where(z => z.UserID == currUsesID).Max(z => z.Criteria);
                listRanking.Add(query.Where(z => z.UserID == currUsesID).First(z => z.Criteria == max));
            });
            
            listRanking.Sort((obj1, obj2) => obj2.Criteria.CompareTo(obj1.Criteria));
            listRanking.Take(5).ToList().ForEach(x => MessageBox.Show(x.FullName + "\n" + x.Criteria.ToString()));
        }

        private void cmbExamID_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
    public class TopRanking
    {
        

        public TopRanking(string userID, string fullName, string timeComplete, int quantity, int quantityCorrect, double criteria)
        {
            UserID = userID;
            FullName = fullName;
            TimeComplete = timeComplete;
            Quantity = quantity;
            QuantityCorrect = quantityCorrect;
            Criteria = criteria;
        }

        public string UserID { get; set; }
        public string FullName { get; set; }
        public string TimeComplete { get; set; }
        public int Quantity { get; set; }
        public int QuantityCorrect { get; set; }
        public double Criteria { get; set; }
    }
}
