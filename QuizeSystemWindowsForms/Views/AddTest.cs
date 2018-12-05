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
        TestController testController;
        public AddTest(UserModel user, SubjectModel subject)
        {
            this.user = user;
            this.subject = subject;
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
            TestModel test = new TestModel(this.textBoxName.Text, Convert.ToInt32(this.textBoxNumberOfQuestions.Text),subject);
            if (testController.AddTest(test))
            {
                MessageBox.Show("Test created");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
