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
            this.dataGridViewTests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateNewTest
            // 
            this.buttonCreateNewTest.Location = new System.Drawing.Point(245, 314);
            this.buttonCreateNewTest.Name = "buttonCreateNewTest";
            this.buttonCreateNewTest.Size = new System.Drawing.Size(178, 62);
            this.buttonCreateNewTest.TabIndex = 1;
            this.buttonCreateNewTest.Text = "Create new test";
            this.buttonCreateNewTest.UseVisualStyleBackColor = true;
            this.buttonCreateNewTest.Click += new System.EventHandler(this.buttonCreateNewTest_Click);
            // 
            // buttonEditTest
            // 
            this.buttonEditTest.Location = new System.Drawing.Point(429, 314);
            this.buttonEditTest.Name = "buttonEditTest";
            this.buttonEditTest.Size = new System.Drawing.Size(138, 62);
            this.buttonEditTest.TabIndex = 2;
            this.buttonEditTest.Text = "Edit test";
            this.buttonEditTest.UseVisualStyleBackColor = true;
            this.buttonEditTest.Click += new System.EventHandler(this.buttonEditTest_Click);
            // 
            // buttonDeleteTest
            // 
            this.buttonDeleteTest.Location = new System.Drawing.Point(573, 314);
            this.buttonDeleteTest.Name = "buttonDeleteTest";
            this.buttonDeleteTest.Size = new System.Drawing.Size(138, 62);
            this.buttonDeleteTest.TabIndex = 3;
            this.buttonDeleteTest.Text = "Delete test";
            this.buttonDeleteTest.UseVisualStyleBackColor = true;
            this.buttonDeleteTest.Click += new System.EventHandler(this.buttonDeleteTest_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(717, 314);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(138, 62);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewTests.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTests.Size = new System.Drawing.Size(868, 283);
            this.dataGridViewTests.TabIndex = 5;
            this.dataGridViewTests.SelectionChanged += new System.EventHandler(this.dataGridViewTests_SelectionChanged);
            // 
            // TestManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 412);
            this.Controls.Add(this.dataGridViewTests);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDeleteTest);
            this.Controls.Add(this.buttonEditTest);
            this.Controls.Add(this.buttonCreateNewTest);
            this.Name = "TestManagerWindow";
            this.Text = "Test manager";
            this.Load += new System.EventHandler(this.TestManagerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateNewTest;
        private System.Windows.Forms.Button buttonEditTest;
        private System.Windows.Forms.Button buttonDeleteTest;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewTests;
    }
}