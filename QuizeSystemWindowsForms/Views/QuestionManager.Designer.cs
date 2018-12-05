namespace QuizeSystemWindowsForms.Views
{
    partial class QuestionManager
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
            this.buttonDeleteQuestion = new System.Windows.Forms.Button();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonEditQuestion = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDeleteQuestion
            // 
            this.buttonDeleteQuestion.Location = new System.Drawing.Point(395, 23);
            this.buttonDeleteQuestion.Name = "buttonDeleteQuestion";
            this.buttonDeleteQuestion.Size = new System.Drawing.Size(168, 46);
            this.buttonDeleteQuestion.TabIndex = 0;
            this.buttonDeleteQuestion.Text = "Delete question";
            this.buttonDeleteQuestion.UseVisualStyleBackColor = true;
            this.buttonDeleteQuestion.Click += new System.EventHandler(this.buttonDeleteQuestion_Click);
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(62, 23);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(182, 46);
            this.buttonAddQuestion.TabIndex = 1;
            this.buttonAddQuestion.Text = "Add new question ";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonEditQuestion
            // 
            this.buttonEditQuestion.Location = new System.Drawing.Point(62, 98);
            this.buttonEditQuestion.Name = "buttonEditQuestion";
            this.buttonEditQuestion.Size = new System.Drawing.Size(182, 39);
            this.buttonEditQuestion.TabIndex = 2;
            this.buttonEditQuestion.Text = "Edit Question";
            this.buttonEditQuestion.UseVisualStyleBackColor = true;
            this.buttonEditQuestion.Click += new System.EventHandler(this.buttonEditQuestion_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(395, 98);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(168, 39);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(807, 288);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddQuestion);
            this.groupBox1.Controls.Add(this.buttonDeleteQuestion);
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.buttonEditQuestion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // QuestionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuestionManager";
            this.Text = "QuestionManager";
            this.Load += new System.EventHandler(this.QuestionManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteQuestion;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Button buttonEditQuestion;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}