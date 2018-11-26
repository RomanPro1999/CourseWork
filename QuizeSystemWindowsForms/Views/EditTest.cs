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
        TopicModel topic;
        TestModel test;
        TestController testController;
        public EditTest(UserModel user, SubjectModel subject, TopicModel topic,TestModel test)
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
        }
    }
}
