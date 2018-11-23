namespace QuizeSystemWindowsForms.Views
{
    partial class SubjectManagerWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.buttonEditSubject = new System.Windows.Forms.Button();
            this.buttonDeleteSubject = new System.Windows.Forms.Button();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCansel);
            this.groupBox1.Controls.Add(this.buttonEditSubject);
            this.groupBox1.Controls.Add(this.buttonDeleteSubject);
            this.groupBox1.Controls.Add(this.buttonAddSubject);
            this.groupBox1.Location = new System.Drawing.Point(12, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonCansel
            // 
            this.buttonCansel.Location = new System.Drawing.Point(381, 19);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(98, 23);
            this.buttonCansel.TabIndex = 3;
            this.buttonCansel.Text = "Cancel";
            this.buttonCansel.UseVisualStyleBackColor = true;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // buttonEditSubject
            // 
            this.buttonEditSubject.AutoSize = true;
            this.buttonEditSubject.Location = new System.Drawing.Point(129, 19);
            this.buttonEditSubject.Name = "buttonEditSubject";
            this.buttonEditSubject.Size = new System.Drawing.Size(75, 23);
            this.buttonEditSubject.TabIndex = 2;
            this.buttonEditSubject.Text = "Edit subject";
            this.buttonEditSubject.UseVisualStyleBackColor = true;
            this.buttonEditSubject.Click += new System.EventHandler(this.buttonEditSubject_Click);
            // 
            // buttonDeleteSubject
            // 
            this.buttonDeleteSubject.AutoSize = true;
            this.buttonDeleteSubject.Location = new System.Drawing.Point(236, 19);
            this.buttonDeleteSubject.Name = "buttonDeleteSubject";
            this.buttonDeleteSubject.Size = new System.Drawing.Size(85, 23);
            this.buttonDeleteSubject.TabIndex = 1;
            this.buttonDeleteSubject.Text = "Delete subject";
            this.buttonDeleteSubject.UseVisualStyleBackColor = true;
            this.buttonDeleteSubject.Click += new System.EventHandler(this.buttonDeleteSubject_Click);
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.AutoSize = true;
            this.buttonAddSubject.Location = new System.Drawing.Point(20, 19);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(103, 23);
            this.buttonAddSubject.TabIndex = 0;
            this.buttonAddSubject.Text = "Add subject";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 332);
            this.dataGridView1.TabIndex = 1;
            // 
            // SubjectManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubjectManagerWindow";
            this.Text = "SubjectManagerWindow";
            this.Load += new System.EventHandler(this.SubjectManagerWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Button buttonEditSubject;
        private System.Windows.Forms.Button buttonDeleteSubject;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}