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
    public partial class EditSubjectInfo : Form
    {
        UserModel user = null;
        SubjectModel subject = null;
        public EditSubjectInfo(UserModel user,SubjectModel subject)
        {
            this.user = user;
            this.subject = subject;
            InitializeComponent();
            this.pictureBoxSubjectImage.Image = subject.Image;
            this.textBoxSubjectName.Text = subject.Name;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            EditSubject edit = new EditSubject(user);
            edit.Show();
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
            catch (Exception )
            {
                MessageBox.Show("An error has occured, while loading image");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            subject.Name = this.textBoxSubjectName.Text;
            subject.Image = this.pictureBoxSubjectImage.Image;
            SubjectController controller = new SubjectController();
            if (controller.EditSubject(subject))
            {
                MessageBox.Show("Data edited");
            }
            else
            {
                MessageBox.Show("An error has occured while executing the database operation");
            }
        }

        private void EditSubjectInfo_Load(object sender, EventArgs e)
        {
            //this.pictureBoxSubjectImage.Image = subject.Image;
            //this.textBoxSubjectName.Text = subject.Name;
        }
    }
}
