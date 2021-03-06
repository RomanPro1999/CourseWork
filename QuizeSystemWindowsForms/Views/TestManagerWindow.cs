﻿using System;
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
    public partial class TestManagerWindow : Form
    {
        UserModel user;
        SubjectModel subject;
        TestModel selectedTest;
        TestController testController;
        public TestManagerWindow(UserModel user,SubjectModel subject)
        {
            this.user = user;
            this.subject = subject;
            selectedTest = null;
            testController = new TestController();
            InitializeComponent();
        }
        private void ResetTestTable()
        {
            this.dataGridViewTests.DataSource = testController.LoadTestsTable(subject);
            if (dataGridViewTests.Rows.Count > 0)
            {
                dataGridViewTests.Rows[0].Selected = true;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            EditSubjectInfo editSubject = new EditSubjectInfo(user, subject);
            editSubject.Show();
        }

        private void TestManagerWindow_Load(object sender, EventArgs e)
        {
            ResetTestTable();
        }

        private void buttonCreateNewTest_Click(object sender, EventArgs e)
        {
            this.Close();
            AddTest addWindow = new AddTest(user,subject);
            addWindow.Show();
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
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonDeleteTest_Click(object sender, EventArgs e)
        {
            if (selectedTest != null)
            {
                if (testController.DeleteTest(selectedTest))
                {
                    MessageBox.Show("Test has been deleted");
                    ResetTestTable();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void buttonEditTest_Click(object sender, EventArgs e)
        {
            if (selectedTest != null)
            {
                EditTest editTestWindow = new EditTest(user, subject, selectedTest);
                this.Close();
                editTestWindow.Show();  
            }
        }
    }
}
