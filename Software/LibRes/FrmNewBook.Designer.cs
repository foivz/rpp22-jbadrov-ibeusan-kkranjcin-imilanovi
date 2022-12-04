namespace LibRes
{
    partial class FrmNewBook
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.nudNumberOfPages = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblBorrowable = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.chbBorrowable = new System.Windows.Forms.CheckBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(86, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(89, 141);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(160, 24);
            this.cmbAuthors.TabIndex = 2;
            // 
            // nudNumberOfPages
            // 
            this.nudNumberOfPages.Location = new System.Drawing.Point(89, 284);
            this.nudNumberOfPages.Name = "nudNumberOfPages";
            this.nudNumberOfPages.Size = new System.Drawing.Size(160, 22);
            this.nudNumberOfPages.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 22);
            this.textBox2.TabIndex = 4;
            // 
            // lblBorrowable
            // 
            this.lblBorrowable.AutoSize = true;
            this.lblBorrowable.Location = new System.Drawing.Point(86, 42);
            this.lblBorrowable.Name = "lblBorrowable";
            this.lblBorrowable.Size = new System.Drawing.Size(75, 16);
            this.lblBorrowable.TabIndex = 5;
            this.lblBorrowable.Text = "Borowable:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(86, 122);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(48, 16);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author:";
            // 
            // lblNumberOfPages
            // 
            this.lblNumberOfPages.AutoSize = true;
            this.lblNumberOfPages.Location = new System.Drawing.Point(86, 265);
            this.lblNumberOfPages.Name = "lblNumberOfPages";
            this.lblNumberOfPages.Size = new System.Drawing.Size(117, 16);
            this.lblNumberOfPages.TabIndex = 7;
            this.lblNumberOfPages.Text = "Number Of Pages:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(86, 204);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(47, 16);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genre:";
            // 
            // cmbGenres
            // 
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(89, 223);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(160, 24);
            this.cmbGenres.TabIndex = 8;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(120, 314);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(98, 28);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // chbBorrowable
            // 
            this.chbBorrowable.AutoSize = true;
            this.chbBorrowable.Location = new System.Drawing.Point(231, 43);
            this.chbBorrowable.Name = "chbBorrowable";
            this.chbBorrowable.Size = new System.Drawing.Size(18, 17);
            this.chbBorrowable.TabIndex = 11;
            this.chbBorrowable.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(103, 171);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(129, 28);
            this.btnAddAuthor.TabIndex = 12;
            this.btnAddAuthor.Text = "Add New Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // FrmNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 393);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.chbBorrowable);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenres);
            this.Controls.Add(this.lblNumberOfPages);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBorrowable);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nudNumberOfPages);
            this.Controls.Add(this.cmbAuthors);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNewBook";
            this.Text = "FrmNewBook";
            this.Load += new System.EventHandler(this.FrmNewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbAuthors;
        private System.Windows.Forms.NumericUpDown nudNumberOfPages;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblBorrowable;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblNumberOfPages;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbGenres;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.CheckBox chbBorrowable;
        private System.Windows.Forms.Button btnAddAuthor;
    }
}