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
    public partial class AddSubject : Form
    {
        UserModel user = null;
        public AddSubject(UserModel user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) " +
                    "| *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    this.pictureBoxSubjectImage.ImageLocation = imageLocation;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error has occured, while loading image");
            }
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            SubjectModel subject = new SubjectModel(this.textBoxSubjectName.Text, this.pictureBoxSubjectImage.Image);
            SubjectController controller = new SubjectController();
            if (controller.AddSubject(subject))
            {
                MessageBox.Show("New subject added");
            }
            else
            {
                MessageBox.Show("An error has occured while executing the database operation");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            SubjectManagerWindow subjectManager = new SubjectManagerWindow(user);
            subjectManager.Show();
        }
    }
}
