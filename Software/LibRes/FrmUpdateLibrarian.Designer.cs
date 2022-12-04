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
            this.btnUpdateLibrarian = new System.Windows.Forms.Button();
            this.btnUpdateFaceRecognition = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateLibrarian
            // 
            this.btnUpdateLibrarian.Location = new System.Drawing.Point(84, 197);
            this.btnUpdateLibrarian.Name = "btnUpdateLibrarian";
            this.btnUpdateLibrarian.Size = new System.Drawing.Size(116, 30);
            this.btnUpdateLibrarian.TabIndex = 17;
            this.btnUpdateLibrarian.Text = "Update Librarian";
            this.btnUpdateLibrarian.UseVisualStyleBackColor = true;
            this.btnUpdateLibrarian.Click += new System.EventHandler(this.btnUpdateLibrarian_Click);
            // 
            // btnUpdateFaceRecognition
            // 
            this.btnUpdateFaceRecognition.Location = new System.Drawing.Point(65, 147);
            this.btnUpdateFaceRecognition.Name = "btnUpdateFaceRecognition";
            this.btnUpdateFaceRecognition.Size = new System.Drawing.Size(157, 44);
            this.btnUpdateFaceRecognition.TabIndex = 16;
            this.btnUpdateFaceRecognition.Text = "Update Face For Recognition";
            this.btnUpdateFaceRecognition.UseVisualStyleBackColor = true;
            this.btnUpdateFaceRecognition.Click += new System.EventHandler(this.btnUpdateFaceRecognition_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 22);
            this.txtPassword.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(62, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(62, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(65, 57);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(157, 22);
            this.txtUsername.TabIndex = 12;
            // 
            // FrmUpdateLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 269);
            this.Controls.Add(this.btnUpdateLibrarian);
            this.Controls.Add(this.btnUpdateFaceRecognition);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Name = "FrmUpdateLibrarian";
            this.Text = "FrmUpdateLibrarian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateLibrarian;
        private System.Windows.Forms.Button btnUpdateFaceRecognition;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
    }
}