namespace LibRes
{
    partial class FrmQRCode
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
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(53, 41);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(401, 351);
            this.pbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbQRCode.TabIndex = 0;
            this.pbQRCode.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(372, 433);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 31);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 476);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pbQRCode);
            this.Name = "FrmQRCode";
            this.Text = "QRCode";
            this.Load += new System.EventHandler(this.FrmQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.Button btnPrint;
    }
}