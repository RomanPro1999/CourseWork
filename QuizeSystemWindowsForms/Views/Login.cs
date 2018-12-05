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

namespace QuizeSystemWindowsForms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
      

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel(this.textBoxLogin.Text, this.textBoxPassword.Text);
            UserController loginUserController = new UserController();
            user=loginUserController.Login(user);
            if (user == null)
            {
                MessageBox.Show("Incorrect data");
            }
            else
            {
                Console.WriteLine(user.Role);

                if (user.Role == "Admin")
                {
                    AdminStartWindow adminWindow = new AdminStartWindow(user);
                    adminWindow.Show();
                    this.Hide();
                }
                else
                {
                    UserStartWindow userWindow = new UserStartWindow(user);
                    userWindow.Show();
                    this.Hide();
                }
            }
        }
    }
}
