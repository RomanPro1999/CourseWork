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
    public partial class AdminStartWindow : Form
    {
        UserModel user = null;
        public AdminStartWindow(UserModel user)
        {
            InitializeComponent();
            this.user = user;
            this.labelUserName.Text = user.Name + " " + user.Surname;
            this.labelEmail.Text = user.Email;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser(user);
            editUser.Show();
            this.Hide();
        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersManagerWindow usersManager = new UsersManagerWindow(user);
            usersManager.Show();
        }

        private void buttonManageSubjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubjectManagerWindow subjectManager = new SubjectManagerWindow(user);
            subjectManager.ShowDialog();

        }
    }
}
