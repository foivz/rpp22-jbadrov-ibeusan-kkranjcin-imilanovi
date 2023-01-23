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
            this.nudNumberOfPages = new System.Windows.Forms.NumericUpDown();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblBorrowable = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.chbBorrowable = new System.Windows.Forms.CheckBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clbGenres = new System.Windows.Forms.CheckedListBox();
            this.clbAuthors = new System.Windows.Forms.CheckedListBox();
            this.lblCannotFindAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(28, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // nudNumberOfPages
            // 
            this.nudNumberOfPages.Location = new System.Drawing.Point(31, 157);
            this.nudNumberOfPages.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNumberOfPages.Name = "nudNumberOfPages";
            this.nudNumberOfPages.Size = new System.Drawing.Size(188, 22);
            this.nudNumberOfPages.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(31, 84);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(188, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // lblBorrowable
            // 
            this.lblBorrowable.AutoSize = true;
            this.lblBorrowable.Location = new System.Drawing.Point(28, 29);
            this.lblBorrowable.Name = "lblBorrowable";
            this.lblBorrowable.Size = new System.Drawing.Size(75, 16);
            this.lblBorrowable.TabIndex = 5;
            this.lblBorrowable.Text = "Borowable:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(330, 30);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(63, 16);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author(s):";
            // 
            // lblNumberOfPages
            // 
            this.lblNumberOfPages.AutoSize = true;
            this.lblNumberOfPages.Location = new System.Drawing.Point(31, 138);
            this.lblNumberOfPages.Name = "lblNumberOfPages";
            this.lblNumberOfPages.Size = new System.Drawing.Size(117, 16);
            this.lblNumberOfPages.TabIndex = 7;
            this.lblNumberOfPages.Text = "Number Of Pages:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(330, 195);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(62, 16);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genre(s):";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(453, 321);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(108, 39);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // chbBorrowable
            // 
            this.chbBorrowable.AutoSize = true;
            this.chbBorrowable.Location = new System.Drawing.Point(122, 30);
            this.chbBorrowable.Name = "chbBorrowable";
            this.chbBorrowable.Size = new System.Drawing.Size(18, 17);
            this.chbBorrowable.TabIndex = 11;
            this.chbBorrowable.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(551, 144);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(129, 28);
            this.btnAddAuthor.TabIndex = 12;
            this.btnAddAuthor.Text = "Add New Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(28, 213);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(41, 16);
            this.lblISBN.TabIndex = 13;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(31, 233);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(185, 22);
            this.txtISBN.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(572, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 39);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // clbGenres
            // 
            this.clbGenres.FormattingEnabled = true;
            this.clbGenres.Location = new System.Drawing.Point(333, 213);
            this.clbGenres.Name = "clbGenres";
            this.clbGenres.Size = new System.Drawing.Size(347, 89);
            this.clbGenres.TabIndex = 16;
            // 
            // clbAuthors
            // 
            this.clbAuthors.FormattingEnabled = true;
            this.clbAuthors.Location = new System.Drawing.Point(333, 49);
            this.clbAuthors.Name = "clbAuthors";
            this.clbAuthors.Size = new System.Drawing.Size(347, 89);
            this.clbAuthors.TabIndex = 17;
            // 
            // lblCannotFindAuthor
            // 
            this.lblCannotFindAuthor.AutoSize = true;
            this.lblCannotFindAuthor.Location = new System.Drawing.Point(330, 149);
            this.lblCannotFindAuthor.Name = "lblCannotFindAuthor";
            this.lblCannotFindAuthor.Size = new System.Drawing.Size(202, 16);
            this.lblCannotFindAuthor.TabIndex = 18;
            this.lblCannotFindAuthor.Text = "Can\'t find the author for the book?";
            // 
            // FrmNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 372);
            this.Controls.Add(this.lblCannotFindAuthor);
            this.Controls.Add(this.clbAuthors);
            this.Controls.Add(this.clbGenres);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.chbBorrowable);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblNumberOfPages);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBorrowable);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.nudNumberOfPages);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new book";
            this.Load += new System.EventHandler(this.FrmNewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown nudNumberOfPages;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblBorrowable;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblNumberOfPages;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.CheckBox chbBorrowable;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox clbGenres;
        private System.Windows.Forms.CheckedListBox clbAuthors;
        private System.Windows.Forms.Label lblCannotFindAuthor;
    }
}