namespace LibRes
{
    partial class FrmBookBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookBorrow));
            this.btnScanMember = new System.Windows.Forms.Button();
            this.cmbLibraryMembers = new System.Windows.Forms.ComboBox();
            this.cmbBookCopy = new System.Windows.Forms.ComboBox();
            this.btnScanBook = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbScan = new System.Windows.Forms.PictureBox();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.timerForScaningMember = new System.Windows.Forms.Timer(this.components);
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.timerForScaningBook = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxScanedMember = new System.Windows.Forms.PictureBox();
            this.pictureBoxScanedBook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScanedMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScanedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScanMember
            // 
            this.btnScanMember.Location = new System.Drawing.Point(262, 87);
            this.btnScanMember.Name = "btnScanMember";
            this.btnScanMember.Size = new System.Drawing.Size(121, 23);
            this.btnScanMember.TabIndex = 0;
            this.btnScanMember.Text = "Scan Member";
            this.btnScanMember.UseVisualStyleBackColor = true;
            this.btnScanMember.Click += new System.EventHandler(this.btnScanMember_Click);
            // 
            // cmbLibraryMembers
            // 
            this.cmbLibraryMembers.FormattingEnabled = true;
            this.cmbLibraryMembers.Location = new System.Drawing.Point(123, 116);
            this.cmbLibraryMembers.Name = "cmbLibraryMembers";
            this.cmbLibraryMembers.Size = new System.Drawing.Size(422, 24);
            this.cmbLibraryMembers.TabIndex = 1;
            // 
            // cmbBookCopy
            // 
            this.cmbBookCopy.FormattingEnabled = true;
            this.cmbBookCopy.Location = new System.Drawing.Point(343, 189);
            this.cmbBookCopy.Name = "cmbBookCopy";
            this.cmbBookCopy.Size = new System.Drawing.Size(202, 24);
            this.cmbBookCopy.TabIndex = 3;
            // 
            // btnScanBook
            // 
            this.btnScanBook.Location = new System.Drawing.Point(262, 160);
            this.btnScanBook.Name = "btnScanBook";
            this.btnScanBook.Size = new System.Drawing.Size(121, 23);
            this.btnScanBook.TabIndex = 2;
            this.btnScanBook.Text = "Scan Book";
            this.btnScanBook.UseVisualStyleBackColor = true;
            this.btnScanBook.Click += new System.EventHandler(this.btnScanBook_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(343, 550);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(91, 28);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(454, 550);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbScan
            // 
            this.pbScan.Location = new System.Drawing.Point(123, 235);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(422, 309);
            this.pbScan.TabIndex = 6;
            this.pbScan.TabStop = false;
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(123, 41);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(422, 24);
            this.cmbDevices.TabIndex = 7;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(40, 44);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(53, 16);
            this.lblDevice.TabIndex = 8;
            this.lblDevice.Text = "Device:";
            // 
            // timerForScaningMember
            // 
            this.timerForScaningMember.Interval = 1000;
            this.timerForScaningMember.Tick += new System.EventHandler(this.timmerForScaning_Tick);
            // 
            // cmbBook
            // 
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(123, 189);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(196, 24);
            this.cmbBook.TabIndex = 9;
            this.cmbBook.SelectedIndexChanged += new System.EventHandler(this.cmbBook_SelectedIndexChanged);
            // 
            // timerForScaningBook
            // 
            this.timerForScaningBook.Interval = 1000;
            this.timerForScaningBook.Tick += new System.EventHandler(this.timerForScaningBook_Tick);
            // 
            // pictureBoxScanedMember
            // 
            this.pictureBoxScanedMember.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScanedMember.Image")));
            this.pictureBoxScanedMember.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxScanedMember.InitialImage")));
            this.pictureBoxScanedMember.Location = new System.Drawing.Point(554, 116);
            this.pictureBoxScanedMember.Name = "pictureBoxScanedMember";
            this.pictureBoxScanedMember.Size = new System.Drawing.Size(59, 32);
            this.pictureBoxScanedMember.TabIndex = 10;
            this.pictureBoxScanedMember.TabStop = false;
            // 
            // pictureBoxScanedBook
            // 
            this.pictureBoxScanedBook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScanedBook.Image")));
            this.pictureBoxScanedBook.Location = new System.Drawing.Point(554, 189);
            this.pictureBoxScanedBook.Name = "pictureBoxScanedBook";
            this.pictureBoxScanedBook.Size = new System.Drawing.Size(59, 31);
            this.pictureBoxScanedBook.TabIndex = 11;
            this.pictureBoxScanedBook.TabStop = false;
            // 
            // FrmBookBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(737, 590);
            this.Controls.Add(this.pictureBoxScanedBook);
            this.Controls.Add(this.pictureBoxScanedMember);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.cmbBookCopy);
            this.Controls.Add(this.btnScanBook);
            this.Controls.Add(this.cmbLibraryMembers);
            this.Controls.Add(this.btnScanMember);
            this.Name = "FrmBookBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBookBorrow_FormClosing);
            this.Load += new System.EventHandler(this.FrmBookBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScanedMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScanedBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScanMember;
        private System.Windows.Forms.ComboBox cmbLibraryMembers;
        private System.Windows.Forms.ComboBox cmbBookCopy;
        private System.Windows.Forms.Button btnScanBook;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbScan;
        private System.Windows.Forms.ComboBox cmbDevices;
        //private System.Windows.Forms.Timer timmerForScaning;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Timer timerForScaningMember;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Timer timerForScaningBook;
        private System.Windows.Forms.PictureBox pictureBoxScanedMember;
        private System.Windows.Forms.PictureBox pictureBoxScanedBook;
    }
}