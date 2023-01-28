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
            this.pnFilter = new System.Windows.Forms.Panel();
            this.btnLastNameDesc = new System.Windows.Forms.Button();
            this.btnLastNameAsc = new System.Windows.Forms.Button();
            this.btnFirstNameDesc = new System.Windows.Forms.Button();
            this.btnFirstNameAsc = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.pnFilter.SuspendLayout();
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
            this.dgvMembers.Size = new System.Drawing.Size(806, 344);
            this.dgvMembers.TabIndex = 0;
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMember.Location = new System.Drawing.Point(13, 12);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(657, 28);
            this.txtSearchMember.TabIndex = 1;
            this.txtSearchMember.TextChanged += new System.EventHandler(this.txtSearchMember_TextChanged);
            // 
            // btnSearchMembers
            // 
            this.btnSearchMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchMembers.Location = new System.Drawing.Point(673, 12);
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
            this.btnDeleteMember.Location = new System.Drawing.Point(702, 420);
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
            this.btnAddMember.Location = new System.Drawing.Point(442, 420);
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
            this.btnVewMember.Location = new System.Drawing.Point(581, 420);
            this.btnVewMember.Name = "btnVewMember";
            this.btnVewMember.Size = new System.Drawing.Size(115, 32);
            this.btnVewMember.TabIndex = 5;
            this.btnVewMember.Text = "View Member";
            this.btnVewMember.UseVisualStyleBackColor = true;
            this.btnVewMember.Click += new System.EventHandler(this.btnViewMember_Click);
            // 
            // pnFilter
            // 
            this.pnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFilter.Controls.Add(this.btnLastNameDesc);
            this.pnFilter.Controls.Add(this.btnLastNameAsc);
            this.pnFilter.Controls.Add(this.btnFirstNameDesc);
            this.pnFilter.Controls.Add(this.btnFirstNameAsc);
            this.pnFilter.Location = new System.Drawing.Point(619, 48);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(200, 153);
            this.pnFilter.TabIndex = 7;
            this.pnFilter.Visible = false;
            // 
            // btnLastNameDesc
            // 
            this.btnLastNameDesc.BackColor = System.Drawing.SystemColors.Control;
            this.btnLastNameDesc.Location = new System.Drawing.Point(4, 114);
            this.btnLastNameDesc.Name = "btnLastNameDesc";
            this.btnLastNameDesc.Size = new System.Drawing.Size(193, 30);
            this.btnLastNameDesc.TabIndex = 3;
            this.btnLastNameDesc.Text = "By last name descending";
            this.btnLastNameDesc.UseVisualStyleBackColor = false;
            this.btnLastNameDesc.Click += new System.EventHandler(this.btnLastNameDesc_Click);
            // 
            // btnLastNameAsc
            // 
            this.btnLastNameAsc.BackColor = System.Drawing.SystemColors.Control;
            this.btnLastNameAsc.Location = new System.Drawing.Point(4, 78);
            this.btnLastNameAsc.Name = "btnLastNameAsc";
            this.btnLastNameAsc.Size = new System.Drawing.Size(193, 30);
            this.btnLastNameAsc.TabIndex = 2;
            this.btnLastNameAsc.Text = "By last name ascending";
            this.btnLastNameAsc.UseVisualStyleBackColor = false;
            this.btnLastNameAsc.Click += new System.EventHandler(this.btnLastNameAsc_Click);
            // 
            // btnFirstNameDesc
            // 
            this.btnFirstNameDesc.BackColor = System.Drawing.SystemColors.Control;
            this.btnFirstNameDesc.Location = new System.Drawing.Point(4, 42);
            this.btnFirstNameDesc.Name = "btnFirstNameDesc";
            this.btnFirstNameDesc.Size = new System.Drawing.Size(193, 30);
            this.btnFirstNameDesc.TabIndex = 1;
            this.btnFirstNameDesc.Text = "By first name descending";
            this.btnFirstNameDesc.UseVisualStyleBackColor = false;
            this.btnFirstNameDesc.Click += new System.EventHandler(this.btnFirstNameDesc_Click);
            // 
            // btnFirstNameAsc
            // 
            this.btnFirstNameAsc.BackColor = System.Drawing.SystemColors.Control;
            this.btnFirstNameAsc.Location = new System.Drawing.Point(4, 6);
            this.btnFirstNameAsc.Name = "btnFirstNameAsc";
            this.btnFirstNameAsc.Size = new System.Drawing.Size(193, 30);
            this.btnFirstNameAsc.TabIndex = 0;
            this.btnFirstNameAsc.Text = "By first name ascending";
            this.btnFirstNameAsc.UseVisualStyleBackColor = false;
            this.btnFirstNameAsc.Click += new System.EventHandler(this.btnFirstNameAsc_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = global::LibRes.Properties.Resources.sort;
            this.btnFilter.Location = new System.Drawing.Point(785, 11);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(34, 28);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = " ";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // FrmLibraryMemberSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 464);
            this.Controls.Add(this.pnFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnVewMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnSearchMembers);
            this.Controls.Add(this.txtSearchMember);
            this.Controls.Add(this.dgvMembers);
            this.Name = "FrmLibraryMemberSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMember";
            this.Load += new System.EventHandler(this.FrmLibraryMemberSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.pnFilter.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.Button btnLastNameDesc;
        private System.Windows.Forms.Button btnLastNameAsc;
        private System.Windows.Forms.Button btnFirstNameDesc;
        private System.Windows.Forms.Button btnFirstNameAsc;
    }
}