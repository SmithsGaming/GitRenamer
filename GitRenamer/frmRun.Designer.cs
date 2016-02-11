namespace GitRenamer
{
    partial class frmRun
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
            this.lblCurrentProgress = new System.Windows.Forms.Label();
            this.dspCurrentTask = new System.Windows.Forms.Label();
            this.pbCurrentProgress = new System.Windows.Forms.ProgressBar();
            this.cmdMoreLess = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentProgress
            // 
            this.lblCurrentProgress.AutoSize = true;
            this.lblCurrentProgress.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentProgress.Name = "lblCurrentProgress";
            this.lblCurrentProgress.Size = new System.Drawing.Size(87, 13);
            this.lblCurrentProgress.TabIndex = 3;
            this.lblCurrentProgress.Text = "Current progress:";
            // 
            // dspCurrentTask
            // 
            this.dspCurrentTask.AutoSize = true;
            this.dspCurrentTask.Location = new System.Drawing.Point(105, 9);
            this.dspCurrentTask.Name = "dspCurrentTask";
            this.dspCurrentTask.Size = new System.Drawing.Size(24, 13);
            this.dspCurrentTask.TabIndex = 5;
            this.dspCurrentTask.Text = "dsp";
            // 
            // pbCurrentProgress
            // 
            this.pbCurrentProgress.Location = new System.Drawing.Point(15, 26);
            this.pbCurrentProgress.Name = "pbCurrentProgress";
            this.pbCurrentProgress.Size = new System.Drawing.Size(572, 23);
            this.pbCurrentProgress.TabIndex = 7;
            // 
            // cmdMoreLess
            // 
            this.cmdMoreLess.Location = new System.Drawing.Point(512, 72);
            this.cmdMoreLess.Name = "cmdMoreLess";
            this.cmdMoreLess.Size = new System.Drawing.Size(75, 23);
            this.cmdMoreLess.TabIndex = 8;
            this.cmdMoreLess.Text = "More Details";
            this.cmdMoreLess.UseVisualStyleBackColor = true;
            this.cmdMoreLess.Click += new System.EventHandler(this.cmdMoreLess_Click);
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(15, 119);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(572, 290);
            this.lbLog.TabIndex = 9;
            this.lbLog.Visible = false;
            this.lbLog.DoubleClick += new System.EventHandler(this.lbLog_DoubleClick);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(14, 72);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 10;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // frmRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 160);
            this.ControlBox = false;
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdMoreLess);
            this.Controls.Add(this.pbCurrentProgress);
            this.Controls.Add(this.dspCurrentTask);
            this.Controls.Add(this.lblCurrentProgress);
            this.Controls.Add(this.lbLog);
            this.MaximumSize = new System.Drawing.Size(615, 490);
            this.MinimumSize = new System.Drawing.Size(615, 176);
            this.Name = "frmRun";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GitRenamer - Renaming in progress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurrentProgress;
        private System.Windows.Forms.Label dspCurrentTask;
        private System.Windows.Forms.ProgressBar pbCurrentProgress;
        private System.Windows.Forms.Button cmdMoreLess;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button cmdStart;
    }
}