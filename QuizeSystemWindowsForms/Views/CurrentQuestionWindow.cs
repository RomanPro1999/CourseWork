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
    public partial class CurrentQuestionWindow : Form
    {
        List<QuestionModel> questions;
        int currentQuestion;
        TestModel test;
        int score;
        UserModel user;
        public CurrentQuestionWindow(UserModel user,TestModel test, List<QuestionModel> questions, int current)
        {
            this.test = test;
            this.user = user;
            this.questions = questions;
            this.currentQuestion = current;
            this.score = 0;
            InitializeComponent();
        }
        public CurrentQuestionWindow(UserModel user, TestModel test, List<QuestionModel> questions, int current,int score)
        {
            this.test = test;
            this.user = user;
            this.questions = questions;
            this.currentQuestion = current;
            this.score = score;
            InitializeComponent();
        }

        private void CurrentQuestion_Load(object sender, EventArgs e)
        {
            try
            {
                if ((currentQuestion - 1) == test.NumberOfQuestions)
                {
                    this.buttonSend.Text = "View results";
                }
                this.labelQuestion.Text = questions[currentQuestion].QuestionText;
                Random random = new Random();
                if (questions[currentQuestion].QuestionType == "Image")
                {
                    this.pictureBox1.Visible = true;
                    this.pictureBox1.Image = questions[currentQuestion].Image;
                }
                int choose = random.Next(4);
                switch (choose)
                {
                    case 0:
                        this.radioButton1.Text = questions[currentQuestion].Answers[0].Text;
                        this.radioButton2.Text = questions[currentQuestion].Choises[0].Text;
                        this.radioButton3.Text = questions[currentQuestion].Choises[1].Text;
                        this.radioButton4.Text = questions[currentQuestion].Choises[2].Text;
                        break;
                    case 1:
                        this.radioButton2.Text = questions[currentQuestion].Answers[0].Text;
                        this.radioButton1.Text = questions[currentQuestion].Choises[0].Text;
                        this.radioButton3.Text = questions[currentQuestion].Choises[1].Text;
                        this.radioButton4.Text = questions[currentQuestion].Choises[2].Text;
                        break;
                    case 2:
                        this.radioButton3.Text = questions[currentQuestion].Answers[0].Text;
                        this.radioButton2.Text = questions[currentQuestion].Choises[0].Text;
                        this.radioButton1.Text = questions[currentQuestion].Choises[1].Text;
                        this.radioButton4.Text = questions[currentQuestion].Choises[2].Text;
                        break;
                    case 3:
                        this.radioButton4.Text = questions[currentQuestion].Answers[0].Text;
                        this.radioButton2.Text = questions[currentQuestion].Choises[0].Text;
                        this.radioButton3.Text = questions[currentQuestion].Choises[1].Text;
                        this.radioButton1.Text = questions[currentQuestion].Choises[2].Text;
                        break;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var checkedButton = this.groupBox1.Controls.OfType<RadioButton>()
                                                  .FirstOrDefault(r => r.Checked);
            UserChoice userChoice = new UserChoice(checkedButton.Text);
            foreach(UserChoice answer in questions[currentQuestion].Answers)
            {
                if (answer.Equals(userChoice))
                {
                    score += questions[currentQuestion].Value;
                }
            }
            if (currentQuestion == questions.Count - 1)
            {
                TestController testController = new TestController();
                int maxScore = 0;
                foreach(QuestionModel question in questions)
                {
                    maxScore += question.Value;
                }
                double scr = Convert.ToDouble(score);
                scr = scr/maxScore*100;
                score = Convert.ToInt32(scr);
                testController.WriteTestResults(test, user, score);
                this.Close();
                Results resultsWindow = new Results(user, test, score);
                resultsWindow.Show();

            }
            else
            {
                currentQuestion++;
                this.Close();
                CurrentQuestionWindow currentQuestionWindow = new CurrentQuestionWindow(user,test, questions, currentQuestion,score);
                currentQuestionWindow.Show();
            }
        }
    }
}
