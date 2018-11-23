namespace QuizeSystemWindowsForms.Views
{
    partial class EditSubject
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
            this.components = new System.ComponentModel.Container();
            this.buttonAddTopic = new System.Windows.Forms.Button();
            this.buttonEditTopic = new System.Windows.Forms.Button();
            this.buttonDeleteTopic = new System.Windows.Forms.Button();
            this.buttonChangeSubjectInfo = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSubjectNames = new System.Windows.Forms.ComboBox();
            this.imageListSubjectsImages = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxSubjectImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubjectImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTopic
            // 
            this.buttonAddTopic.Location = new System.Drawing.Point(404, 287);
            this.buttonAddTopic.Name = "buttonAddTopic";
            this.buttonAddTopic.Size = new System.Drawing.Size(94, 23);
            this.buttonAddTopic.TabIndex = 1;
            this.buttonAddTopic.Text = "Add topic";
            this.buttonAddTopic.UseVisualStyleBackColor = true;
            this.buttonAddTopic.Click += new System.EventHandler(this.buttonAddTopic_Click);
            // 
            // buttonEditTopic
            // 
            this.buttonEditTopic.Location = new System.Drawing.Point(404, 229);
            this.buttonEditTopic.Name = "buttonEditTopic";
            this.buttonEditTopic.Size = new System.Drawing.Size(94, 23);
            this.buttonEditTopic.TabIndex = 2;
            this.buttonEditTopic.Text = "Edit topic";
            this.buttonEditTopic.UseVisualStyleBackColor = true;
            this.buttonEditTopic.Click += new System.EventHandler(this.buttonEditTopic_Click);
            // 
            // buttonDeleteTopic
            // 
            this.buttonDeleteTopic.Location = new System.Drawing.Point(404, 258);
            this.buttonDeleteTopic.Name = "buttonDeleteTopic";
            this.buttonDeleteTopic.Size = new System.Drawing.Size(94, 23);
            this.buttonDeleteTopic.TabIndex = 3;
            this.buttonDeleteTopic.Text = "Delete topic";
            this.buttonDeleteTopic.UseVisualStyleBackColor = true;
            this.buttonDeleteTopic.Click += new System.EventHandler(this.buttonDeleteTopic_Click);
            // 
            // buttonChangeSubjectInfo
            // 
            this.buttonChangeSubjectInfo.Location = new System.Drawing.Point(390, 12);
            this.buttonChangeSubjectInfo.Name = "buttonChangeSubjectInfo";
            this.buttonChangeSubjectInfo.Size = new System.Drawing.Size(123, 53);
            this.buttonChangeSubjectInfo.TabIndex = 5;
            this.buttonChangeSubjectInfo.Text = "Edit subject info";
            this.buttonChangeSubjectInfo.UseVisualStyleBackColor = true;
            this.buttonChangeSubjectInfo.Click += new System.EventHandler(this.buttonChangeSubjectImage_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(404, 200);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subject name";
            // 
            // comboBoxSubjectNames
            // 
            this.comboBoxSubjectNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjectNames.FormattingEnabled = true;
            this.comboBoxSubjectNames.Location = new System.Drawing.Point(90, 12);
            this.comboBoxSubjectNames.Name = "comboBoxSubjectNames";
            this.comboBoxSubjectNames.Size = new System.Drawing.Size(233, 21);
            this.comboBoxSubjectNames.TabIndex = 9;
            this.comboBoxSubjectNames.SelectedValueChanged += new System.EventHandler(this.comboBoxSubjectNames_SelectedValueChanged);
            // 
            // imageListSubjectsImages
            // 
            this.imageListSubjectsImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListSubjectsImages.ImageSize = new System.Drawing.Size(250, 250);
            this.imageListSubjectsImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(332, 226);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pictureBoxSubjectImage
            // 
            this.pictureBoxSubjectImage.Location = new System.Drawing.Point(16, 52);
            this.pictureBoxSubjectImage.Name = "pictureBoxSubjectImage";
            this.pictureBoxSubjectImage.Size = new System.Drawing.Size(307, 146);
            this.pictureBoxSubjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSubjectImage.TabIndex = 7;
            this.pictureBoxSubjectImage.TabStop = false;
            // 
            // EditSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxSubjectNames);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.pictureBoxSubjectImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangeSubjectInfo);
            this.Controls.Add(this.buttonDeleteTopic);
            this.Controls.Add(this.buttonEditTopic);
            this.Controls.Add(this.buttonAddTopic);
            this.Name = "EditSubject";
            this.Text = "EditSubject";
            this.Load += new System.EventHandler(this.EditSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubjectImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddTopic;
        private System.Windows.Forms.Button buttonEditTopic;
        private System.Windows.Forms.Button buttonDeleteTopic;
        private System.Windows.Forms.Button buttonChangeSubjectInfo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxSubjectImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSubjectNames;
        private System.Windows.Forms.ImageList imageListSubjectsImages;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}