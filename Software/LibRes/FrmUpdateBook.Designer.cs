namespace LibRes
{
    partial class FrmUpdateBook
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
            this.clbAuthors = new System.Windows.Forms.CheckedListBox();
            this.clbGenres = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.chbBorrowable = new System.Windows.Forms.CheckBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBorrowable = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.nudNumberOfPages = new System.Windows.Forms.NumericUpDown();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPages)).BeginInit();
            this.SuspendLayout();
            // 
            // clbAuthors
            // 
            this.clbAuthors.FormattingEnabled = true;
            this.clbAuthors.Location = new System.Drawing.Point(331, 47);
            this.clbAuthors.Name = "clbAuthors";
            this.clbAuthors.Size = new System.Drawing.Size(313, 174);
            this.clbAuthors.TabIndex = 33;
            // 
            // clbGenres
            // 
            this.clbGenres.FormattingEnabled = true;
            this.clbGenres.Location = new System.Drawing.Point(331, 256);
            this.clbGenres.Name = "clbGenres";
            this.clbGenres.Size = new System.Drawing.Size(313, 174);
            this.clbGenres.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(536, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 39);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(29, 231);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(185, 22);
            this.txtISBN.TabIndex = 30;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(26, 211);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(41, 16);
            this.lblISBN.TabIndex = 29;
            this.lblISBN.Text = "ISBN:";
            // 
            // chbBorrowable
            // 
            this.chbBorrowable.AutoSize = true;
            this.chbBorrowable.Location = new System.Drawing.Point(120, 28);
            this.chbBorrowable.Name = "chbBorrowable";
            this.chbBorrowable.Size = new System.Drawing.Size(18, 17);
            this.chbBorrowable.TabIndex = 27;
            this.chbBorrowable.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(419, 458);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(108, 39);
            this.btnUpdateBook.TabIndex = 26;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(328, 238);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(62, 16);
            this.lblGenre.TabIndex = 25;
            this.lblGenre.Text = "Genre(s):";
            // 
            // lblNumberOfPages
            // 
            this.lblNumberOfPages.AutoSize = true;
            this.lblNumberOfPages.Location = new System.Drawing.Point(29, 136);
            this.lblNumberOfPages.Name = "lblNumberOfPages";
            this.lblNumberOfPages.Size = new System.Drawing.Size(117, 16);
            this.lblNumberOfPages.TabIndex = 24;
            this.lblNumberOfPages.Text = "Number Of Pages:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(328, 28);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(63, 16);
            this.lblAuthor.TabIndex = 23;
            this.lblAuthor.Text = "Author(s):";
            // 
            // lblBorrowable
            // 
            this.lblBorrowable.AutoSize = true;
            this.lblBorrowable.Location = new System.Drawing.Point(26, 27);
            this.lblBorrowable.Name = "lblBorrowable";
            this.lblBorrowable.Size = new System.Drawing.Size(75, 16);
            this.lblBorrowable.TabIndex = 22;
            this.lblBorrowable.Text = "Borowable:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(29, 82);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(188, 22);
            this.txtTitle.TabIndex = 21;
            // 
            // nudNumberOfPages
            // 
            this.nudNumberOfPages.Location = new System.Drawing.Point(29, 155);
            this.nudNumberOfPages.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNumberOfPages.Name = "nudNumberOfPages";
            this.nudNumberOfPages.Size = new System.Drawing.Size(188, 22);
            this.nudNumberOfPages.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Title:";
            // 
            // FrmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 509);
            this.Controls.Add(this.clbAuthors);
            this.Controls.Add(this.clbGenres);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.chbBorrowable);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblNumberOfPages);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBorrowable);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.nudNumberOfPages);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update book";
            this.Load += new System.EventHandler(this.FrmUpdateBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbAuthors;
        private System.Windows.Forms.CheckedListBox clbGenres;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.CheckBox chbBorrowable;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblNumberOfPages;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBorrowable;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.NumericUpDown nudNumberOfPages;
        private System.Windows.Forms.Label lblTitle;
    }
}