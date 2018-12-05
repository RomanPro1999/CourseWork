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
        SubjectController subjectController;
        SubjectModel selectedSubject;
        public SubjectManagerWindow(UserModel user)
        {
            this.user = user;
            subjectController = new SubjectController();
            selectedSubject = null;
            InitializeComponent();
        }

        private void SubjectManagerWindow_Load(object sender, EventArgs e)
        {
            ResetTable();
        }

        private void ResetTable()
        {
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
            if (selectedSubject != null)
            {
                if (subjectController.DeleteSubject(selectedSubject))
                {
                    MessageBox.Show("Subject has been deleted");
                    ResetTable();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void buttonEditSubject_Click(object sender, EventArgs e)
        {
            if (selectedSubject != null)
            {
                this.Close();
                EditSubjectInfo edit = new EditSubjectInfo(user,selectedSubject);
                edit.Show();
            }
            
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            this.Close();
            AddSubject addSubject = new AddSubject(user);
            addSubject.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    selectedSubject = subjectController.LoadSubjectById(id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
