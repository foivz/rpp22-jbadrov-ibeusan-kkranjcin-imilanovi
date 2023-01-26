namespace LibRes
{
    partial class FrmBookSearch
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnViewBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.btnViewLibrarians = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.hpBookSearch = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(13, 100);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(861, 394);
            this.dgvBooks.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(773, 28);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(791, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(751, 500);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(123, 33);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnViewBook
            // 
            this.btnViewBook.Location = new System.Drawing.Point(644, 500);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Size = new System.Drawing.Size(101, 33);
            this.btnViewBook.TabIndex = 4;
            this.btnViewBook.Text = "View Book";
            this.btnViewBook.UseVisualStyleBackColor = true;
            this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(13, 12);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(118, 33);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add New Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMembers.Location = new System.Drawing.Point(756, 12);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(118, 33);
            this.btnMembers.TabIndex = 6;
            this.btnMembers.Text = "View Members";
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.Location = new System.Drawing.Point(520, 500);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(118, 33);
            this.btnAddCopy.TabIndex = 7;
            this.btnAddCopy.Text = "Add New Copy";
            this.btnAddCopy.UseVisualStyleBackColor = true;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAddCopy_Click);
            // 
            // btnViewLibrarians
            // 
            this.btnViewLibrarians.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewLibrarians.Location = new System.Drawing.Point(13, 500);
            this.btnViewLibrarians.Name = "btnViewLibrarians";
            this.btnViewLibrarians.Size = new System.Drawing.Size(118, 33);
            this.btnViewLibrarians.TabIndex = 8;
            this.btnViewLibrarians.Text = "View Librarians";
            this.btnViewLibrarians.UseVisualStyleBackColor = true;
            this.btnViewLibrarians.Visible = false;
            this.btnViewLibrarians.Click += new System.EventHandler(this.btnAddLibrerian_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Location = new System.Drawing.Point(137, 12);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(118, 33);
            this.btnBorrowBook.TabIndex = 9;
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            // 
            // hpBookSearch
            // 
            this.hpBookSearch.HelpNamespace = "S:\\FOI - 5.sem\\RPP\\HelpFiles\\FrmBookSearchHelp.html";
            // 
            // FrmBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(886, 545);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.btnViewLibrarians);
            this.Controls.Add(this.btnAddCopy);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnViewBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvBooks);
            this.hpBookSearch.SetHelpKeyword(this, "F1");
            this.Name = "FrmBookSearch";
            this.hpBookSearch.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmBookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnViewBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.Button btnViewLibrarians;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.HelpProvider hpBookSearch;
    }
}