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
    public partial class TestSelect : Form
    {
        UserModel user;
        SubjectModel subject;
        TestModel selectedTest;
        TestController testController;
        public TestSelect(UserModel user,SubjectModel subject)
        {
            this.subject = subject;
            this.user = user;
            selectedTest = null;
            this.testController = new TestController();
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            UserStartWindow userStartWindow = new UserStartWindow(user);
            userStartWindow.Show();
        }
        private void ResetTestTable()
        {
            this.dataGridViewTests.DataSource = testController.LoadTestsTable(subject);
            if (dataGridViewTests.Rows.Count > 0)
            {
                dataGridViewTests.Rows[0].Selected = true;
            }
        }
        private void TestSelect_Load(object sender, EventArgs e)
        {
            ResetTestTable();
        }

        private void dataGridViewTests_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewTests.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    selectedTest = testController.LoadTestById(id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void buttonTakeTest_Click(object sender, EventArgs e)
        {
            if (selectedTest != null)
            {
                List<QuestionModel> questions = testController.LoadQuestions(selectedTest);
                CurrentQuestionWindow currentQuestionWindow = new CurrentQuestionWindow(user, selectedTest, questions, 0);
                this.Close();
                currentQuestionWindow.Show();
            }
            else
            {
                MessageBox.Show("Select test");
            }
        }
    }
}
