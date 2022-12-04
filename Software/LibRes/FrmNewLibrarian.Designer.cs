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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnFaceRecognition = new System.Windows.Forms.Button();
            this.btnAddLibrarian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 22);
            this.txtPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(62, 99);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(62, 37);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(65, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(157, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // btnFaceRecognition
            // 
            this.btnFaceRecognition.Location = new System.Drawing.Point(65, 146);
            this.btnFaceRecognition.Name = "btnFaceRecognition";
            this.btnFaceRecognition.Size = new System.Drawing.Size(157, 44);
            this.btnFaceRecognition.TabIndex = 10;
            this.btnFaceRecognition.Text = "Add Face For Recognition";
            this.btnFaceRecognition.UseVisualStyleBackColor = true;
            this.btnFaceRecognition.Click += new System.EventHandler(this.btnFaceRecognition_Click);
            // 
            // btnAddLibrarian
            // 
            this.btnAddLibrarian.Location = new System.Drawing.Point(84, 196);
            this.btnAddLibrarian.Name = "btnAddLibrarian";
            this.btnAddLibrarian.Size = new System.Drawing.Size(116, 30);
            this.btnAddLibrarian.TabIndex = 11;
            this.btnAddLibrarian.Text = "Add Librarian";
            this.btnAddLibrarian.UseVisualStyleBackColor = true;
            this.btnAddLibrarian.Click += new System.EventHandler(this.btnAddLibrarian_Click);
            // 
            // FrmNewLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 269);
            this.Controls.Add(this.btnAddLibrarian);
            this.Controls.Add(this.btnFaceRecognition);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Name = "FrmNewLibrarian";
            this.Text = "FrmNewLibrerian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnFaceRecognition;
        private System.Windows.Forms.Button btnAddLibrarian;
    }
}