using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MonoGameHub.Views
{
    public partial class DownloadMonoGameView : UserControl
    {
        private WebClient _downloadClient;
        private bool _isDownloading;

        public event EventHandler DownloadCompleted;


        public DownloadMonoGameView()
        {
            InitializeComponent();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            //  If we are already downloading, this is to cancel it
            if(_isDownloading)
            {
                _downloadClient.CancelAsync();
            }
            //  Otherwise we are starting the download
            else
            {
                DownloadMonoGame();
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
            _downloadClient.DownloadProgressChanged += (sender, e) =>
            {
                if (_isDownloading)
                {
                    //  Get the bytes we've received
                    double bytesReceived = double.Parse(e.BytesReceived.ToString());

                    //  Get the total bytes to download
                    double bytesTotal = double.Parse(e.TotalBytesToReceive.ToString());

                    //  Calculate the percentage to complete
                    int percent = Convert.ToInt32(bytesReceived / bytesTotal * 100);

                    //  Update the progressbar
                    progressBar.Value = percent;

                    //  Update the label
                    lblProgress.Text = $"Downloading: {bytesReceived} / {bytesTotal} ({percent}%)";
                }
            };

            //  Create action for when the download is complete/canceled
            _downloadClient.DownloadFileCompleted += (sender, e) =>
            {
                //  Mark that we are no longer downloading
                _isDownloading = false;

                //  Check if there was an error
                if (e.Error != null && !e.Cancelled)
                {
                    string message = e.Error.Message;
                    Program.Log.Error(message);
                    throw new Exception(message);
                }
                //  or if the download was canceled
                else if (e.Cancelled)
                {
                    progressBar.Value = 0;
                    lblProgress.Text = "Download canceled by user";
                    btnDownload.Text = "Download";
                }
                //  Otherwise the download completed successfully
                else
                {
                    DownloadCompleted?.Invoke(this, null);
                }
            };

            //  This fully qualified URI to the MonoGameSetup.exe located on the release page
            //  of the official MonoGame Github
            Uri from = new Uri("http://github.com/MonoGame/MonoGame/releases/download/v3.7.1/MonoGameSetup.exe");

            //  We're going to save the download in the users %temp% directory
            string to = Path.Combine(Path.GetTempPath(), "monogamesetup.exe");

            //  Start the download.  Use the async version so we don't block UI thread
            _downloadClient.DownloadFileAsync(from, to);

            //  Set that we are downloading
            _isDownloading = true;

            //  Show the progress bar
            progressBar.Visible = true;

            //  Show the progress label
            lblProgress.Visible = true;

            //  Change the text on the download button to "Cancel"
            btnDownload.Text = "Cancel";
        }




    }
}
