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
    public partial class EditUser : Form
    {
        UserModel user=null;
        public EditUser(UserModel user)
        {
            InitializeComponent();
            this.user = user;
            this.textBoxLogin.Text = user.Login;
            this.textBoxPassword.Text = user.Password;
            this.textBoxName.Text = user.Name;
            this.textBoxSurname.Text = user.Surname;
            this.textBoxEmail.Text = user.Email;
            this.textBoxRole.Text = user.Role;
            if (user.Role == "Admin")
            {
                this.groupBox1.Visible = true;
            }
        }
        public EditUser()
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UserController editUserController = new UserController();
            user.Login = this.textBoxLogin.Text;
            user.Password = this.textBoxPassword.Text;
            user.Name = this.textBoxName.Text;
            user.Surname = this.textBoxSurname.Text;
            user.Email = this.textBoxEmail.Text;
            if (this.groupBox1.Visible == true)
            {
                user.Role = this.textBoxRole.Text;
            }
            if (editUserController.SaveChanges(user))
            {
                MessageBox.Show("Data saved");

            }
            else
            {
                MessageBox.Show("An error has occured");
            }
            Exit();
        }
        public void Exit()
        {
            if (user.Role == "Admin")
            {
                AdminStartWindow adminStart = new AdminStartWindow(user);
                adminStart.Show();
            }
            else
            {
                UserStartWindow userStart = new UserStartWindow();
                userStart.Show();
            }
            this.Close();
        }
    }
}
