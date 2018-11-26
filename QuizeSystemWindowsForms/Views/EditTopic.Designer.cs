namespace QuizeSystemWindowsForms.Views
{
    partial class EditTopic
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
            this.buttonTestsManager = new System.Windows.Forms.Button();
            this.buttonQuestionManager = new System.Windows.Forms.Button();
            this.buttonEditTopicInfo = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.richTextBoxDescribtion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonTestsManager
            // 
            this.buttonTestsManager.Location = new System.Drawing.Point(33, 236);
            this.buttonTestsManager.Name = "buttonTestsManager";
            this.buttonTestsManager.Size = new System.Drawing.Size(91, 23);
            this.buttonTestsManager.TabIndex = 0;
            this.buttonTestsManager.Text = "Tests manager";
            this.buttonTestsManager.UseVisualStyleBackColor = true;
            this.buttonTestsManager.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonQuestionManager
            // 
            this.buttonQuestionManager.Location = new System.Drawing.Point(149, 236);
            this.buttonQuestionManager.Name = "buttonQuestionManager";
            this.buttonQuestionManager.Size = new System.Drawing.Size(102, 23);
            this.buttonQuestionManager.TabIndex = 1;
            this.buttonQuestionManager.Text = "Question Manager";
            this.buttonQuestionManager.UseVisualStyleBackColor = true;
            this.buttonQuestionManager.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEditTopicInfo
            // 
            this.buttonEditTopicInfo.Location = new System.Drawing.Point(386, 50);
            this.buttonEditTopicInfo.Name = "buttonEditTopicInfo";
            this.buttonEditTopicInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonEditTopicInfo.TabIndex = 2;
            this.buttonEditTopicInfo.Text = "Edit Topic info";
            this.buttonEditTopicInfo.UseVisualStyleBackColor = true;
            this.buttonEditTopicInfo.Click += new System.EventHandler(this.buttonEditTopicInfo_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(467, 50);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Topic name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Describtion";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(76, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(249, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // richTextBoxDescribtion
            // 
            this.richTextBoxDescribtion.Location = new System.Drawing.Point(88, 50);
            this.richTextBoxDescribtion.Name = "richTextBoxDescribtion";
            this.richTextBoxDescribtion.Size = new System.Drawing.Size(237, 96);
            this.richTextBoxDescribtion.TabIndex = 7;
            this.richTextBoxDescribtion.Text = "";
            // 
            // EditTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.richTextBoxDescribtion);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEditTopicInfo);
            this.Controls.Add(this.buttonQuestionManager);
            this.Controls.Add(this.buttonTestsManager);
            this.Name = "EditTopic";
            this.Text = "EditTopic";
            this.Load += new System.EventHandler(this.EditTopic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTestsManager;
        private System.Windows.Forms.Button buttonQuestionManager;
        private System.Windows.Forms.Button buttonEditTopicInfo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxDescribtion;
    }
}