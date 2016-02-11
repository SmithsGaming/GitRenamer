namespace GitRenamer
{
    partial class frmMain
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
            this.cmdRun = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.lblRoot = new System.Windows.Forms.Label();
            this.cmdFindRoot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRemovePrefix = new System.Windows.Forms.RadioButton();
            this.rbAppendPrefix = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRun
            // 
            this.cmdRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRun.Location = new System.Drawing.Point(443, 140);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(75, 23);
            this.cmdRun.TabIndex = 0;
            this.cmdRun.Text = "Run";
            this.cmdRun.UseVisualStyleBackColor = true;
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Location = new System.Drawing.Point(12, 140);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(12, 24);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(425, 20);
            this.txtSourcePath.TabIndex = 2;
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.Location = new System.Drawing.Point(12, 8);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(181, 13);
            this.lblRoot.TabIndex = 3;
            this.lblRoot.Text = "Root source directory of your project:";
            // 
            // cmdFindRoot
            // 
            this.cmdFindRoot.Location = new System.Drawing.Point(443, 24);
            this.cmdFindRoot.Name = "cmdFindRoot";
            this.cmdFindRoot.Size = new System.Drawing.Size(75, 20);
            this.cmdFindRoot.TabIndex = 4;
            this.cmdFindRoot.Text = "...";
            this.cmdFindRoot.UseVisualStyleBackColor = true;
            this.cmdFindRoot.Click += new System.EventHandler(this.cmdFindRoot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRemovePrefix);
            this.groupBox1.Controls.Add(this.rbAppendPrefix);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 43);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // rbRemovePrefix
            // 
            this.rbRemovePrefix.AutoSize = true;
            this.rbRemovePrefix.Location = new System.Drawing.Point(249, 20);
            this.rbRemovePrefix.Name = "rbRemovePrefix";
            this.rbRemovePrefix.Size = new System.Drawing.Size(91, 17);
            this.rbRemovePrefix.TabIndex = 1;
            this.rbRemovePrefix.TabStop = true;
            this.rbRemovePrefix.Text = "Restore mode";
            this.rbRemovePrefix.UseVisualStyleBackColor = true;
            // 
            // rbAppendPrefix
            // 
            this.rbAppendPrefix.AutoSize = true;
            this.rbAppendPrefix.Location = new System.Drawing.Point(7, 20);
            this.rbAppendPrefix.Name = "rbAppendPrefix";
            this.rbAppendPrefix.Size = new System.Drawing.Size(91, 17);
            this.rbAppendPrefix.TabIndex = 0;
            this.rbAppendPrefix.TabStop = true;
            this.rbAppendPrefix.Text = "Append mode";
            this.rbAppendPrefix.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "The prefix you want to append or remove:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(12, 63);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(506, 20);
            this.txtPrefix.TabIndex = 6;
            this.txtPrefix.Text = "temp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdFindRoot);
            this.Controls.Add(this.lblRoot);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdRun);
            this.MaximumSize = new System.Drawing.Size(546, 214);
            this.MinimumSize = new System.Drawing.Size(546, 214);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GitRenamer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRun;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.Button cmdFindRoot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRemovePrefix;
        private System.Windows.Forms.RadioButton rbAppendPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrefix;
    }
}

