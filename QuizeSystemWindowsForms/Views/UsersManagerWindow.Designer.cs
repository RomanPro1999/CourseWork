namespace QuizeSystemWindowsForms.Views
{
    partial class UsersManagerWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegisterUserAdmin = new System.Windows.Forms.Button();
            this.buttonEditUserAdmin = new System.Windows.Forms.Button();
            this.buttonDeleteUserAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(807, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(710, 424);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 39);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRegisterUserAdmin
            // 
            this.buttonRegisterUserAdmin.Location = new System.Drawing.Point(355, 424);
            this.buttonRegisterUserAdmin.Name = "buttonRegisterUserAdmin";
            this.buttonRegisterUserAdmin.Size = new System.Drawing.Size(161, 39);
            this.buttonRegisterUserAdmin.TabIndex = 2;
            this.buttonRegisterUserAdmin.Text = "Register New User";
            this.buttonRegisterUserAdmin.UseVisualStyleBackColor = true;
            this.buttonRegisterUserAdmin.Click += new System.EventHandler(this.buttonRegisterUserAdmin_Click);
            // 
            // buttonEditUserAdmin
            // 
            this.buttonEditUserAdmin.Location = new System.Drawing.Point(522, 424);
            this.buttonEditUserAdmin.Name = "buttonEditUserAdmin";
            this.buttonEditUserAdmin.Size = new System.Drawing.Size(101, 39);
            this.buttonEditUserAdmin.TabIndex = 3;
            this.buttonEditUserAdmin.Text = "Edit user";
            this.buttonEditUserAdmin.UseVisualStyleBackColor = true;
            this.buttonEditUserAdmin.Click += new System.EventHandler(this.buttonEditUserAdmin_Click);
            // 
            // buttonDeleteUserAdmin
            // 
            this.buttonDeleteUserAdmin.Location = new System.Drawing.Point(629, 424);
            this.buttonDeleteUserAdmin.Name = "buttonDeleteUserAdmin";
            this.buttonDeleteUserAdmin.Size = new System.Drawing.Size(75, 39);
            this.buttonDeleteUserAdmin.TabIndex = 4;
            this.buttonDeleteUserAdmin.Text = "Delete User";
            this.buttonDeleteUserAdmin.UseVisualStyleBackColor = true;
            this.buttonDeleteUserAdmin.Click += new System.EventHandler(this.buttonDeleteUserAdmin_Click);
            // 
            // UsersManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 475);
            this.Controls.Add(this.buttonDeleteUserAdmin);
            this.Controls.Add(this.buttonEditUserAdmin);
            this.Controls.Add(this.buttonRegisterUserAdmin);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsersManagerWindow";
            this.Text = "Users manager";
            this.Load += new System.EventHandler(this.UsersManagerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRegisterUserAdmin;
        private System.Windows.Forms.Button buttonEditUserAdmin;
        private System.Windows.Forms.Button buttonDeleteUserAdmin;
    }
}