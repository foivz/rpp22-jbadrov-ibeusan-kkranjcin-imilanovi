namespace LibRes
{
    partial class FrmBooksOverview
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
            this.lblReservedBooks = new System.Windows.Forms.Label();
            this.dgvReservedBooks = new System.Windows.Forms.DataGridView();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.lblBorrowedBooks = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReservedBooks
            // 
            this.lblReservedBooks.AutoSize = true;
            this.lblReservedBooks.Location = new System.Drawing.Point(12, 9);
            this.lblReservedBooks.Name = "lblReservedBooks";
            this.lblReservedBooks.Size = new System.Drawing.Size(70, 16);
            this.lblReservedBooks.TabIndex = 0;
            this.lblReservedBooks.Text = "Reserved:";
            // 
            // dgvReservedBooks
            // 
            this.dgvReservedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservedBooks.Location = new System.Drawing.Point(15, 28);
            this.dgvReservedBooks.Name = "dgvReservedBooks";
            this.dgvReservedBooks.RowHeadersWidth = 51;
            this.dgvReservedBooks.RowTemplate.Height = 24;
            this.dgvReservedBooks.Size = new System.Drawing.Size(867, 266);
            this.dgvReservedBooks.TabIndex = 1;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(790, 300);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(92, 31);
            this.btnBorrow.TabIndex = 2;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(15, 334);
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.RowHeadersWidth = 51;
            this.dgvBorrowedBooks.RowTemplate.Height = 24;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(867, 266);
            this.dgvBorrowedBooks.TabIndex = 4;
            // 
            // lblBorrowedBooks
            // 
            this.lblBorrowedBooks.AutoSize = true;
            this.lblBorrowedBooks.Location = new System.Drawing.Point(12, 315);
            this.lblBorrowedBooks.Name = "lblBorrowedBooks";
            this.lblBorrowedBooks.Size = new System.Drawing.Size(68, 16);
            this.lblBorrowedBooks.TabIndex = 3;
            this.lblBorrowedBooks.Text = "Borrowed:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(790, 606);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(92, 31);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmBooksOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 645);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvBorrowedBooks);
            this.Controls.Add(this.lblBorrowedBooks);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dgvReservedBooks);
            this.Controls.Add(this.lblReservedBooks);
            this.Name = "FrmBooksOverview";
            this.Text = "v";
            this.Load += new System.EventHandler(this.FrmBooksOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservedBooks;
        private System.Windows.Forms.DataGridView dgvReservedBooks;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private System.Windows.Forms.Label lblBorrowedBooks;
        private System.Windows.Forms.Button btnReturn;
    }
}