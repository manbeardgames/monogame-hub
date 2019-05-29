using MonoGameHub;
using NLog;
using System;
using System.Diagnostics;

namespace MonoGameHubConsole
{
    class Program
    {
        private static Logger logger;
        private static Hub _hub;
        static void Main(string[] args)
        {
            Initialize();
            _hub = new Hub();
            logger.Info($"Is Installed: {_hub.IsMonoGameInstalled}");
            _hub.OnDownloadProgress += _hub_OnDownloadProgress;
            _hub.OnDownloadFinished += _hub_OnDownloadFinished;
            _hub.OnDownloadError += _hub_OnDownloadError;
            _hub.OnInstallExited += _hub_OnInstallExited;
            _hub.Download();

            Console.ReadLine();
        }

        private static void _hub_OnInstallExited(object sender, EventArgs e)
        {
            logger.Info("Install Exited");
        }

        private static void _hub_OnDownloadError(Exception exception)
        {
            logger.Error(exception.Message);
        }

        private static void _hub_OnDownloadFinished(object sender, EventArgs e)
        {
            logger.Info("Download has finished");
            _hub.Install();
            
        }

        private static void _hub_OnDownloadProgress(double value)
        {
            logger.Info($"Download Percent: {value}");
        }


        /// <summary>
        ///     Performs initializations for this console application
        /// </summary>
        private static void Initialize()
        {
            logger = LogManager.GetCurrentClassLogger();
        }
    }
}
