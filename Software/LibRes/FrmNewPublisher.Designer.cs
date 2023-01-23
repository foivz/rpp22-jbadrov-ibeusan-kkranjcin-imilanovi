namespace LibRes
{
    partial class FrmNewPublisher
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
            this.lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtYearOfEst = new System.Windows.Forms.TextBox();
            this.lblYearOfEst = new System.Windows.Forms.Label();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 22);
            this.textBox1.TabIndex = 1;
            // 
            // txtYearOfEst
            // 
            this.txtYearOfEst.Location = new System.Drawing.Point(56, 112);
            this.txtYearOfEst.Name = "txtYearOfEst";
            this.txtYearOfEst.Size = new System.Drawing.Size(286, 22);
            this.txtYearOfEst.TabIndex = 3;
            // 
            // lblYearOfEst
            // 
            this.lblYearOfEst.AutoSize = true;
            this.lblYearOfEst.Location = new System.Drawing.Point(53, 93);
            this.lblYearOfEst.Name = "lblYearOfEst";
            this.lblYearOfEst.Size = new System.Drawing.Size(142, 16);
            this.lblYearOfEst.TabIndex = 2;
            this.lblYearOfEst.Text = "Year Of Establishment:";
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Location = new System.Drawing.Point(114, 166);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(111, 35);
            this.btnAddPublisher.TabIndex = 7;
            this.btnAddPublisher.Text = "Add Publisher";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmNewPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 222);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.txtYearOfEst);
            this.Controls.Add(this.lblYearOfEst);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblName);
            this.Name = "FrmNewPublisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtYearOfEst;
        private System.Windows.Forms.Label lblYearOfEst;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnCancel;
    }
}