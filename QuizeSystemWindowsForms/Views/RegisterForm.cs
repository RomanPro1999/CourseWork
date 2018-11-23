using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizeSystemWindowsForms.Views;
using QuizeSystemWindowsForms.Models;
using QuizeSystemWindowsForms.Controllers;

namespace QuizeSystemWindowsForms.Views
{
    public partial class RegisterForm : Form
    {
        UserModel user=null;
        public RegisterForm()
        {
            InitializeComponent();
        }
        public RegisterForm(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void buttonCheckIfUserNameIsFree_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Exit();
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel(this.textBoxLogin.Text, this.textBoxPassword.Text,
                                                                    this.textBoxName.Text, this.textBoxSurname.Text, this.textBoxEmail.Text);
            RegisterUserController userController = new RegisterUserController();
            if (userController.RegisterUser(user))
            {
                MessageBox.Show("New User Added");
                Exit();
                
            }
            else
            {
                MessageBox.Show("An error has occured");
            }

        }
        public void Exit()
        {
            if (user != null)
            {
                this.Close();
                UsersManagerWindow users = new UsersManagerWindow(user);
                users.Show();
            }
            else
            {
                FormLogin loginForm = new FormLogin();
                this.Close();
                loginForm.Show();
            }
        }
    }
}
