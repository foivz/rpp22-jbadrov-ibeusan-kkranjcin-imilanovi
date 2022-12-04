namespace LibRes
{
    partial class FrmBookReturn
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbBookCopy = new System.Windows.Forms.ComboBox();
            this.btnScanBook = new System.Windows.Forms.Button();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.btnScanMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(80, 122);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 28);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmbBookCopy
            // 
            this.cmbBookCopy.FormattingEnabled = true;
            this.cmbBookCopy.Location = new System.Drawing.Point(177, 92);
            this.cmbBookCopy.Name = "cmbBookCopy";
            this.cmbBookCopy.Size = new System.Drawing.Size(121, 24);
            this.cmbBookCopy.TabIndex = 9;
            // 
            // btnScanBook
            // 
            this.btnScanBook.Location = new System.Drawing.Point(177, 63);
            this.btnScanBook.Name = "btnScanBook";
            this.btnScanBook.Size = new System.Drawing.Size(121, 23);
            this.btnScanBook.TabIndex = 8;
            this.btnScanBook.Text = "Scan Book";
            this.btnScanBook.UseVisualStyleBackColor = true;
            this.btnScanBook.Click += new System.EventHandler(this.btnScanBook_Click);
            // 
            // cmbMember
            // 
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(50, 92);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(121, 24);
            this.cmbMember.TabIndex = 7;
            // 
            // btnScanMember
            // 
            this.btnScanMember.Location = new System.Drawing.Point(50, 63);
            this.btnScanMember.Name = "btnScanMember";
            this.btnScanMember.Size = new System.Drawing.Size(121, 23);
            this.btnScanMember.TabIndex = 6;
            this.btnScanMember.Text = "Scan Member";
            this.btnScanMember.UseVisualStyleBackColor = true;
            this.btnScanMember.Click += new System.EventHandler(this.btnScanMember_Click);
            // 
            // FrmBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 235);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cmbBookCopy);
            this.Controls.Add(this.btnScanBook);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.btnScanMember);
            this.Name = "FrmBookReturn";
            this.Text = "FrmBookReturn";
            this.Load += new System.EventHandler(this.FrmBookReturn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbBookCopy;
        private System.Windows.Forms.Button btnScanBook;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Button btnScanMember;
    }
}