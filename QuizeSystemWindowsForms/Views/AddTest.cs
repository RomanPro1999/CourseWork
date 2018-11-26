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
    public partial class AddTest : Form
    {
        UserModel user;
        SubjectModel subject;
        TopicModel topic;
        TestController testController;
        public AddTest(UserModel user, SubjectModel subject, TopicModel topic)
        {
            this.user = user;
            this.subject = subject;
            this.topic = topic;
            testController = new TestController();
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //TestManagerWindow testManagerWindow = new TestManagerWindow(user, subject, topic);
            //testManagerWindow.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TestModel test = new TestModel(this.textBoxName.Text, Convert.ToInt32(this.textBoxNumberOfQuestions.Text), topic);
            if (testController.AddTest(test))
            {
                MessageBox.Show("Test created");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumberOfQuestions_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
