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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(41, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(41, 145);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(47, 16);
            this.lblGenre.TabIndex = 17;
            this.lblGenre.Text = "Genre:";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(44, 48);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(160, 22);
            this.txtTitle.TabIndex = 13;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(41, 82);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(48, 16);
            this.lblAuthor.TabIndex = 14;
            this.lblAuthor.Text = "Author:";
            // 
            // lblNumberOfPages
            // 
            this.lblNumberOfPages.AutoSize = true;
            this.lblNumberOfPages.Location = new System.Drawing.Point(41, 206);
            this.lblNumberOfPages.Name = "lblNumberOfPages";
            this.lblNumberOfPages.Size = new System.Drawing.Size(117, 16);
            this.lblNumberOfPages.TabIndex = 15;
            this.lblNumberOfPages.Text = "Number Of Pages:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(44, 101);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(160, 22);
            this.txtAuthor.TabIndex = 18;
            // 
            // txtGenre
            // 
            this.txtGenre.Enabled = false;
            this.txtGenre.Location = new System.Drawing.Point(44, 164);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(160, 22);
            this.txtGenre.TabIndex = 19;
            // 
            // txtNumberOfPages
            // 
            this.txtNumberOfPages.Enabled = false;
            this.txtNumberOfPages.Location = new System.Drawing.Point(44, 225);
            this.txtNumberOfPages.Name = "txtNumberOfPages";
            this.txtNumberOfPages.Size = new System.Drawing.Size(160, 22);
            this.txtNumberOfPages.TabIndex = 20;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(469, 369);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(102, 30);
            this.btnReserve.TabIndex = 21;
            this.btnReserve.Text = "Reserve Copy";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(365, 369);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(98, 30);
            this.btnBorrow.TabIndex = 22;
            this.btnBorrow.Text = "Borrow Copy";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(44, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbMember
            // 
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(44, 375);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(160, 24);
            this.cmbMember.TabIndex = 25;
            this.cmbMember.Visible = false;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(41, 356);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(104, 16);
            this.lblMember.TabIndex = 26;
            this.lblMember.Text = "Library Member:";
            this.lblMember.Visible = false;
            // 
            // btnReserveForMember
            // 
            this.btnReserveForMember.Location = new System.Drawing.Point(210, 369);
            this.btnReserveForMember.Name = "btnReserveForMember";
            this.btnReserveForMember.Size = new System.Drawing.Size(75, 30);
            this.btnReserveForMember.TabIndex = 27;
            this.btnReserveForMember.Text = "Reserve";
            this.btnReserveForMember.UseVisualStyleBackColor = true;
            this.btnReserveForMember.Visible = false;
            this.btnReserveForMember.Click += new System.EventHandler(this.btnReserveForMember_Click);
            // 
            // dgvBookCopies
            // 
            this.dgvBookCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookCopies.Location = new System.Drawing.Point(236, 48);
            this.dgvBookCopies.Name = "dgvBookCopies";
            this.dgvBookCopies.RowHeadersWidth = 51;
            this.dgvBookCopies.RowTemplate.Height = 24;
            this.dgvBookCopies.Size = new System.Drawing.Size(569, 315);
            this.dgvBookCopies.TabIndex = 28;
            // 
            // lblBookCopies
            // 
            this.lblBookCopies.AutoSize = true;
            this.lblBookCopies.Location = new System.Drawing.Point(233, 29);
            this.lblBookCopies.Name = "lblBookCopies";
            this.lblBookCopies.Size = new System.Drawing.Size(86, 16);
            this.lblBookCopies.TabIndex = 29;
            this.lblBookCopies.Text = "Book copies:";
            // 
            // btnUpdateCopy
            // 
            this.btnUpdateCopy.Location = new System.Drawing.Point(577, 369);
            this.btnUpdateCopy.Name = "btnUpdateCopy";
            this.btnUpdateCopy.Size = new System.Drawing.Size(111, 30);
            this.btnUpdateCopy.TabIndex = 30;
            this.btnUpdateCopy.Text = "Update Copy";
            this.btnUpdateCopy.UseVisualStyleBackColor = true;
            this.btnUpdateCopy.Visible = false;
            this.btnUpdateCopy.Click += new System.EventHandler(this.btnUpdateCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(694, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 30);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete Copy";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 413);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateCopy);
            this.Controls.Add(this.lblBookCopies);
            this.Controls.Add(this.dgvBookCopies);
            this.Controls.Add(this.btnReserveForMember);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.txtNumberOfPages);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblNumberOfPages);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmBook";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblNumberOfPages;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtGenre;
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
    }
}