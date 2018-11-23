namespace QuizeSystemWindowsForms.Views
{
    partial class AdminStartWindow
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.buttonManageSubjects = new System.Windows.Forms.Button();
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(38, 32);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.AutoSize = true;
            this.buttonLogOut.Location = new System.Drawing.Point(450, 32);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.buttonManageSubjects);
            this.groupBox1.Controls.Add(this.buttonManageUsers);
            this.groupBox1.Location = new System.Drawing.Point(28, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Location = new System.Drawing.Point(354, 32);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(75, 23);
            this.buttonEditProfile.TabIndex = 2;
            this.buttonEditProfile.Text = "Edit profile";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // buttonManageSubjects
            // 
            this.buttonManageSubjects.AutoSize = true;
            this.buttonManageSubjects.Location = new System.Drawing.Point(126, 19);
            this.buttonManageSubjects.Name = "buttonManageSubjects";
            this.buttonManageSubjects.Size = new System.Drawing.Size(114, 23);
            this.buttonManageSubjects.TabIndex = 1;
            this.buttonManageSubjects.Text = "Manage Subjects";
            this.buttonManageSubjects.UseVisualStyleBackColor = true;
            this.buttonManageSubjects.Click += new System.EventHandler(this.buttonManageSubjects_Click);
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.AutoSize = true;
            this.buttonManageUsers.Location = new System.Drawing.Point(6, 19);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(114, 23);
            this.buttonManageUsers.TabIndex = 0;
            this.buttonManageUsers.Text = "Manage users";
            this.buttonManageUsers.UseVisualStyleBackColor = true;
            this.buttonManageUsers.Click += new System.EventHandler(this.buttonManageUsers_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(166, 32);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // AdminStartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonEditProfile);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelUserName);
            this.Name = "AdminStartWindow";
            this.Text = "AdminStartWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonManageUsers;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Button buttonManageSubjects;
        private System.Windows.Forms.Label labelEmail;
    }
}