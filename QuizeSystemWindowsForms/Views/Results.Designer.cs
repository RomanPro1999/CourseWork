namespace QuizeSystemWindowsForms.Views
{
    partial class Results
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
            this.labelTestName = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonRetakeTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(32, 41);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(35, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "label1";
            // 
            // labelTestName
            // 
            this.labelTestName.AutoSize = true;
            this.labelTestName.Location = new System.Drawing.Point(32, 85);
            this.labelTestName.Name = "labelTestName";
            this.labelTestName.Size = new System.Drawing.Size(35, 13);
            this.labelTestName.TabIndex = 1;
            this.labelTestName.Text = "label2";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(170, 41);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "label1";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(324, 200);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonRetakeTest
            // 
            this.buttonRetakeTest.Location = new System.Drawing.Point(233, 200);
            this.buttonRetakeTest.Name = "buttonRetakeTest";
            this.buttonRetakeTest.Size = new System.Drawing.Size(75, 23);
            this.buttonRetakeTest.TabIndex = 4;
            this.buttonRetakeTest.Text = "Retake test";
            this.buttonRetakeTest.UseVisualStyleBackColor = true;
            this.buttonRetakeTest.Click += new System.EventHandler(this.buttonRetakeTest_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 284);
            this.Controls.Add(this.buttonRetakeTest);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTestName);
            this.Controls.Add(this.labelUserName);
            this.Name = "Results";
            this.Text = "Rsults";
            this.Load += new System.EventHandler(this.Rsults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelTestName;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonRetakeTest;
    }
}