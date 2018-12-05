namespace QuizeSystemWindowsForms.Views
{
    partial class EditSubjectInfo
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonChooseImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSubjectImage = new System.Windows.Forms.PictureBox();
            this.buttonManageTests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubjectImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(349, 363);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save Changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Location = new System.Drawing.Point(117, 212);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(191, 20);
            this.textBoxSubjectName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Subject name";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(450, 363);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonChooseImage
            // 
            this.buttonChooseImage.Location = new System.Drawing.Point(349, 160);
            this.buttonChooseImage.Name = "buttonChooseImage";
            this.buttonChooseImage.Size = new System.Drawing.Size(116, 23);
            this.buttonChooseImage.TabIndex = 9;
            this.buttonChooseImage.Text = "Choose image";
            this.buttonChooseImage.UseVisualStyleBackColor = true;
            this.buttonChooseImage.Click += new System.EventHandler(this.buttonChooseImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject image";
            // 
            // pictureBoxSubjectImage
            // 
            this.pictureBoxSubjectImage.Image = global::QuizeSystemWindowsForms.Properties.Resources._default;
            this.pictureBoxSubjectImage.Location = new System.Drawing.Point(117, 20);
            this.pictureBoxSubjectImage.Name = "pictureBoxSubjectImage";
            this.pictureBoxSubjectImage.Size = new System.Drawing.Size(214, 163);
            this.pictureBoxSubjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSubjectImage.TabIndex = 7;
            this.pictureBoxSubjectImage.TabStop = false;
            // 
            // buttonManageTests
            // 
            this.buttonManageTests.Location = new System.Drawing.Point(234, 363);
            this.buttonManageTests.Name = "buttonManageTests";
            this.buttonManageTests.Size = new System.Drawing.Size(97, 23);
            this.buttonManageTests.TabIndex = 14;
            this.buttonManageTests.Text = "Manage tests";
            this.buttonManageTests.UseVisualStyleBackColor = true;
            this.buttonManageTests.Click += new System.EventHandler(this.buttonManageTests_Click);
            // 
            // EditSubjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.buttonManageTests);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSubjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonChooseImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSubjectImage);
            this.Name = "EditSubjectInfo";
            this.Text = "EditSubjectInfo";
            this.Load += new System.EventHandler(this.EditSubjectInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubjectImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonChooseImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSubjectImage;
        private System.Windows.Forms.Button buttonManageTests;
    }
}