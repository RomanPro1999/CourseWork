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
        UserController userContoller;
        UserModel selectedUser;
        public UsersManagerWindow(UserModel user)
        {
            this.user = user;
            userContoller= new UserController();
            selectedUser = null;
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
            ResetTableData();
        }
        private void ResetTableData()
        {
            this.dataGridView1.DataSource = userContoller.LoadUserDataTable();

        }

        private void buttonRegisterUserAdmin_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(user);
            registerForm.Show();
            this.Hide();
        }

        private void buttonEditUserAdmin_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                this.Hide();
                AdminEditUser adminEdit = new AdminEditUser(user,selectedUser);
                adminEdit.Show();
            }
            else
            {
                MessageBox.Show("Select user to edit");
            }
            
        }

        private void buttonDeleteUserAdmin_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                if (userContoller.DeleteUser(selectedUser))
                {
                    MessageBox.Show("User has been deleted");
                    ResetTableData();
                }
                else
                {
                    MessageBox.Show("An errror has occured");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    selectedUser = userContoller.LoadUserById(id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
