using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace MonoGameHub.Controls
{
    public partial class DownloadInstallButton : UserControl
    {
        private WebClient _downloadClient;
        private bool _isDownloading;

        public event EventHandler DownloadAndInstallCompleted;


        public DownloadInstallButton()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            _isDownloading = false;

            progressBar.Value = 0;
            progressBar.Visible = false;

            lblTitle.Text = "Download and Install MonoGame";
            lblDescription.Text = "Download the MonoGame SDK from the Official GitHub repository and run the installer.";
            if (Program.MonoGameInstall == MonoGameInstallType.UnsupportedInstall)
            {
                lblDescription.Text = "MonoGame Hub requires MonoGame 3.7.1 or higher.  Click here to upgrade your version";
            }
        }

        private void TriggerMouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void TriggerMouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void TriggerMouseCLick(object sender, MouseEventArgs e)
        {
            if (!_isDownloading)
            {
                DownloadMonoGame();
            }
            else
            {
                _downloadClient.CancelAsync();
            }
        }

        private void DownloadMonoGame()
        {
            //  Configure the ServicePointManager
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            //  Create webclient
            _downloadClient = new WebClient();

            //  Create action for when progress is reported from the download client
            _downloadClient.DownloadProgressChanged += (_, e) =>
            {
                if (_isDownloading)
                {
                    //  Get the bytes we've received
                    double bytesReceived = double.Parse(e.BytesReceived.ToString());

                    //  Get the total bytes to download
                    double bytesTotal = double.Parse(e.TotalBytesToReceive.ToString());

                    //  Calculate the percentage to complete
                    int percent = Convert.ToInt32(bytesReceived / bytesTotal * 100);

                    //  Update the progress bar
                    progressBar.Value = percent;

                }
            };

            //  Create action for when the download is completed/canceled;
            _downloadClient.DownloadFileCompleted += (_, e) =>
            {
                //  Check if there was an error
                if (e.Error != null && !e.Cancelled)
                {
                    string message = e.Error.Message;
                    Program.Log.Error(message);
                    throw new Exception(message);
                }
                //  or if the download was cancelled
                else if (e.Cancelled)
                {
                    Initialize();
                }
                //  Otherwise the download compelted successfully, move on to install
                else
                {
                    InstallMonoGame();
                }
            };

            //  This is the fully qualified URI to the MonoGameSetup.exe located on the release page
            //  of the official MonoGame GitHub
            Uri from = new Uri("http://github.com/MonoGame/MonoGame/releases/download/v3.7.1/MonoGameSetup.exe");

            //  We're going to save the download in the users %temp% directory
            string to = Path.Combine(Path.GetTempPath(), "monogamesetup.exe");

            if (File.Exists(to))
            {
                InstallMonoGame();
            }
            else
            {
                //  Start the download.  Use the async version so we don't block UI thread
                _downloadClient.DownloadFileAsync(from, to);

                //  Set that we are downloading
                _isDownloading = true;

                //  Show the progress bar
                progressBar.Visible = true;

                //  Set title and text to downloading info
                lblTitle.Text = "Downloading MonoGame...";
                lblDescription.Text = "Downloading MonoGame from MonoGame GitHub. Click again to cancel download.";
            }



        }

        private void InstallMonoGame()
        {
            lblTitle.Text = "Launching MonoGame Installer";
            lblDescription.Text = "The MonoGameSetup installer is launching. Follow prompts to install MonoGame";

            //  This is the path to the monogamesetup.exe that we downloaded on the previous view
            string fileName = Path.Combine(Path.GetTempPath(), "monogamesetup.exe");


            //  Ensure the file still exists (why wouldn't it? who knows?
            if (File.Exists(fileName))
            {
                int exitCode = 0;
                try
                {
                    using (var installer = new Process())
                    {
                        installer.StartInfo.FileName = fileName;
                        installer.StartInfo.CreateNoWindow = false;
                        installer.Start();
                        installer.WaitForExit();
                        exitCode = installer.ExitCode;
                    }
                }
                //  Win32Exception occurs when windows prompts the user if they want to give permission
                //  to run the installer, and the user chooses no
                catch (Win32Exception e)
                {
                    //  Just initialize the controls back to default
                    Program.Log.Warn("User did not give permission to run the installer");
                    Initialize();
                    return;
                }
                catch (Exception e)
                {
                    //  All other exceptions we'll just throw 
                    string message = e.Message;
                    Program.Log.Error(message);
                    throw e;
                }


                //  If the exit code is 0, that means the installer completed, no issues
                //  anything else means the installer did not complete
                if (exitCode == 0)
                {
                    if (Program.VerifyMonoGameInstall() == MonoGameInstallType.Installed)
                    {
                        DownloadAndInstallCompleted?.Invoke(this, null);
                    }
                }
                else
                {
                    //  Initialize the controls back to default
                    Initialize();
                }
            }
            else
            {
                //  File somehow mysteriously was deleted from the users %temp% directory
                //  between the previous screen and now. So we just let em know
                string message = $"Unable to locate the file {fileName}.";
                Program.Log.Error(message);
                MessageBox.Show($"{message}  Please try downloading again");
                Initialize();
            }
        }
    }
}
