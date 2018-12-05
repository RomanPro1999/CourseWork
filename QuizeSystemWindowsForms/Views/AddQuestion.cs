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
    public partial class AddQuestion : Form
    {
        UserModel user;
        SubjectModel subject;
        TestModel test;
        QuestionController questionController;
        public AddQuestion(UserModel user, SubjectModel subject, TestModel test)
        {
            this.user = user;
            this.subject = subject;
            this.test = test;
            this.questionController = new QuestionController();
            InitializeComponent();
        }

        private void buttonClose2_Click(object sender, EventArgs e)
        {
            this.Close();
            QuestionManager questionManagerWindow = new QuestionManager(user, subject, test);
            questionManagerWindow.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            QuestionManager questionManagerWindow = new QuestionManager(user, subject,test);
            questionManagerWindow.Show();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) " +
                    "| *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    this.pictureBoxImage.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured, while loading image");
            }
        }

       
        private void buttonSaveSimple_Click_1(object sender, EventArgs e)
        {
            QuestionModel question = new QuestionModel(this.richTextBoxSimpleQuestion.Text, "Simple", this.test, Convert.ToInt32(this.textBoxSimpleValue.Text));
            question.Answers.Add(new UserChoice(this.textBoxSimpleAnswer.Text));
            question.Choises.Add(new UserChoice(this.textBoxSimpleChoice1.Text));
            question.Choises.Add(new UserChoice(this.textBoxSimpleChoice3.Text));
            question.Choises.Add(new UserChoice(this.textBoxSimpleChoice2.Text));
            if (questionController.AddSimpleQuestion(question))
            {
                MessageBox.Show("Question Successfuly added");
            }
            else
            {
                MessageBox.Show("error");
            }
            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            QuestionModel question = new QuestionModel(this.richTextBoxImageQuestion.Text, "Image", this.test, Convert.ToInt32(this.textBoxImageValue.Text));
            question.Image = pictureBoxImage.Image;
            question.Answers.Add(new UserChoice(this.textBoxAnswerImage.Text));
            question.Choises.Add(new UserChoice(this.textBoxChoiceImage1.Text));
            question.Choises.Add(new UserChoice(this.textBoxChoiceImage2.Text));
            question.Choises.Add(new UserChoice(this.textBoxChoiceImage3.Text));
            if (questionController.AddQuestionWithImage(question))
            {
                MessageBox.Show("Question Successfuly added");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
