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
    public partial class AddTopic : Form
    {
        UserModel user;
        SubjectModel subject;
        public AddTopic(UserModel user,SubjectModel subject)
        {
            this.user = user;
            this.subject = subject;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            EditSubject editSubject = new EditSubject(user,subject);
            editSubject.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TopicController controller = new TopicController();
            TopicModel topic = new TopicModel(this.textBoxTopicName.Text, subject, this.richTextBoxDescribtion.Text);
            if (controller.AddTopic(topic))
            {
                MessageBox.Show("Topic added");
            }
            else
            {
                MessageBox.Show("An error has occured");
            }
        }
    }
}
