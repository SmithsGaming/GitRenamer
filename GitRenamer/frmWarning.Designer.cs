namespace GitRenamer
{
    partial class frmWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarning));
            this.lblWarningAndLicenses = new System.Windows.Forms.Label();
            this.cbRead = new System.Windows.Forms.CheckBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWarningAndLicenses
            // 
            this.lblWarningAndLicenses.AutoSize = true;
            this.lblWarningAndLicenses.Location = new System.Drawing.Point(12, 9);
            this.lblWarningAndLicenses.Name = "lblWarningAndLicenses";
            this.lblWarningAndLicenses.Size = new System.Drawing.Size(444, 299);
            this.lblWarningAndLicenses.TabIndex = 0;
            this.lblWarningAndLicenses.Text = resources.GetString("lblWarningAndLicenses.Text");
            // 
            // cbRead
            // 
            this.cbRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRead.AutoSize = true;
            this.cbRead.Location = new System.Drawing.Point(15, 321);
            this.cbRead.Name = "cbRead";
            this.cbRead.Size = new System.Drawing.Size(317, 17);
            this.cbRead.TabIndex = 1;
            this.cbRead.Text = "I have read this, know the risks and accepted the Agreement.";
            this.cbRead.UseVisualStyleBackColor = true;
            this.cbRead.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.ForeColor = System.Drawing.Color.Red;
            this.cmdCancel.Location = new System.Drawing.Point(15, 344);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdContinue
            // 
            this.cmdContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdContinue.Enabled = false;
            this.cmdContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdContinue.Location = new System.Drawing.Point(373, 344);
            this.cmdContinue.Name = "cmdContinue";
            this.cmdContinue.Size = new System.Drawing.Size(75, 23);
            this.cmdContinue.TabIndex = 3;
            this.cmdContinue.Text = "Continue";
            this.cmdContinue.UseVisualStyleBackColor = true;
            // 
            // frmWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 375);
            this.Controls.Add(this.cmdContinue);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cbRead);
            this.Controls.Add(this.lblWarningAndLicenses);
            this.Name = "frmWarning";
            this.Text = "GitRenamer - Warning and licenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarningAndLicenses;
        private System.Windows.Forms.CheckBox cbRead;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdContinue;
    }
}