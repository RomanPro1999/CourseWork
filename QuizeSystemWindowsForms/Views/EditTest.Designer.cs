﻿namespace QuizeSystemWindowsForms.Views
{
    partial class EditTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNumberOfQuestions = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonManageQuestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumberOfQuestions
            // 
            this.textBoxNumberOfQuestions.Location = new System.Drawing.Point(135, 108);
            this.textBoxNumberOfQuestions.Name = "textBoxNumberOfQuestions";
            this.textBoxNumberOfQuestions.Size = new System.Drawing.Size(232, 20);
            this.textBoxNumberOfQuestions.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(135, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(232, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(292, 166);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 53);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(192, 166);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 53);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Test name";
            // 
            // buttonManageQuestions
            // 
            this.buttonManageQuestions.Location = new System.Drawing.Point(33, 166);
            this.buttonManageQuestions.Name = "buttonManageQuestions";
            this.buttonManageQuestions.Size = new System.Drawing.Size(111, 53);
            this.buttonManageQuestions.TabIndex = 13;
            this.buttonManageQuestions.Text = "Manage questions";
            this.buttonManageQuestions.UseVisualStyleBackColor = true;
            this.buttonManageQuestions.Click += new System.EventHandler(this.buttonManageQuestions_Click);
            // 
            // EditTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 339);
            this.Controls.Add(this.buttonManageQuestions);
            this.Controls.Add(this.textBoxNumberOfQuestions);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTest";
            this.Text = "EditTest";
            this.Load += new System.EventHandler(this.EditTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumberOfQuestions;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonManageQuestions;
    }
}