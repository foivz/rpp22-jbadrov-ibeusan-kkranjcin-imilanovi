namespace LibRes
{
    partial class FrmUpdateBookCopy
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
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblYearOfPublication = new System.Windows.Forms.Label();
            this.txtYearOfPublication = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.lblEdition = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbPublishers = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.btnUpdateBookCopy = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(56, 310);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(286, 22);
            this.txtLanguage.TabIndex = 30;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(53, 291);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(68, 16);
            this.lblLanguage.TabIndex = 29;
            this.lblLanguage.Text = "Language";
            // 
            // lblYearOfPublication
            // 
            this.lblYearOfPublication.AutoSize = true;
            this.lblYearOfPublication.Location = new System.Drawing.Point(53, 230);
            this.lblYearOfPublication.Name = "lblYearOfPublication";
            this.lblYearOfPublication.Size = new System.Drawing.Size(118, 16);
            this.lblYearOfPublication.TabIndex = 28;
            this.lblYearOfPublication.Text = "Year of publication";
            // 
            // txtYearOfPublication
            // 
            this.txtYearOfPublication.Location = new System.Drawing.Point(56, 249);
            this.txtYearOfPublication.Name = "txtYearOfPublication";
            this.txtYearOfPublication.Size = new System.Drawing.Size(286, 22);
            this.txtYearOfPublication.TabIndex = 27;
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(56, 119);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(286, 22);
            this.txtEdition.TabIndex = 26;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(53, 100);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(48, 16);
            this.lblEdition.TabIndex = 25;
            this.lblEdition.Text = "Edition";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 35);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(56, 51);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(286, 22);
            this.txtTitle.TabIndex = 23;
            // 
            // cmbPublishers
            // 
            this.cmbPublishers.FormattingEnabled = true;
            this.cmbPublishers.Location = new System.Drawing.Point(56, 180);
            this.cmbPublishers.Name = "cmbPublishers";
            this.cmbPublishers.Size = new System.Drawing.Size(286, 24);
            this.cmbPublishers.TabIndex = 21;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(53, 161);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(66, 16);
            this.lblPublisher.TabIndex = 20;
            this.lblPublisher.Text = "Publisher:";
            // 
            // btnUpdateBookCopy
            // 
            this.btnUpdateBookCopy.Location = new System.Drawing.Point(56, 365);
            this.btnUpdateBookCopy.Name = "btnUpdateBookCopy";
            this.btnUpdateBookCopy.Size = new System.Drawing.Size(157, 35);
            this.btnUpdateBookCopy.TabIndex = 19;
            this.btnUpdateBookCopy.Text = "Update Book Copy";
            this.btnUpdateBookCopy.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(53, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title:";
            // 
            // FrmUpdateBookCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 430);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblYearOfPublication);
            this.Controls.Add(this.txtYearOfPublication);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cmbPublishers);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.btnUpdateBookCopy);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmUpdateBookCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update book copy";
            this.Load += new System.EventHandler(this.FrmUpdateBookCopy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblYearOfPublication;
        private System.Windows.Forms.TextBox txtYearOfPublication;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbPublishers;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Button btnUpdateBookCopy;
        private System.Windows.Forms.Label lblTitle;
    }
}