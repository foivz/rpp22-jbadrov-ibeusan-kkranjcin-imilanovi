namespace LibRes
{
    partial class FrmLibraryMemberSearch
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
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.btnSearchMembers = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnVewMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(13, 46);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(772, 344);
            this.dgvMembers.TabIndex = 0;
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMember.Location = new System.Drawing.Point(13, 12);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(657, 28);
            this.txtSearchMember.TabIndex = 1;
            // 
            // btnSearchMembers
            // 
            this.btnSearchMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchMembers.Location = new System.Drawing.Point(676, 12);
            this.btnSearchMembers.Name = "btnSearchMembers";
            this.btnSearchMembers.Size = new System.Drawing.Size(109, 28);
            this.btnSearchMembers.TabIndex = 2;
            this.btnSearchMembers.Text = "Search";
            this.btnSearchMembers.UseVisualStyleBackColor = true;
            this.btnSearchMembers.Click += new System.EventHandler(this.btnSearchMembers_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMember.Location = new System.Drawing.Point(668, 420);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(117, 32);
            this.btnDeleteMember.TabIndex = 3;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMember.Location = new System.Drawing.Point(408, 420);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(133, 32);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Add New Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnVewMember
            // 
            this.btnVewMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVewMember.Location = new System.Drawing.Point(547, 420);
            this.btnVewMember.Name = "btnVewMember";
            this.btnVewMember.Size = new System.Drawing.Size(115, 32);
            this.btnVewMember.TabIndex = 5;
            this.btnVewMember.Text = "View Member";
            this.btnVewMember.UseVisualStyleBackColor = true;
            // 
            // FrmLibraryMemberSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 464);
            this.Controls.Add(this.btnVewMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnSearchMembers);
            this.Controls.Add(this.txtSearchMember);
            this.Controls.Add(this.dgvMembers);
            this.Name = "FrmLibraryMemberSearch";
            this.Text = "FrmMember";
            this.Load += new System.EventHandler(this.FrmLibraryMemberSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Button btnSearchMembers;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnVewMember;
    }
}