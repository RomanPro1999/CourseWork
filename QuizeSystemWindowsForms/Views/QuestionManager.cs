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
    public partial class QuestionManager : Form
    {
        UserModel user;
        SubjectModell subject;
        TopicModel topic;
        public QuestionManager(UserModel user,SubjectModell subject,TopicModel topic)
        {
            this.user = user;
            this.subject = subject;
            this.topic = topic;
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            EditTopic editTopic = new EditTopic(user, subject, topic);
            editTopic.Show();
        }
    }
}
