namespace LibRes
{
    partial class FrmLibrarians
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
            this.dgvLibrarians = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddLibrarian = new System.Windows.Forms.Button();
            this.lblLibrarians = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarians)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibrarians
            // 
            this.dgvLibrarians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrarians.Location = new System.Drawing.Point(12, 28);
            this.dgvLibrarians.Name = "dgvLibrarians";
            this.dgvLibrarians.RowHeadersWidth = 51;
            this.dgvLibrarians.RowTemplate.Height = 24;
            this.dgvLibrarians.Size = new System.Drawing.Size(775, 408);
            this.dgvLibrarians.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(688, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(582, 442);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddLibrarian
            // 
            this.btnAddLibrarian.Location = new System.Drawing.Point(476, 442);
            this.btnAddLibrarian.Name = "btnAddLibrarian";
            this.btnAddLibrarian.Size = new System.Drawing.Size(100, 31);
            this.btnAddLibrarian.TabIndex = 3;
            this.btnAddLibrarian.Text = "Add New";
            this.btnAddLibrarian.UseVisualStyleBackColor = true;
            this.btnAddLibrarian.Click += new System.EventHandler(this.btnAddLibrarian_Click);
            // 
            // lblLibrarians
            // 
            this.lblLibrarians.AutoSize = true;
            this.lblLibrarians.Location = new System.Drawing.Point(12, 9);
            this.lblLibrarians.Name = "lblLibrarians";
            this.lblLibrarians.Size = new System.Drawing.Size(69, 16);
            this.lblLibrarians.TabIndex = 4;
            this.lblLibrarians.Text = "Librarians:";
            // 
            // FrmLibrarians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.lblLibrarians);
            this.Controls.Add(this.btnAddLibrarian);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvLibrarians);
            this.Name = "FrmLibrarians";
            this.Text = "FrmLibrarians";
            this.Load += new System.EventHandler(this.FrmLibrarians_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibrarians;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddLibrarian;
        private System.Windows.Forms.Label lblLibrarians;
    }
}