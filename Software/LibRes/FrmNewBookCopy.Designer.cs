namespace LibRes
{
    partial class FrmNewBookCopy
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
            this.btnAddBookCopy = new System.Windows.Forms.Button();
            this.cmbPublishers = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEdition = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtYearOfPublication = new System.Windows.Forms.TextBox();
            this.lblYearOfPublication = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(57, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // btnAddBookCopy
            // 
            this.btnAddBookCopy.Location = new System.Drawing.Point(60, 419);
            this.btnAddBookCopy.Name = "btnAddBookCopy";
            this.btnAddBookCopy.Size = new System.Drawing.Size(123, 35);
            this.btnAddBookCopy.TabIndex = 6;
            this.btnAddBookCopy.Text = "Add Book Copy";
            this.btnAddBookCopy.UseVisualStyleBackColor = true;
            this.btnAddBookCopy.Click += new System.EventHandler(this.btnAddBookCopy_Click);
            // 
            // cmbPublishers
            // 
            this.cmbPublishers.FormattingEnabled = true;
            this.cmbPublishers.Location = new System.Drawing.Point(60, 195);
            this.cmbPublishers.Name = "cmbPublishers";
            this.cmbPublishers.Size = new System.Drawing.Size(258, 24);
            this.cmbPublishers.TabIndex = 8;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(57, 176);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(66, 16);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Publisher:";
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Location = new System.Drawing.Point(114, 225);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(141, 35);
            this.btnAddPublisher.TabIndex = 9;
            this.btnAddPublisher.Text = "Add New Publisher";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(60, 66);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(258, 22);
            this.txtTitle.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(57, 115);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(48, 16);
            this.lblEdition.TabIndex = 12;
            this.lblEdition.Text = "Edition";
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(60, 134);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(258, 22);
            this.txtEdition.TabIndex = 13;
            // 
            // txtYearOfPublication
            // 
            this.txtYearOfPublication.Location = new System.Drawing.Point(60, 304);
            this.txtYearOfPublication.Name = "txtYearOfPublication";
            this.txtYearOfPublication.Size = new System.Drawing.Size(258, 22);
            this.txtYearOfPublication.TabIndex = 14;
            // 
            // lblYearOfPublication
            // 
            this.lblYearOfPublication.AutoSize = true;
            this.lblYearOfPublication.Location = new System.Drawing.Point(57, 285);
            this.lblYearOfPublication.Name = "lblYearOfPublication";
            this.lblYearOfPublication.Size = new System.Drawing.Size(118, 16);
            this.lblYearOfPublication.TabIndex = 15;
            this.lblYearOfPublication.Text = "Year of publication";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(57, 346);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(68, 16);
            this.lblLanguage.TabIndex = 16;
            this.lblLanguage.Text = "Language";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(60, 365);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(258, 22);
            this.txtLanguage.TabIndex = 17;
            // 
            // FrmNewBookCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 470);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblYearOfPublication);
            this.Controls.Add(this.txtYearOfPublication);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.cmbPublishers);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.btnAddBookCopy);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNewBookCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New book copy";
            this.Load += new System.EventHandler(this.FrmNewBookCopy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddBookCopy;
        private System.Windows.Forms.ComboBox cmbPublishers;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtYearOfPublication;
        private System.Windows.Forms.Label lblYearOfPublication;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.TextBox txtLanguage;
    }
}