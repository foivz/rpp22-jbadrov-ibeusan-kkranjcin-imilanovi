namespace LibRes
{
    partial class FrmLibraryMember
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
            this.dgvMembersBooks = new System.Windows.Forms.DataGridView();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblBooks = new System.Windows.Forms.Label();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembersBooks
            // 
            this.dgvMembersBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembersBooks.Location = new System.Drawing.Point(22, 79);
            this.dgvMembersBooks.Name = "dgvMembersBooks";
            this.dgvMembersBooks.RowHeadersWidth = 51;
            this.dgvMembersBooks.RowTemplate.Height = 24;
            this.dgvMembersBooks.Size = new System.Drawing.Size(776, 293);
            this.dgvMembersBooks.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(500, 23);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.Enabled = false;
            this.txtMemberEmail.Location = new System.Drawing.Point(550, 17);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.Size = new System.Drawing.Size(152, 22);
            this.txtMemberEmail.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(342, 17);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(152, 22);
            this.txtLastName.TabIndex = 11;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(261, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 16);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(22, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 16);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(103, 14);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(152, 22);
            this.txtFirstName.TabIndex = 7;
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(19, 60);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(109, 16);
            this.lblBooks.TabIndex = 14;
            this.lblBooks.Text = "Members Books:";
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateMember.Location = new System.Drawing.Point(676, 378);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(123, 32);
            this.btnUpdateMember.TabIndex = 15;
            this.btnUpdateMember.Text = "Update Member";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // FrmLibraryMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 422);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMemberEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dgvMembersBooks);
            this.Name = "FrmLibraryMember";
            this.Text = "FrmLibraryMember";
            this.Load += new System.EventHandler(this.FrmLibraryMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembersBooks;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Button btnUpdateMember;
    }
}