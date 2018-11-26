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
    public partial class UsersManagerWindow : Form
    {
        UserModel user;
        public UsersManagerWindow(UserModel user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminStartWindow adminStart = new AdminStartWindow(user);
            adminStart.Show();
        }

        private void UsersManagerWindow_Load(object sender, EventArgs e)
        {
           UserController userContoler = new UserController();
           this.dataGridView1.DataSource = userContoler.LoadUserDataTable();
            Console.WriteLine(userContoler.LoadUserDataTable().Rows);
            Console.WriteLine("something");

        }

        private void buttonRegisterUserAdmin_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(user);
            registerForm.Show();
            this.Hide();
        }

        private void buttonEditUserAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminEditUser adminEdit = new AdminEditUser(user);
            adminEdit.Show();
        }

        private void buttonDeleteUserAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser delWindow = new DeleteUser(user);
            delWindow.Show();
        }
    }
}
