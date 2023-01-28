namespace LibRes
{
    partial class FrmBookReturn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookReturn));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.btnScanMember = new System.Windows.Forms.Button();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.pbScan = new System.Windows.Forms.PictureBox();
            this.dgvBookOverviews = new System.Windows.Forms.DataGridView();
            this.timerForScaning = new System.Windows.Forms.Timer(this.components);
            this.lblLate = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.txtLate = new System.Windows.Forms.TextBox();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblReturn = new System.Windows.Forms.Label();
            this.pbScanMember = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookOverviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanMember)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1006, 570);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(886, 570);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 28);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmbMember
            // 
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(32, 161);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(239, 24);
            this.cmbMember.TabIndex = 7;
            this.cmbMember.SelectedIndexChanged += new System.EventHandler(this.cmbMember_SelectedIndexChanged);
            // 
            // btnScanMember
            // 
            this.btnScanMember.Location = new System.Drawing.Point(32, 118);
            this.btnScanMember.Name = "btnScanMember";
            this.btnScanMember.Size = new System.Drawing.Size(121, 23);
            this.btnScanMember.TabIndex = 6;
            this.btnScanMember.Text = "Scan Member";
            this.btnScanMember.UseVisualStyleBackColor = true;
            this.btnScanMember.Click += new System.EventHandler(this.btnScanMember_Click);
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(229, 46);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(53, 16);
            this.lblDevice.TabIndex = 12;
            this.lblDevice.Text = "Device:";
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(298, 43);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(604, 24);
            this.cmbDevices.TabIndex = 13;
            // 
            // pbScan
            // 
            this.pbScan.Location = new System.Drawing.Point(32, 225);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(359, 324);
            this.pbScan.TabIndex = 14;
            this.pbScan.TabStop = false;
            // 
            // dgvBookOverviews
            // 
            this.dgvBookOverviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookOverviews.Location = new System.Drawing.Point(412, 161);
            this.dgvBookOverviews.Name = "dgvBookOverviews";
            this.dgvBookOverviews.RowHeadersWidth = 51;
            this.dgvBookOverviews.RowTemplate.Height = 24;
            this.dgvBookOverviews.Size = new System.Drawing.Size(685, 388);
            this.dgvBookOverviews.TabIndex = 15;
            // 
            // timerForScaning
            // 
            this.timerForScaning.Tick += new System.EventHandler(this.timerForScaning_Tick);
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Location = new System.Drawing.Point(1115, 209);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(36, 16);
            this.lblLate.TabIndex = 16;
            this.lblLate.Text = "Late:";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Location = new System.Drawing.Point(1115, 249);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(55, 16);
            this.lblPenalty.TabIndex = 17;
            this.lblPenalty.Text = "Penalty:";
            // 
            // txtLate
            // 
            this.txtLate.Enabled = false;
            this.txtLate.Location = new System.Drawing.Point(1171, 206);
            this.txtLate.Name = "txtLate";
            this.txtLate.Size = new System.Drawing.Size(137, 22);
            this.txtLate.TabIndex = 18;
            // 
            // txtPenalty
            // 
            this.txtPenalty.Enabled = false;
            this.txtPenalty.Location = new System.Drawing.Point(1171, 246);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(137, 22);
            this.txtPenalty.TabIndex = 19;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1231, 301);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 31);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(1126, 164);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(0, 16);
            this.lblReturn.TabIndex = 21;
            // 
            // pbScanMember
            // 
            this.pbScanMember.Image = ((System.Drawing.Image)(resources.GetObject("pbScanMember.Image")));
            this.pbScanMember.Location = new System.Drawing.Point(291, 161);
            this.pbScanMember.Name = "pbScanMember";
            this.pbScanMember.Size = new System.Drawing.Size(43, 33);
            this.pbScanMember.TabIndex = 22;
            this.pbScanMember.TabStop = false;
            // 
            // FrmBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1325, 607);
            this.Controls.Add(this.pbScanMember);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.txtLate);
            this.Controls.Add(this.lblPenalty);
            this.Controls.Add(this.lblLate);
            this.Controls.Add(this.dgvBookOverviews);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.btnScanMember);
            this.Name = "FrmBookReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBookReturn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBookReturn_FormClosing);
            this.Load += new System.EventHandler(this.FrmBookReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookOverviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Button btnScanMember;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.PictureBox pbScan;
        private System.Windows.Forms.DataGridView dgvBookOverviews;
        private System.Windows.Forms.Timer timerForScaning;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.TextBox txtLate;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.PictureBox pbScanMember;
    }
}