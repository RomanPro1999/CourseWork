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
    public partial class DeleteSubjectByName : Form
    {
        UserModel user;
        public DeleteSubjectByName(UserModel user)
        {
            this.user = user;
            InitializeComponent();
        }

        

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            SubjectManagerWindow subjectManager = new SubjectManagerWindow(user);
            subjectManager.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SubjectModell subject = new SubjectModell();
            subject.Name = this.textBoxName.Text;
            SubjectController controller = new SubjectController();
            if (controller.DeleteSubject(subject))
            {
                MessageBox.Show("Subject has been deleted");

            }
            else
            {
                MessageBox.Show("An error has been occured");
            }

        }
    }
}
