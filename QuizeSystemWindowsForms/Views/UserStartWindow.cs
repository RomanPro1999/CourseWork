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
    public partial class UserStartWindow : Form
    {
        UserModel user;
        SubjectModel selectedSubject;
        SubjectController subjectController;
        public UserStartWindow(UserModel user)
        {
            this.user = user;
            subjectController = new SubjectController();
            InitializeComponent();
        }
        public UserStartWindow(UserModel user, SubjectModel subject)
        {
            this.user = user;
            this.selectedSubject = subject;
            subjectController = new SubjectController();
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private void UserStartWindow_Load(object sender, EventArgs e)
        {
            this.labelUserName.Text = user.Name + " " + user.Surname;
            List<SubjectModel> subjects = new List<SubjectModel>();
            subjects = subjectController.LoadSubjectsList();
            foreach (var subject in subjects)
            {
                this.comboBoxSubjects.Items.Add(subject.ToString());
            }
            if (selectedSubject ==null)
            {
                selectedSubject = subjects[0];
            }
            this.comboBoxSubjects.SelectedItem = selectedSubject.Name;
            this.pictureBoxSubjectImage.Image = selectedSubject.Image;
        }

        private void comboBoxSubjects_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedSubject = subjectController.LoadSubjectByName(this.comboBoxSubjects.SelectedItem.ToString());
            pictureBoxSubjectImage.Image = selectedSubject.Image;
            
        }

        private void buttonEditInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            EditUser editUserWindow = new EditUser(user);
            editUserWindow.Show();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            TestSelect testSelectWindow = new TestSelect(user, selectedSubject);
            testSelectWindow.Show();
        }
    }
}
