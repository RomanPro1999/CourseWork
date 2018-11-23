namespace QuizeSystemWindowsForms.Views
{
    partial class TestManagerWindow
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
            this.buttonCreateNewTest = new System.Windows.Forms.Button();
            this.buttonEditTest = new System.Windows.Forms.Button();
            this.buttonDeleteTest = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateNewTest
            // 
            this.buttonCreateNewTest.Location = new System.Drawing.Point(470, 307);
            this.buttonCreateNewTest.Name = "buttonCreateNewTest";
            this.buttonCreateNewTest.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateNewTest.TabIndex = 1;
            this.buttonCreateNewTest.Text = "Create new test";
            this.buttonCreateNewTest.UseVisualStyleBackColor = true;
            // 
            // buttonEditTest
            // 
            this.buttonEditTest.Location = new System.Drawing.Point(551, 307);
            this.buttonEditTest.Name = "buttonEditTest";
            this.buttonEditTest.Size = new System.Drawing.Size(75, 23);
            this.buttonEditTest.TabIndex = 2;
            this.buttonEditTest.Text = "Edit test";
            this.buttonEditTest.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTest
            // 
            this.buttonDeleteTest.Location = new System.Drawing.Point(632, 307);
            this.buttonDeleteTest.Name = "buttonDeleteTest";
            this.buttonDeleteTest.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTest.TabIndex = 3;
            this.buttonDeleteTest.Text = "Delete test";
            this.buttonDeleteTest.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(713, 307);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 283);
            this.dataGridView1.TabIndex = 5;
            // 
            // TestManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDeleteTest);
            this.Controls.Add(this.buttonEditTest);
            this.Controls.Add(this.buttonCreateNewTest);
            this.Name = "TestManagerWindow";
            this.Text = "TestManagerWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateNewTest;
        private System.Windows.Forms.Button buttonEditTest;
        private System.Windows.Forms.Button buttonDeleteTest;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}