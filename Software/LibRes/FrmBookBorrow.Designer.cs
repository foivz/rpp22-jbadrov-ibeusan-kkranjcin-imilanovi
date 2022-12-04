namespace LibRes
{
    partial class FrmBookBorrow
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
            this.btnScanMember = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnScanBook = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScanMember
            // 
            this.btnScanMember.Location = new System.Drawing.Point(50, 72);
            this.btnScanMember.Name = "btnScanMember";
            this.btnScanMember.Size = new System.Drawing.Size(121, 23);
            this.btnScanMember.TabIndex = 0;
            this.btnScanMember.Text = "Scan Member";
            this.btnScanMember.UseVisualStyleBackColor = true;
            this.btnScanMember.Click += new System.EventHandler(this.btnScanMember_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(177, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // btnScanBook
            // 
            this.btnScanBook.Location = new System.Drawing.Point(177, 72);
            this.btnScanBook.Name = "btnScanBook";
            this.btnScanBook.Size = new System.Drawing.Size(121, 23);
            this.btnScanBook.TabIndex = 2;
            this.btnScanBook.Text = "Scan Book";
            this.btnScanBook.UseVisualStyleBackColor = true;
            this.btnScanBook.Click += new System.EventHandler(this.btnScanBook_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(80, 131);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(91, 28);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmBookBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 235);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnScanBook);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnScanMember);
            this.Name = "FrmBookBorrow";
            this.Text = "FrmBookBorrow";
            this.Load += new System.EventHandler(this.FrmBookBorrow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScanMember;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnScanBook;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnCancel;
    }
}