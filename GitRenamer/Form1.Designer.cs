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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRoot = new System.Windows.Forms.Label();
            this.cmdFindRoot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCommitOnce = new System.Windows.Forms.RadioButton();
            this.rbCommitEveryChange = new System.Windows.Forms.RadioButton();
            this.cbPush = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRun
            // 
            this.cmdRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRun.Location = new System.Drawing.Point(443, 126);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(75, 23);
            this.cmdRun.TabIndex = 0;
            this.cmdRun.Text = "Run";
            this.cmdRun.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Location = new System.Drawing.Point(12, 126);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 20);
            this.textBox1.TabIndex = 2;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCommitOnce);
            this.groupBox1.Controls.Add(this.rbCommitEveryChange);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 43);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commit behaviour";
            // 
            // rbCommitOnce
            // 
            this.rbCommitOnce.AutoSize = true;
            this.rbCommitOnce.Location = new System.Drawing.Point(249, 20);
            this.rbCommitOnce.Name = "rbCommitOnce";
            this.rbCommitOnce.Size = new System.Drawing.Size(249, 17);
            this.rbCommitOnce.TabIndex = 1;
            this.rbCommitOnce.TabStop = true;
            this.rbCommitOnce.Text = "Commit once after each process part completes";
            this.rbCommitOnce.UseVisualStyleBackColor = true;
            // 
            // rbCommitEveryChange
            // 
            this.rbCommitEveryChange.AutoSize = true;
            this.rbCommitEveryChange.Location = new System.Drawing.Point(7, 20);
            this.rbCommitEveryChange.Name = "rbCommitEveryChange";
            this.rbCommitEveryChange.Size = new System.Drawing.Size(157, 17);
            this.rbCommitEveryChange.TabIndex = 0;
            this.rbCommitEveryChange.TabStop = true;
            this.rbCommitEveryChange.Text = "Commit every single change";
            this.rbCommitEveryChange.UseVisualStyleBackColor = true;
            // 
            // cbPush
            // 
            this.cbPush.AutoSize = true;
            this.cbPush.Location = new System.Drawing.Point(15, 100);
            this.cbPush.Name = "cbPush";
            this.cbPush.Size = new System.Drawing.Size(216, 17);
            this.cbPush.TabIndex = 6;
            this.cbPush.Text = "Push after process has been completed.";
            this.cbPush.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 161);
            this.Controls.Add(this.cbPush);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdFindRoot);
            this.Controls.Add(this.lblRoot);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdRun);
            this.MaximumSize = new System.Drawing.Size(546, 200);
            this.MinimumSize = new System.Drawing.Size(546, 200);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GitRenamer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRun;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.Button cmdFindRoot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCommitOnce;
        private System.Windows.Forms.RadioButton rbCommitEveryChange;
        private System.Windows.Forms.CheckBox cbPush;
    }
}

