using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace GitRenamer
{
    public partial class frmRun : Form
    {
        String sourcePath;
        String localRepoPath;

        String prefix;
        Boolean removeMode;
        
        int directoryCount;

        public frmRun(String sourcePath, String localRepoPath, String prefix, Boolean removeMode)
        {
            if (sourcePath == null || localRepoPath == null || !Directory.Exists(sourcePath) || !Directory.Exists(localRepoPath))
                throw new ArgumentException("Either the SourcePath or the LocalRepoPath is/are null or don't exists.");

            InitializeComponent();

            this.sourcePath = sourcePath;
            this.localRepoPath = localRepoPath;
            this.prefix = prefix;
            this.removeMode = removeMode;

        }

        private void cmdMoreLess_Click(object sender, EventArgs e)
        {
            if (this.Size.Height == 490)
            {
                lbLog.Visible = false;
                Size form = this.Size;

                form.Height = 176;

                this.Size = form;

                (sender as Button).Text = "More Details";
            }
            else
            {
                lbLog.Visible = true;
                Size form = this.Size;

                form.Height = 490;

                this.Size = form;

                (sender as Button).Text = "Less Details";
            }
        }

        private delegate void onLogMessage(String message);
        private void logMessage(String message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new onLogMessage(logMessage), message);
                return;
            }

            if (message == "")
            {
                lbLog.Items.Add("");
            }
            else if(message.StartsWith("="))
            {
                lbLog.Items.Add(message);
            }
            else
            {
                lbLog.Items.Add(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + " - " + message);
                dspCurrentTask.Text = message;
            }            
        }

        private void run()
        {
            try
            {
                logMessage("Starting the renaming process.");
                logMessage("============================================================");
                logMessage("");

                analyzeDirectory();

                pbCurrentProgress.Minimum = 0;
                pbCurrentProgress.Maximum = directoryCount + 1;

                if (!removeMode)
                {
                    logMessage("   > Started Renaming to temporary names.");

                    renameToTemp(sourcePath);

                    logMessage("   > Finished Renaming to temporary names.");

                    addNewDirectories();
                }
                else
                {
                    logMessage("   > Started Renaming to lowercase names.");

                    renameTempToLower(sourcePath);

                    logMessage("   > Finished Renaming to lowercase names.");

                    addNewDirectories();
                }

                logMessage("");
                logMessage("============================================================");
                logMessage("The renaming process finished succesfully.");
            }
            catch (Exception ex)
            {
                logMessage("");
                logMessage("============================================================");
                logMessage("The renaming process was halted with exception: " + ex.Message);
            }

            cmdStart.Visible = true;
        }
            
        private void analyzeDirectory()
        {
            logMessage("   > Analyzing source directory.");

            directoryCount = countDirectory(sourcePath) + 1;

            logMessage("   > Analyzing completed. Found: " + directoryCount.ToString() + " possible candidates to rename.");
        }

        private void renameToTemp(String directory)
        {
            String parentDirectory = Directory.GetParent(directory).FullName;
            String directoryName = (new DirectoryInfo(directory)).Name;

            foreach (String dirName in Directory.GetDirectories(directory))
            {
                renameToTemp(Path.Combine(directory, dirName));
            }

            logMessage("      > Renaming: \"" + directoryName + "\" to: \"" + prefix + directoryName.ToLower());

            ProcessStartInfo renamePSI = new ProcessStartInfo("git", "mv -f \"" + directoryName + "\" \"" + prefix + directoryName.ToLower() + "\"");
            renamePSI.WorkingDirectory = parentDirectory;
            renamePSI.CreateNoWindow = true;
            renamePSI.WindowStyle = ProcessWindowStyle.Hidden;
            renamePSI.UseShellExecute = false;
            renamePSI.RedirectStandardOutput = true;

            Process p = new Process();
            p.StartInfo = renamePSI;

            p.Start();
            p.WaitForExit();
        }

        private void renameTempToLower(string directory)
        {
            String parentDirectory = Directory.GetParent(directory).FullName;
            String directoryName = (new DirectoryInfo(directory)).Name;

            foreach (String dirName in Directory.GetDirectories(directory))
            {
                renameTempToLower(Path.Combine(directory, dirName));
            }

            logMessage("     > Renaming: \"" + directoryName + "\" to: \"" + directoryName.Substring(prefix.Length, directoryName.Length - prefix.Length));

            ProcessStartInfo renamePSI = new ProcessStartInfo("git", "mv -f \"" + directoryName + "\" \"" + directoryName.Substring(prefix.Length, directoryName.Length - prefix.Length) + "\"");
            renamePSI.WorkingDirectory = parentDirectory;
            renamePSI.CreateNoWindow = true;
            renamePSI.WindowStyle = ProcessWindowStyle.Hidden;
            renamePSI.UseShellExecute = false;
            renamePSI.RedirectStandardOutput = true;

            Process p = new Process();
            p.StartInfo = renamePSI;

            p.Start();
            p.WaitForExit();
        }

        private void addNewDirectories()
        {
            ProcessStartInfo addPSI = new ProcessStartInfo("git", "add *");
            addPSI.WorkingDirectory = localRepoPath;
            addPSI.CreateNoWindow = true;
            addPSI.WindowStyle = ProcessWindowStyle.Hidden;
            addPSI.UseShellExecute = false;
            addPSI.RedirectStandardOutput = true;

            Process addP = new Process();
            addP.StartInfo = addPSI;

            addP.Start();
            addP.WaitForExit();
        }

        private int countDirectory(String directory)
        {
            int count = 0;

            foreach(String dir in Directory.GetDirectories(directory))
            {
                count++;

                count += countDirectory(Path.Combine(directory, dir));
            }

            return count;
        }

        private void lbLog_DoubleClick(object sender, EventArgs e)
        {
            if (lbLog.SelectedItem == null)
                return;

            if (lbLog.SelectedItem as String == "")
                return;

            if ((lbLog.SelectedItem as String).StartsWith("="))
                return;

            MessageBox.Show(lbLog.SelectedItem as String);
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (lbLog.Items.Count == 0)
            {
                (sender as Button).Visible = false;
                (sender as Button).Text = "Close";

                run();
            }
            else
            {
                this.Close();
            }                       
        }
    }
}
