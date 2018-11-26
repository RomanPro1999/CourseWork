using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizeSystemWindowsForms.Controllers;
using QuizeSystemWindowsForms.Models;

namespace QuizeSystemWindowsForms.Views
{
    public partial class AdminEditUser : Form
    {
        UserModel user = null;
        UserModel userToEdit = null;
        public AdminEditUser(UserModel user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersManagerWindow usersManager = new UsersManagerWindow(user);
            usersManager.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (userToEdit == null)
            {
                MessageBox.Show("Load user data using load by login method");
            }
            else
            {
                UserController editUserController = new UserController();
                userToEdit.Login = this.textBoxLogin.Text;
                userToEdit.Password = this.textBoxPassword.Text;
                userToEdit.Name = this.textBoxName.Text;
                userToEdit.Surname = this.textBoxSurname.Text;
                userToEdit.Email = this.textBoxEmail.Text;
                userToEdit.Role = this.textBoxRole.Text;
                
                if (editUserController.SaveChanges(userToEdit))
                {
                    MessageBox.Show("Data saved");
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "System.Windows.Form.Textbox")
                        {
                            c.Text = "";
                        }

                    }

                }
                else
                {
                    MessageBox.Show("An error has occured");
                }
                
            }
        }

        private void buttonSearchByLogin_Click_1(object sender, EventArgs e)
        {
            UserController usersController = new UserController();
            if (this.textBoxLogin.Text == "")
            {
                MessageBox.Show("Enter user login");
            }
            userToEdit = usersController.LoadUserByLogin(this.textBoxLogin.Text);
            if (userToEdit != null)
            {
                MessageBox.Show("Data successifuly loaded");
                this.textBoxLogin.Text = userToEdit.Login;
                this.textBoxPassword.Text = userToEdit.Password;
                this.textBoxName.Text = userToEdit.Name;
                this.textBoxSurname.Text = userToEdit.Surname;
                this.textBoxEmail.Text = userToEdit.Email;
                this.textBoxRole.Text = userToEdit.Role;
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }
    }
}
