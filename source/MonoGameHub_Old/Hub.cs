using Microsoft.Win32;
using MonoGameHub.Models;
using MonoGameHub.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace MonoGameHub
{
    public class Hub
    {
        public List<ProjectModel> Projects { get; internal set; }
        public bool IsMonoGameInstalled { get; internal set; }
        private Downloader _downloader;
        public delegate void DownloadProgressReportHandler(double value);
        public delegate void ExceptionHandler(Exception exception);
        public event DownloadProgressReportHandler OnDownloadProgress;
        public event EventHandler OnDownloadFinished;
        public event ExceptionHandler OnDownloadError;
        public event EventHandler OnInstallExited;
        private Process _installer;
        

        public Hub()
        {
            LoadProjects();
            CheckMonoGameInstallation();
            _downloader = new Downloader();
            _downloader.PropertyChanged += _downloader_PropertyChanged;
            

        }

        private void _installer_Exited(object sender, EventArgs e)
        {
            CheckMonoGameInstallation();
            OnInstallExited?.Invoke(this, e);
        }

        private void _downloader_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "PercentCompleted")
            {
                OnDownloadProgress?.Invoke(_downloader.PercentCompleted);
            }
            else if (e.PropertyName == "DownloadFinished")
            {
                OnDownloadFinished?.Invoke(this, null);
            }
            else if (e.PropertyName == "Exception")
            {
                OnDownloadError?.Invoke(_downloader.Exception);
            }
        }

        /// <summary>
        ///     Loads the project data
        /// </summary>
        public void LoadProjects()
        {
            Projects = SaveLoad.LoadProjects();
        }

        /// <summary>
        ///     Saves the project data
        /// </summary>
        public void SaveProjects()
        {
            SaveLoad.Save(Projects);
        }

        public void CreateNewProject(string projectName, string solutionName, string directory, string version)
        {
            
        }

        internal void CheckMonoGameInstallation()
        {
            //  We're going to check the Uninstall registry to see if MonoGame is installed
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall") ??
                Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");

            //  Use the key to see if MonoGame is installed
            IsMonoGameInstalled = key == null ? false :
                key.GetSubKeyNames()
                   .Select(keyName => key.OpenSubKey(keyName))
                   .Select(subkey => subkey.GetValue("DisplayName") as string)
                   .Any(displayName => displayName != null && displayName.Contains("MonoGame"));

        }

        public void Download()
        {
            _downloader.Download();
        }

        public void Install()
        {
            using (_installer = new Process())
            {
                try
                {
                    _installer.StartInfo.FileName = Path.Combine(Path.GetTempPath(), "MonoGameSetup.exe");
                    _installer.StartInfo.CreateNoWindow = false;
                    _installer.Start();
                    _installer.WaitForExit();
                    OnInstallExited?.Invoke(this, null);
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
