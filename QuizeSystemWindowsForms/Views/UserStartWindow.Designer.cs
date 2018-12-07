namespace QuizeSystemWindowsForms.Views
{
    partial class UserStartWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonEditInfo = new System.Windows.Forms.Button();
            this.pictureBoxSubjectImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubjectImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(21, 26);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose the subject";
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(163, 61);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(364, 21);
            this.comboBoxSubjects.TabIndex = 3;
            this.comboBoxSubjects.SelectedValueChanged += new System.EventHandler(this.comboBoxSubjects_SelectedValueChanged);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(553, 66);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 4;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(552, 26);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 5;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonEditInfo
            // 
            this.buttonEditInfo.Location = new System.Drawing.Point(452, 26);
            this.buttonEditInfo.Name = "buttonEditInfo";
            this.buttonEditInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonEditInfo.TabIndex = 6;
            this.buttonEditInfo.Text = "Edit profile";
            this.buttonEditInfo.UseVisualStyleBackColor = true;
            this.buttonEditInfo.Click += new System.EventHandler(this.buttonEditInfo_Click);
            // 
            // pictureBoxSubjectImage
            // 
            this.pictureBoxSubjectImage.Location = new System.Drawing.Point(24, 95);
            this.pictureBoxSubjectImage.Name = "pictureBoxSubjectImage";
            this.pictureBoxSubjectImage.Size = new System.Drawing.Size(604, 372);
            this.pictureBoxSubjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSubjectImage.TabIndex = 7;
            this.pictureBoxSubjectImage.TabStop = false;
            // 
            // UserStartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 488);
            this.Controls.Add(this.pictureBoxSubjectImage);
            this.Controls.Add(this.buttonEditInfo);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUserName);
            this.Name = "UserStartWindow";
            this.Text = "Testing system";
            this.Load += new System.EventHandler(this.UserStartWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubjectImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonEditInfo;
        private System.Windows.Forms.PictureBox pictureBoxSubjectImage;
    }
}