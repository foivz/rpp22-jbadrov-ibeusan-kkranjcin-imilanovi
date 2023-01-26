namespace LibRes
{
    partial class FrmUpdateLibrarian
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnUpdateLibrarian = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbPasswordVisible = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 40);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(51, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 25;
            this.lblLastName.Text = "Last name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(51, 107);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(267, 22);
            this.txtLastName.TabIndex = 24;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(51, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(267, 22);
            this.txtFirstName.TabIndex = 23;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(51, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First name:";
            // 
            // btnUpdateLibrarian
            // 
            this.btnUpdateLibrarian.Location = new System.Drawing.Point(51, 312);
            this.btnUpdateLibrarian.Name = "btnUpdateLibrarian";
            this.btnUpdateLibrarian.Size = new System.Drawing.Size(129, 40);
            this.btnUpdateLibrarian.TabIndex = 21;
            this.btnUpdateLibrarian.Text = "Update Librarian";
            this.btnUpdateLibrarian.UseVisualStyleBackColor = true;
            this.btnUpdateLibrarian.Click += new System.EventHandler(this.btnUpdateLibrarian_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(51, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(267, 22);
            this.txtPassword.TabIndex = 20;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(48, 212);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(48, 150);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(51, 169);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(267, 22);
            this.txtUsername.TabIndex = 17;
            // 
            // cbPasswordVisible
            // 
            this.cbPasswordVisible.AutoSize = true;
            this.cbPasswordVisible.Location = new System.Drawing.Point(160, 259);
            this.cbPasswordVisible.Name = "cbPasswordVisible";
            this.cbPasswordVisible.Size = new System.Drawing.Size(158, 20);
            this.cbPasswordVisible.TabIndex = 27;
            this.cbPasswordVisible.Text = "Show/Hide Password";
            this.cbPasswordVisible.UseVisualStyleBackColor = true;
            this.cbPasswordVisible.CheckStateChanged += new System.EventHandler(this.cbPasswordVisible_CheckStateChanged);
            // 
            // FrmUpdateLibrarian
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
            this.Controls.Add(this.btnUpdateLibrarian);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Name = "FrmUpdateLibrarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update librarian";
            this.Load += new System.EventHandler(this.FrmUpdateLibrarian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnUpdateLibrarian;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox cbPasswordVisible;
    }
}