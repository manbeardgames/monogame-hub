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

namespace MonoGameHub.Controls
{
    public partial class DownloadMonoGameControl : UserControl
    {
        public bool DownloadCompleted
        {
            get;
            private set;
        }

        public event EventHandler OnDownloadCompleted;


        public DownloadMonoGameControl()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            btnDownload.Enabled = false;
            btnDownload.Visible = false;
            lblMessage.Text = "Downloading: 0%";

            DownloadMonoGame();
        }

        private void DownloadMonoGame()
        {
            //  Configure the ServicePointManager
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
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                throw e.Error;
            }
            else
            {
                DownloadCompleted = true;
                pictureBox1.Image = MonoGameHub.Properties.Resources.check;
                OnDownloadCompleted?.Invoke(this, null);
            }
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //  Get the bytes we're received
            double bytesReceived = double.Parse(e.BytesReceived.ToString());

            //  Get the total bytes to download
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());

            //  Calculate the percentage completed and give to progress bars
            int percent = Convert.ToInt32(bytesReceived / totalBytes * 100);
            progressBar.Value = percent;
            lblMessage.Text = $"Downloading: {bytesReceived} / {totalBytes} ({percent}%)";
        }

        private void btnDownload_EnabledChanged(object sender, EventArgs e)
        {
            if(btnDownload.Enabled)
            {
                btnDownload.BackColor = SystemColors.Control;
            }
            else
            {
                btnDownload.BackColor = SystemColors.ScrollBar;
            }
        }
    }
}
