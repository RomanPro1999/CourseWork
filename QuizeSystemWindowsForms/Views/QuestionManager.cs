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
        SubjectModel subject;
        TopicModel topic;
        QuestionController questionController;
        QuestionModel selectedQuestion;
        public QuestionManager(UserModel user,SubjectModel subject,TopicModel topic)
        {
            this.user = user;
            this.subject = subject;
            this.topic = topic;
            questionController = new QuestionController();
            selectedQuestion = null; 
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            EditTopic editTopic = new EditTopic(user, subject, topic);
            editTopic.Show();
        }
        private void ResetQuestionTable()
        {
            this.dataGridView1.DataSource = questionController.LoadQuestionTable();
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
            }
        }
        private void QuestionManager_Load(object sender, EventArgs e)
        {
            ResetQuestionTable();
        }

        private void buttonDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (selectedQuestion != null)
            {
                if (questionController.DeleteQuestion(selectedQuestion))
                {
                    MessageBox.Show("Question was deleted");
                    ResetQuestionTable(); 
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
            AddQuestion addQuestionWindow = new AddQuestion(user, subject, topic);
            addQuestionWindow.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    selectedQuestion = questionController.LoadQuestionById(id);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonEditQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
