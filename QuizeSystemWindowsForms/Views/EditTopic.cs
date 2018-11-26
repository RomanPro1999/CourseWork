using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizeSystemWindowsForms.Controllers;
using QuizeSystemWindowsForms.Models;

namespace QuizeSystemWindowsForms.Views
{
    public partial class EditTopic : Form
    {
        UserModel user;
        SubjectModel subject;
        TopicModel topic;
        public EditTopic(UserModel user,SubjectModel subject,TopicModel topic)
        {
            this.user = user;
            this.subject = subject;
            this.topic = topic;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            EditSubject editSubject = new EditSubject(user,subject);
            editSubject.Show();
        }

        private void buttonEditTopicInfo_Click(object sender, EventArgs e)
        {
            TopicController controller = new TopicController();
            topic.Name = this.textBoxName.Text;
            topic.Describtion = this.richTextBoxDescribtion.Text;
            if (controller.EditTopic(topic))
            {
                MessageBox.Show("Topic edited");
            }
            else
            {
                MessageBox.Show("An error has occured");
            }
        }

        private void EditTopic_Load(object sender, EventArgs e)
        {
            this.textBoxName.Text = topic.Name;
            this.richTextBoxDescribtion.Text = topic.Describtion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TestManagerWindow testManagerWindow = new TestManagerWindow(user, subject, topic);
            testManagerWindow.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            QuestionManager questionManager = new QuestionManager(user, subject, topic);
            questionManager.Show();
        }
    }
}
