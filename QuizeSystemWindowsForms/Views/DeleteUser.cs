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
    public partial class DeleteUser : Form
    {
        UserModel user = null;
        public DeleteUser(UserModel user)
        {
            this.user = user;
            InitializeComponent();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            UsersManagerWindow usersManager = new UsersManagerWindow(user);
            usersManager.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            UsersController controller = new UsersController();
            UserModel userToDel = controller.LoadUserByLogin(this.textBoxLogin.Text);
            if (controller.DeleteUser(userToDel))
            {
                MessageBox.Show("User has been deleted");
            }
            else
            {
                MessageBox.Show("error");
            }

        }
    }
}
