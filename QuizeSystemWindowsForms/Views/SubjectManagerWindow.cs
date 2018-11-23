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
    public partial class SubjectManagerWindow : Form
    {
        UserModel user;
        public SubjectManagerWindow(UserModel user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void SubjectManagerWindow_Load(object sender, EventArgs e)
        {
            SubjectController subjectController = new SubjectController();
            this.dataGridView1.DataSource = subjectController.LoadSubjectsTable();
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminStartWindow adminStart = new AdminStartWindow(user);
            adminStart.Show();
        }

        private void buttonDeleteSubject_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteSubjectByName deleteWindow = new DeleteSubjectByName(user);
            deleteWindow.Show();
        }

        private void buttonEditSubject_Click(object sender, EventArgs e)
        {
            this.Close();
            EditSubject edit = new EditSubject(user);
            edit.Show();
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            this.Close();
            AddSubject addSubject = new AddSubject(user);
            addSubject.Show();
        }
    }
}
