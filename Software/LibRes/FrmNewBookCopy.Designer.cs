namespace LibRes
{
    partial class FrmNewBookCopy
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
            this.lblBook = new System.Windows.Forms.Label();
            this.btnAddBookCopy = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(57, 47);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(42, 16);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Book:";
            // 
            // btnAddBookCopy
            // 
            this.btnAddBookCopy.Location = new System.Drawing.Point(79, 185);
            this.btnAddBookCopy.Name = "btnAddBookCopy";
            this.btnAddBookCopy.Size = new System.Drawing.Size(111, 35);
            this.btnAddBookCopy.TabIndex = 6;
            this.btnAddBookCopy.Text = "Add Book Copy";
            this.btnAddBookCopy.UseVisualStyleBackColor = true;
            this.btnAddBookCopy.Click += new System.EventHandler(this.btnAddBookCopy_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(57, 95);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(66, 16);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Publisher:";
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Location = new System.Drawing.Point(69, 144);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(130, 35);
            this.btnAddPublisher.TabIndex = 9;
            this.btnAddPublisher.Text = "Add New Publisher";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(60, 66);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(151, 22);
            this.txtBook.TabIndex = 10;
            // 
            // FrmNewBookCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 264);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.btnAddBookCopy);
            this.Controls.Add(this.lblBook);
            this.Name = "FrmNewBookCopy";
            this.Text = "FrmNewBookCopy";
            this.Load += new System.EventHandler(this.FrmNewBookCopy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Button btnAddBookCopy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.TextBox txtBook;
    }
}