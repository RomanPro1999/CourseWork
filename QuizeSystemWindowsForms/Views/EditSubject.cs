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
    public partial class EditSubject : Form
    {
        UserModel user;
        List<SubjectModel> subjects;
        SubjectModel selectedSubject=null;
        TopicModel selectedTopic=null;
        public EditSubject(UserModel user)
        {
            this.user = user;
            InitializeComponent();
        }
        public EditSubject(UserModel user,SubjectModel subject)
        {
            this.user = user;
            this.selectedSubject = subject;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            SubjectManagerWindow subjectManager = new SubjectManagerWindow(user);
            subjectManager.Show();
        }

        private void buttonChangeSubjectImage_Click(object sender, EventArgs e)
        {
            SubjectController controller = new SubjectController();
            selectedSubject = controller.LoadSubjectByName(this.comboBoxSubjectNames.SelectedItem.ToString());
            if (selectedSubject != null)
            {
                EditSubjectInfo editSubject = new EditSubjectInfo(user, selectedSubject);
                editSubject.Show();
                this.Close();
            }
            
        }

        private void EditSubject_Load(object sender, EventArgs e)
        {
            SubjectController controller = new SubjectController();
            subjects = controller.LoadSubjectsList();
            foreach(var subject in subjects)
            {
                this.comboBoxSubjectNames.Items.Add(subject.ToString());
                this.imageListSubjectsImages.Images.Add(subject.Image);
            }
            if(selectedSubject==null)
                selectedSubject = subjects[0];
            this.comboBoxSubjectNames.SelectedItem = selectedSubject.Name;
            this.pictureBoxSubjectImage.Image = selectedSubject.Image;
            ResetTopicTable();
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void comboBoxSubjectNames_SelectedValueChanged(object sender, EventArgs e)
        {
            SubjectController controller = new SubjectController();
            selectedSubject = controller.LoadSubjectByName(this.comboBoxSubjectNames.SelectedItem.ToString());
            pictureBoxSubjectImage.Image = selectedSubject.Image;
            ResetTopicTable();
        }

        private void buttonAddTopic_Click(object sender, EventArgs e)
        {
            this.Close();
            AddTopic addTopic = new AddTopic(user, selectedSubject);
            addTopic.Show();
        }

        private void buttonDeleteTopic_Click(object sender, EventArgs e)
        {
            if (selectedTopic != null)
            {
                TopicController controller = new TopicController();
                if (controller.DeleteTopic(selectedTopic))
                {
                    MessageBox.Show("Topic has been deleted");
                    ResetTopicTable();
                }
                else
                {
                    MessageBox.Show("Error has occured");
                }
            }
            else
            {
                MessageBox.Show("Select Topic");
            }
        }
        void ResetTopicTable()
        {
            
            TopicController controllerTopic = new TopicController();
            this.dataGridView1.DataSource = controllerTopic.LoadTopicDataTableForSpecificSubject(selectedSubject);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string name = row.Cells[0].Value.ToString();
                string describtion = row.Cells[1].Value.ToString();
                TopicController controller = new TopicController();
                if(name!=null && describtion != null)
                {
                    selectedTopic = controller.SelectTopicByNameAndDescribtion(name, describtion);
                }
            }
            
        }

        private void buttonEditTopic_Click(object sender, EventArgs e)
        {
            EditTopic editTopic = new EditTopic(user, selectedSubject, selectedTopic);
            Console.WriteLine(selectedTopic.Name);
            Console.WriteLine(selectedTopic.Describtion);
            editTopic.Show();
            this.Close();
        }
    }
}
