namespace LibRes
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
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.txtNumberOfPages = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
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
            this.gbBookData = new System.Windows.Forms.GroupBox();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).BeginInit();
            this.gbBookData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.SuspendLayout();
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
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(3, 35);
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
            this.btnReserve.Location = new System.Drawing.Point(367, 524);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(104, 43);
            this.btnReserve.TabIndex = 21;
            this.btnReserve.Text = "Reserve Copy";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
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
            this.btnUpdateCopy.Location = new System.Drawing.Point(762, 527);
            this.btnUpdateCopy.Name = "btnUpdateCopy";
            this.btnUpdateCopy.Size = new System.Drawing.Size(104, 43);
            this.btnUpdateCopy.TabIndex = 30;
            this.btnUpdateCopy.Text = "Update Copy";
            this.btnUpdateCopy.UseVisualStyleBackColor = true;
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.Location = new System.Drawing.Point(652, 527);
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
            // gbBookData
            // 
            this.gbBookData.Controls.Add(this.dgvGenres);
            this.gbBookData.Controls.Add(this.dgvAuthors);
            this.gbBookData.Controls.Add(this.txtISBN);
            this.gbBookData.Controls.Add(this.lblISBN);
            this.gbBookData.Controls.Add(this.lblAuthor);
            this.gbBookData.Controls.Add(this.lblNumberOfPages);
            this.gbBookData.Controls.Add(this.lblGenre);
            this.gbBookData.Controls.Add(this.txtNumberOfPages);
            this.gbBookData.Controls.Add(this.btnUpdate);
            this.gbBookData.Location = new System.Drawing.Point(12, 29);
            this.gbBookData.Name = "gbBookData";
            this.gbBookData.Size = new System.Drawing.Size(253, 466);
            this.gbBookData.TabIndex = 35;
            this.gbBookData.TabStop = false;
            this.gbBookData.Text = "Selected book data";
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
            // dgvAuthors
            // 
            this.dgvAuthors.AllowUserToAddRows = false;
            this.dgvAuthors.AllowUserToDeleteRows = false;
            this.dgvAuthors.AllowUserToResizeColumns = false;
            this.dgvAuthors.AllowUserToResizeRows = false;
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Location = new System.Drawing.Point(6, 54);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.RowHeadersWidth = 51;
            this.dgvAuthors.RowTemplate.Height = 24;
            this.dgvAuthors.Size = new System.Drawing.Size(204, 92);
            this.dgvAuthors.TabIndex = 37;
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(477, 526);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(169, 41);
            this.btnDeleteReservation.TabIndex = 36;
            this.btnDeleteReservation.Text = "Cancel Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 582);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.gbBookData);
            this.Controls.Add(this.btnAddCopy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateCopy);
            this.Controls.Add(this.lblBookCopies);
            this.Controls.Add(this.dgvBookCopies);
            this.Controls.Add(this.btnReserveForMember);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.btnReserve);
            this.Name = "FrmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selected book";
            this.Load += new System.EventHandler(this.FrmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).EndInit();
            this.gbBookData.ResumeLayout(false);
            this.gbBookData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblNumberOfPages;
        private System.Windows.Forms.TextBox txtNumberOfPages;
        private System.Windows.Forms.Button btnReserve;
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
        private System.Windows.Forms.GroupBox gbBookData;
        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.Windows.Forms.Button btnDeleteReservation;
    }
}