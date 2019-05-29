using System;
using System.ComponentModel;
using System.IO;
using System.Net;

namespace MonoGameHub.Utils
{
    internal class Downloader : INotifyPropertyChanged
    {
        public bool DownloadFinished
        {
            get { return _downloadFinished; }
            set
            {
                if (_downloadFinished == value) { return; }
                _downloadFinished = value;
                RaisePropertyChanged("DownloadFinished");
            }
        }
        private bool _downloadFinished;

        public double PercentCompleted
        {
            get { return _percentCompleted; }
            set
            {
                if (_percentCompleted == value) { return; }
                _percentCompleted = value;
                RaisePropertyChanged("PercentCompleted");
            }
        }
        private double _percentCompleted;

        public Exception Exception
        {
            get { return _exception; }
            set
            {
                if (_exception == value) { return; }
                _exception = value;
                RaisePropertyChanged("Exception");
            }
        }
        private Exception _exception;



        public Downloader() { }

        public void Download()
        {
            //  Configure the service point manager
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            //  Create webclient
            WebClient client = new WebClient();

            //  Bind to events
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;

            //  The fully qualified URI to the file to download
            Uri from = new Uri("http://github.com/MonoGame/MonoGame/releases/download/v3.7.1/MonoGameSetup.exe");

            //  The location to save the file to
            string to = Path.Combine(Path.GetTempPath(), "MonoGameSetup.exe");

            /// Start the download
            client.DownloadFileAsync(from, to);
        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Exception = e.Error;
            }
            else
            {
                DownloadFinished = true;
            }
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            PercentCompleted = bytesIn / totalBytes * 100;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
