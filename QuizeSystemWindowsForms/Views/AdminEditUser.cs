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
        UserController editUserController;
        public AdminEditUser(UserModel user,UserModel userToEdit)
        {
            this.user = user;
            this.userToEdit = userToEdit;
            editUserController = new UserController();
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

        private void AdminEditUser_Load(object sender, EventArgs e)
        {
            this.textBoxEmail.Text = userToEdit.Email;
            this.textBoxLogin.Text = userToEdit.Login;
            this.textBoxName.Text = userToEdit.Name;
            this.textBoxPassword.Text = userToEdit.Password;
            this.textBoxRole.Text = userToEdit.Role;
            this.textBoxSurname.Text = userToEdit.Surname;
            
        }
    }

        
}
