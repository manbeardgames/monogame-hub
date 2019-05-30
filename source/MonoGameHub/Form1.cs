using Microsoft.Win32;
using MonoGameHub.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoGameHub
{
    public partial class frmMonoGameHub : Form
    {

        private string _monoGameInstalledVersion;

        public frmMonoGameHub()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Setups initial views for the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMonoGameHub_Load(object sender, EventArgs e)
        {
            VerifyMonoGameInstall();

        }

        /// <summary>
        ///     Verifies if Monogame is currently installed
        /// </summary>
        private void VerifyMonoGameInstall()
        {
            //  We're going to check the Uninstall registry to see if MonoGame is installed
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\MonoGame") ??
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\MonoGame");
            
            //  If the key is null, the MonoGame is not installed
            if(key == null)
            {
                lblMonoGameDetected.Text = "MonoGame Not Detected. Please Install MonoGame";
            }
            else
            {
                lblMonoGameDetected.Text = $"MonoGame Detected: v{key.GetValue("DisplayVersion") as string}";
            }

        }

        private void btnInstallBegin_Click(object sender, EventArgs e)
        {
            //  Conver the ServicePointManager
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            //  Create webclient
            WebClient client = new WebClient();

            //  Bind to events
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;

            //  The fully qualified URI to the MonoGameSetup.exe located on the 
            //  release page of the official MonoGame GitHub
            Uri from = new Uri("http://github.com/MonoGame/MonoGame/releases/download/v3.7.1/MonoGameSetup.exe");

            //  Save location is going to the users %temp% directory
            string to = Path.Combine(Path.GetTempPath(), "MonoGameSetup.exe");

            //  Start the download. Use async version so we don't lock the UI thread
            client.DownloadFileAsync(from, to);

            progressBarDownloading.Visible = true;
            lblInstallMessage.Text = "Downloading MonoGame: 0%";
            btnInstallBegin.Enabled = false;           


        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBarDownloading.Visible = false;
            lblInstallMessage.Text = "Download Completed, running installer...";

            using (var installer = new Process())
            {
                installer.StartInfo.FileName = Path.Combine(Path.GetTempPath(), "MonoGameSetup.exe");
                installer.StartInfo.CreateNoWindow = false;
                installer.Start();
                installer.WaitForExit();
            }

            VerifyMonoGameInstall();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //  Get the bytes we're received
            double bytesReceived = double.Parse(e.BytesReceived.ToString());

            //  Get the total bytes to download
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());

            //  Calculate the percentage completed and give to progress bars
            int percent = Convert.ToInt32(bytesReceived / totalBytes * 100);
            progressBarDownloading.Value = percent;

            lblInstallMessage.Text = $"Downloading MonoGame: {percent:P}";
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbpProjects;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbpNew;
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbpInstall;
        }

        private void installVisualStudioControl2_OnVerified(object sender, EventArgs e)
        {
            DownloadMonoGameControl ctrl = new DownloadMonoGameControl();
            ctrl.OnDownloadCompleted += downloadMonoGameControl_OnDownloadCompleted;
            tbpInstall.Controls.Add(ctrl);
            tbpInstall.Controls.SetChildIndex(ctrl,0);
            ctrl.Dock = DockStyle.Top;
            ctrl.Height = 80;
        }

        private void downloadMonoGameControl_OnDownloadCompleted(object sender, EventArgs e)
        {
            InstallMonoGameControl ctrl = new InstallMonoGameControl();
            tbpInstall.Controls.Add(ctrl);
            tbpInstall.Controls.SetChildIndex(ctrl, 0);
            ctrl.Dock = DockStyle.Top;
            ctrl.Height = 80;
        }
    }
}
