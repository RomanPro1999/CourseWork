using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizeSystemWindowsForms.Models;
using QuizeSystemWindowsForms.Controllers;

namespace QuizeSystemWindowsForms.Views
{
    public partial class Results : Form
    {
        UserModel user;
        TestModel test;
        int score;
        public Results(UserModel user,TestModel test,int score)
        {
            this.user = user;
            this.test = test;
            this.score = score;
            InitializeComponent();
        }

        private void Rsults_Load(object sender, EventArgs e)
        {
            this.labelTestName.Text = test.Name;
            this.labelUserName.Text = user.Name + " " + user.Surname;
            this.labelScore.Text = score.ToString();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            UserStartWindow userStartWindow = new UserStartWindow(user);
            userStartWindow.Show();
        }

        private void buttonRetakeTest_Click(object sender, EventArgs e)
        {
            TestController testController = new TestController();
            List<QuestionModel> questions = testController.LoadQuestions(test);
            CurrentQuestionWindow currentQuestionWindow = new CurrentQuestionWindow(user, test, questions, 0);
            this.Close();
            currentQuestionWindow.Show();
        }
    }
}
