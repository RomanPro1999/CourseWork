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
    public partial class EditTest : Form
    {
        UserModel user;
        SubjectModel subject;
        TestModel test;
        TestController testController;
        public EditTest(UserModel user, SubjectModel subject, TestModel test)
        {
            this.user = user;
            this.subject = subject;
            this.test = test;
            testController = new TestController();
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            TestManagerWindow testManagerWindow = new TestManagerWindow(user, subject);
            testManagerWindow.Show();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            test.Name = this.textBoxName.Text;
            test.NumberOfQuestions = Convert.ToInt32(this.textBoxNumberOfQuestions.Text);
            if (testController.EditTest(test))
            {
                MessageBox.Show("Data edited");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonManageQuestions_Click(object sender, EventArgs e)
        {
            this.Close();
            QuestionManager questionManagerWindow = new QuestionManager(user, subject, test);
            questionManagerWindow.Show();
        }

        private void EditTest_Load(object sender, EventArgs e)
        {
            this.textBoxName.Text = test.Name;
            this.textBoxNumberOfQuestions.Text = test.NumberOfQuestions.ToString();
        }
    }
}
