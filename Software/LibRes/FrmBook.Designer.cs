﻿namespace LibRes
{
    partial class FrmBook
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
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.txtNumberOfPages = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.btnReserveForMember = new System.Windows.Forms.Button();
            this.dgvBookCopies = new System.Windows.Forms.DataGridView();
            this.lblBookCopies = new System.Windows.Forms.Label();
            this.btnUpdateCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(3, 164);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(62, 16);
            this.lblGenre.TabIndex = 17;
            this.lblGenre.Text = "Genre(s):";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(6, 50);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(160, 22);
            this.txtTitle.TabIndex = 13;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(3, 84);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(63, 16);
            this.lblAuthor.TabIndex = 14;
            this.lblAuthor.Text = "Author(s):";
            // 
            // lblNumberOfPages
            // 
            this.lblNumberOfPages.AutoSize = true;
            this.lblNumberOfPages.Location = new System.Drawing.Point(6, 289);
            this.lblNumberOfPages.Name = "lblNumberOfPages";
            this.lblNumberOfPages.Size = new System.Drawing.Size(117, 16);
            this.lblNumberOfPages.TabIndex = 15;
            this.lblNumberOfPages.Text = "Number Of Pages:";
            // 
            // txtNumberOfPages
            // 
            this.txtNumberOfPages.Enabled = false;
            this.txtNumberOfPages.Location = new System.Drawing.Point(6, 308);
            this.txtNumberOfPages.Name = "txtNumberOfPages";
            this.txtNumberOfPages.Size = new System.Drawing.Size(163, 22);
            this.txtNumberOfPages.TabIndex = 20;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(530, 527);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(104, 43);
            this.btnReserve.TabIndex = 21;
            this.btnReserve.Text = "Reserve Copy";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(420, 527);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(104, 43);
            this.btnBorrow.TabIndex = 22;
            this.btnBorrow.Text = "Borrow Copy";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 412);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 43);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update book data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbMember
            // 
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(12, 537);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(160, 24);
            this.cmbMember.TabIndex = 25;
            this.cmbMember.Visible = false;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(9, 518);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(104, 16);
            this.lblMember.TabIndex = 26;
            this.lblMember.Text = "Library Member:";
            this.lblMember.Visible = false;
            // 
            // btnReserveForMember
            // 
            this.btnReserveForMember.Location = new System.Drawing.Point(178, 525);
            this.btnReserveForMember.Name = "btnReserveForMember";
            this.btnReserveForMember.Size = new System.Drawing.Size(104, 43);
            this.btnReserveForMember.TabIndex = 27;
            this.btnReserveForMember.Text = "Reserve";
            this.btnReserveForMember.UseVisualStyleBackColor = true;
            this.btnReserveForMember.Visible = false;
            this.btnReserveForMember.Click += new System.EventHandler(this.btnReserveForMember_Click);
            // 
            // dgvBookCopies
            // 
            this.dgvBookCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookCopies.Location = new System.Drawing.Point(294, 48);
            this.dgvBookCopies.Name = "dgvBookCopies";
            this.dgvBookCopies.RowHeadersWidth = 51;
            this.dgvBookCopies.RowTemplate.Height = 24;
            this.dgvBookCopies.Size = new System.Drawing.Size(682, 447);
            this.dgvBookCopies.TabIndex = 28;
            // 
            // lblBookCopies
            // 
            this.lblBookCopies.AutoSize = true;
            this.lblBookCopies.Location = new System.Drawing.Point(291, 29);
            this.lblBookCopies.Name = "lblBookCopies";
            this.lblBookCopies.Size = new System.Drawing.Size(86, 16);
            this.lblBookCopies.TabIndex = 29;
            this.lblBookCopies.Text = "Book copies:";
            // 
            // btnUpdateCopy
            // 
            this.btnUpdateCopy.Location = new System.Drawing.Point(755, 527);
            this.btnUpdateCopy.Name = "btnUpdateCopy";
            this.btnUpdateCopy.Size = new System.Drawing.Size(104, 43);
            this.btnUpdateCopy.TabIndex = 30;
            this.btnUpdateCopy.Text = "Update Copy";
            this.btnUpdateCopy.UseVisualStyleBackColor = true;
            this.btnUpdateCopy.Visible = false;
            this.btnUpdateCopy.Click += new System.EventHandler(this.btnUpdateCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(872, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 43);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete Copy";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.Location = new System.Drawing.Point(638, 527);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(104, 43);
            this.btnAddCopy.TabIndex = 32;
            this.btnAddCopy.Text = "Add copy";
            this.btnAddCopy.UseVisualStyleBackColor = true;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAddCopy_Click);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(6, 347);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(41, 16);
            this.lblISBN.TabIndex = 33;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(6, 366);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(160, 22);
            this.txtISBN.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGenres);
            this.groupBox1.Controls.Add(this.dgvAuthors);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.lblISBN);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblNumberOfPages);
            this.groupBox1.Controls.Add(this.lblGenre);
            this.groupBox1.Controls.Add(this.txtNumberOfPages);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 466);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected book data";
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.AllowUserToAddRows = false;
            this.dgvAuthors.AllowUserToDeleteRows = false;
            this.dgvAuthors.AllowUserToResizeColumns = false;
            this.dgvAuthors.AllowUserToResizeRows = false;
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Location = new System.Drawing.Point(6, 104);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.RowHeadersWidth = 51;
            this.dgvAuthors.RowTemplate.Height = 24;
            this.dgvAuthors.Size = new System.Drawing.Size(204, 43);
            this.dgvAuthors.TabIndex = 37;
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.AllowUserToResizeColumns = false;
            this.dgvGenres.AllowUserToResizeRows = false;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.Location = new System.Drawing.Point(6, 183);
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.RowHeadersWidth = 51;
            this.dgvGenres.RowTemplate.Height = 24;
            this.dgvGenres.Size = new System.Drawing.Size(204, 92);
            this.dgvGenres.TabIndex = 38;
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 582);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddCopy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateCopy);
            this.Controls.Add(this.lblBookCopies);
            this.Controls.Add(this.dgvBookCopies);
            this.Controls.Add(this.btnReserveForMember);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnReserve);
            this.Name = "FrmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selected book";
            this.Load += new System.EventHandler(this.FrmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblNumberOfPages;
        private System.Windows.Forms.TextBox txtNumberOfPages;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Button btnReserveForMember;
        private System.Windows.Forms.DataGridView dgvBookCopies;
        private System.Windows.Forms.Label lblBookCopies;
        private System.Windows.Forms.Button btnUpdateCopy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.DataGridView dgvGenres;
    }
}