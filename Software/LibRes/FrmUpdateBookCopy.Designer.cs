namespace LibRes
{
    partial class FrmUpdateBookCopy
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
            this.txtBook = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.btnUpdateBookCopy = new System.Windows.Forms.Button();
            this.lblBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(60, 68);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(151, 22);
            this.txtBook.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(57, 97);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(66, 16);
            this.lblPublisher.TabIndex = 15;
            this.lblPublisher.Text = "Publisher:";
            // 
            // btnUpdateBookCopy
            // 
            this.btnUpdateBookCopy.Location = new System.Drawing.Point(68, 146);
            this.btnUpdateBookCopy.Name = "btnUpdateBookCopy";
            this.btnUpdateBookCopy.Size = new System.Drawing.Size(132, 35);
            this.btnUpdateBookCopy.TabIndex = 14;
            this.btnUpdateBookCopy.Text = "Update Book Copy";
            this.btnUpdateBookCopy.UseVisualStyleBackColor = true;
            this.btnUpdateBookCopy.Click += new System.EventHandler(this.btnUpdateBookCopy_Click);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(57, 49);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(42, 16);
            this.lblBook.TabIndex = 11;
            this.lblBook.Text = "Book:";
            // 
            // FrmUpdateBookCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 239);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.btnUpdateBookCopy);
            this.Controls.Add(this.lblBook);
            this.Name = "FrmUpdateBookCopy";
            this.Text = "FrmUpdateBookCopy";
            this.Load += new System.EventHandler(this.FrmUpdateBookCopy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Button btnUpdateBookCopy;
        private System.Windows.Forms.Label lblBook;
    }
}