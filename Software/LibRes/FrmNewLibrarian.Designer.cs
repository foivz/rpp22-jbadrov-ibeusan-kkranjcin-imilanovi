namespace LibRes
{
    partial class FrmNewLibrarian
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
            this.cbPasswordVisible = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAddLibrarian = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbPasswordVisible
            // 
            this.cbPasswordVisible.AutoSize = true;
            this.cbPasswordVisible.Location = new System.Drawing.Point(161, 251);
            this.cbPasswordVisible.Name = "cbPasswordVisible";
            this.cbPasswordVisible.Size = new System.Drawing.Size(158, 20);
            this.cbPasswordVisible.TabIndex = 38;
            this.cbPasswordVisible.Text = "Show/Hide Password";
            this.cbPasswordVisible.UseVisualStyleBackColor = true;
            this.cbPasswordVisible.CheckStateChanged += new System.EventHandler(this.cbPasswordVisible_CheckStateChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 40);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(52, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 36;
            this.lblLastName.Text = "Last name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(52, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(267, 22);
            this.txtLastName.TabIndex = 35;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(52, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(267, 22);
            this.txtFirstName.TabIndex = 34;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(52, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 33;
            this.lblFirstName.Text = "First name:";
            // 
            // btnAddLibrarian
            // 
            this.btnAddLibrarian.Location = new System.Drawing.Point(52, 304);
            this.btnAddLibrarian.Name = "btnAddLibrarian";
            this.btnAddLibrarian.Size = new System.Drawing.Size(129, 40);
            this.btnAddLibrarian.TabIndex = 32;
            this.btnAddLibrarian.Text = "Add Librarian";
            this.btnAddLibrarian.UseVisualStyleBackColor = true;
            this.btnAddLibrarian.Click += new System.EventHandler(this.btnAddLibrarian_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(52, 223);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(267, 22);
            this.txtPassword.TabIndex = 31;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(49, 204);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 30;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(49, 142);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(52, 161);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(267, 22);
            this.txtUsername.TabIndex = 28;
            // 
            // FrmNewLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 364);
            this.Controls.Add(this.cbPasswordVisible);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnAddLibrarian);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Name = "FrmNewLibrarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add librarian";
            this.Load += new System.EventHandler(this.FrmNewLibrarian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPasswordVisible;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAddLibrarian;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
    }
}