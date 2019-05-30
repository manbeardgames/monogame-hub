using Microsoft.Win32;
using NLog;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace MonoGameHub
{
    public partial class frmMonoGameHub : Form
    {
        public bool IsVisualStudioInstalled { get; private set; }
        public string VisualStudioVersion { get; private set; }
        public bool IsMonoGameInstalled { get; private set; }
        public string MonoGameVersion { get; private set; }
        private string _monoGameVersin;

        private static readonly string TempFilePath =
            Path.Combine(Path.GetTempPath(), ConfigurationManager.AppSettings["TempFileName"]);

        private Logger _log;
        private bool _isDownloading = false;
        private WebClient _downloadClient;

        

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
            //  Initialize the logger
            _log = LogManager.GetCurrentClassLogger();

            //  Verify if monogame is already installed
            VerifyMonoGameInstall();

            //  Initialize the contorls for the install tab
            InitializeInstallTab();
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
            InitializeInstallTab();
            tabControl1.SelectedTab = tbpInstall;
        }


        //-----------------------------------------------------------------------
        //  btnVerifyVisualStudio Events
        //-----------------------------------------------------------------------
        private void btnVerifyVisualStudio_Click(object sender, EventArgs e)
        {
            VerifyVisualStudio();
        }

        //-----------------------------------------------------------------------
        //  btnDownloadMonoGame Events
        //-----------------------------------------------------------------------
        private void btnDownloaMonoGame_Click(object sender, EventArgs e)
        {
            if (_isDownloading)
            {
                _downloadClient.CancelAsync();
            }
            else
            {
                DownloadMonoGame();
            }
        }

        //-----------------------------------------------------------------------
        //  btnInstallMonoGame Events
        //-----------------------------------------------------------------------
        private void btnInstallMonoGame_Click(object sender, EventArgs e)
        {
            InstallMonogame();
        }

        private void pnlVisualStudioVerifier_EnabledChanged(object sender, EventArgs e)
        {
            if (pnlVisualStudioVerifier.Enabled)
            {
                pnlVisualStudioVeriferActive.BackColor = System.Drawing.Color.FromArgb(230, 60, 0);
            }
            else
            {
                pnlVisualStudioVeriferActive.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            }
        }

        private void pnlDownloadMonoGame_EnabledChanged(object sender, EventArgs e)
        {
            if (pnlDownloadMonoGame.Enabled)
            {
                pnlDownloadMonoGameActive.BackColor = System.Drawing.Color.FromArgb(230, 60, 0);
            }
            else
            {
                pnlDownloadMonoGameActive.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            }
        }

        private void pnlInstallMonoGame_Enter(object sender, EventArgs e)
        {
            if (pnlInstallMonoGame.Enabled)
            {
                pnlInstallMonoGameActive.BackColor = System.Drawing.Color.FromArgb(230, 60, 0);
            }
            else
            {
                pnlInstallMonoGameActive.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            }
        }


        //-----------------------------------------------------------------------
        //  Helper Methods
        //-----------------------------------------------------------------------
        /// <summary>
        ///     Initializes the controls on the Install tab
        /// </summary>
        private void InitializeInstallTab()
        {
            if(IsMonoGameInstalled)
            {
                tbpInstall.Controls.Remove(pnlVisualStudioVerifier);
                tbpInstall.Controls.Remove(pnlDownloadMonoGame);
                tbpInstall.Controls.Remove(pnlInstallMonoGame);
                tbpInstall.Controls.Remove(lblInstallHeader);

                Label monoGameInstallLabel = new Label();
                monoGameInstallLabel.Text = "MonoGame Already Installed";
                monoGameInstallLabel.Dock = DockStyle.Fill;
                monoGameInstallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                tbpInstall.Controls.Add(monoGameInstallLabel);
            }
            //  Enable the Verify Visual Studio panel
            pnlVisualStudioVerifier.Enabled = true;

            //  First check if visual studio is installed
            VerifyVisualStudio();
        }

        /// <summary>
        ///     Validates if Visual Studio is installed
        /// </summary>
        private void VerifyVisualStudio()
        {
            //  Disable the verify button
            btnVerifyVisualStudio.Enabled = false;

            //  Check for visual studio installation
            CheckVisualStudioInstallation();

            if (IsVisualStudioInstalled)
            {
                //  Hide controls no longer needed
                lblVisualStudioDownload.Visible = false;
                lblVisualStudioVerifierMessage.Visible = false;

                //  Add a picturebox to the mid panel
                PictureBox pcb = new PictureBox();
                pcb.Image = MonoGameHub.Properties.Resources.check;
                pcb.Dock = DockStyle.Fill;
                pcb.SizeMode = PictureBoxSizeMode.CenterImage;

                pnlVerifyVisualStudioMid.Controls.Add(pcb);
                pnlVerifyVisualStudioMid.Controls.Remove(btnVerifyVisualStudio);

                //  Show the verified message
                lblVisualStudioVerified.Text = $"Verified {VisualStudioVersion} is installed.";
                lblVisualStudioVerified.Visible = true;

                pnlVisualStudioVerifier.Enabled = false;
                pnlDownloadMonoGame.Enabled = true;
            }
            else
            {
                //  Hide controls no longer needed
                lblVisualStudioVerified.Visible = false;

                //  Show the download message
                lblVisualStudioDownload.Visible = true;

                //  Enable the verify button so they can try again after
                //  downloading and installing visual studio
                btnVerifyVisualStudio.Enabled = true;
            }
        }

        /// <summary>
        ///     Performs check for if visual studio is installed using vswhere.exe
        /// </summary>
        private void CheckVisualStudioInstallation()
        {
            //  Holds there resulting output from the vswhere process
            string result = string.Empty;

            //  Use vswhere to check for visual studio installation
            using (var vswhere = new Process())
            {
                vswhere.StartInfo.CreateNoWindow = true;
                vswhere.StartInfo.UseShellExecute = false;
                vswhere.StartInfo.RedirectStandardOutput = true;
                vswhere.StartInfo.FileName =
                    Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "vswhere.exe");

                vswhere.Start();
                result = vswhere.StandardOutput.ReadToEnd();
                vswhere.WaitForExit();
            }

            //  The resulting output will be different properties seperated by a line break.  For eample
            //  propertyOne: value
            //  propertyTwo: value
            //  So we'll use a string reader to read it line by line to find the
            //  displayName property and get that value
            using (var stringReader = new StringReader(result))
            {
                //  Read the first line
                string line = stringReader.ReadLine();

                //  Now iterate using a while loop as long as line is 
                //  not null
                while (line != null)
                {
                    //  Check if the line starts with the 'displayName' property name
                    if (line.StartsWith("displayName"))
                    {
                        //  Get the value of the property
                        VisualStudioVersion = line.Replace("displayName:", "").Trim();

                        //  Set that visual studio is in fact installed
                        IsVisualStudioInstalled = true;

                        //  Break out of the while loop
                        break;
                    }

                    // Property wasn't found in the line, go to next line
                    line = stringReader.ReadLine();
                }
            }
        }

        /// <summary>
        ///     Downloads MonoGameSetup.exe
        /// </summary>
        private void DownloadMonoGame()
        {
            //  Configure the ServicePointManager
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            //  Create webclient
            _downloadClient = new WebClient();

            //  Create handling for progress changed event
            _downloadClient.DownloadProgressChanged += (sender, e) =>
            {
                if (_isDownloading)
                {
                    //  Get the bytes we've received
                    double bytesReceived = double.Parse(e.BytesReceived.ToString());
                    double mbReceived = bytesReceived / Math.Pow(1024, 2);

                    //  Get the total bytes to download
                    double bytesTotal = double.Parse(e.TotalBytesToReceive.ToString());
                    double mbTotal = bytesTotal / Math.Pow(1024, 2);

                    //  Calculate the percentage completed
                    int percent = Convert.ToInt32(bytesReceived / bytesTotal * 100);

                    //  Update progress bar
                    pgbDownloadMonoGame.Value = percent;

                    //  Update the label
                    lblDownloadMonoGamePercentage.Text = $"Downloading: {mbReceived:##}/{mbTotal:##} MB ({percent}%)";
                }
            };

            //  Create handling for download completed event
            _downloadClient.DownloadFileCompleted += (sender, e) =>
            {
                _isDownloading = false;

                if (e.Error != null)
                {
                    string message = e.Error.Message;
                    _log.Error(message);
                    throw new Exception(message);
                }
                else if (e.Cancelled)
                {
                    pgbDownloadMonoGame.Value = 0;
                    lblDownloadMonoGamePercentage.Text = "Download canceled";
                    btnDownloaMonoGame.Enabled = true;
                }
                else
                {
                    PictureBox pcb = new PictureBox();
                    pcb.Image = MonoGameHub.Properties.Resources.check;
                    pcb.SizeMode = PictureBoxSizeMode.CenterImage;
                    pcb.Dock = DockStyle.Fill;
                    pnlDownloadMonoGameMid.Controls.Add(pcb);
                    pnlDownloadMonoGameMid.Controls.Remove(btnDownloaMonoGame);
                    pnlDownloadMonoGame.Controls.Remove(lblDownloaMonoGameMessage);
                    pnlDownloadMonoGame.Controls.Remove(pgbDownloadMonoGame);
                    pnlDownloadMonoGame.Controls.Remove(lblDownloadMonoGamePercentage);
                    pnlDownloadMonoGame.Enabled = false;
                    pnlInstallMonoGame.Enabled = true;
                }
            };

            //  The fully qualified URI to the MonoGameSetup.exe located on the 
            //  release page of the official MonoGame GitHub
            Uri from = new Uri(ConfigurationManager.AppSettings["MonoGameDownloadUri"]);

            //  Start the download. Use async version so we don't block UI thread
            _downloadClient.DownloadFileAsync(from, TempFilePath);

            btnDownloaMonoGame.Text = "Cancel Download";
            _isDownloading = true;
        }

        /// <summary>
        ///     Spawns process to run the MonoGameSetup.exe
        /// </summary>
        private void InstallMonogame()
        {
            //  Spawn new process to run the MonoGameSetup.exe that was downloaded
            if (File.Exists(TempFilePath))
            {
                using (var installer = new Process())
                {
                    installer.StartInfo.FileName = TempFilePath;
                    installer.StartInfo.CreateNoWindow = false;
                    installer.Start();
                    installer.WaitForExit();
                }
                VerifyMonoGameInstall();
            }
            else
            {
                string message = $"Unable to located file at {TempFilePath}";
                _log.Error($"Unable to locate downloaded file in");
                throw new FileNotFoundException(message);
            }
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
            if (key == null)
            {
                IsMonoGameInstalled = false;
                MonoGameVersion = "MonoGame Not Detected. Please Install MonoGame";
                lblMonoGameDetected.Text = "MonoGame Not Detected. Please Install MonoGame";
            }
            else
            {
                IsMonoGameInstalled = true;
                MonoGameVersion = $"v{key.GetValue("DisplayVersion") as string}";
                lblMonoGameDetected.Text = $"MonoGame Detected: {MonoGameVersion}";
            }

        }
    }
}
