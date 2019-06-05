using Microsoft.Win32;
using MonoGameHub.Windows;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MonoGameHub
{
    static class Program
    {
        /// <summary>
        ///     <see cref="NLog.Logger"/> used to log info, debug, and error messages
        /// </summary>
        public static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        ///     The <see cref="MonoGameInstallType"/> detected
        /// </summary>
        public static MonoGameInstallType MonoGameInstall = MonoGameInstallType.NotInstalled;

        //  Array of the versions of MonoGame that is currently supported
        //  by the MonoGame Hub
        private static readonly Version[] _supportedVersions = new Version[]
        {
            new Version("3.7.1"),
            new Version("3.7.1.189")
        };

#if DEBUG
        //  Used to force set the MonoGameInstallType property
        //  on the first run if we are debugging
        static bool _debugFirstRun = true;
#endif

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMonoGameHub());
            //Begin();


        }

        public static MonoGameInstallType VerifyMonoGameInstall()
        {
            //  To verify if MonoGame is installed, we're going to check for the MonoGame key in the
            //  Uninstall registry
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\MonoGame") ??
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\MonoGame");

            if (key == null)
            {
                //  If the key is null, then MonoGame is not installed
                MonoGameInstall = MonoGameInstallType.NotInstalled;
            }
            else
            {
                //  Get the displayVersion value from the key
                string displayVersion = key.GetValue("DisplayVersion") as string;
                Version version = new Version(displayVersion);

                //  Check if it is a supported version
                if (_supportedVersions.Contains(version))
                {
                    //  We're good to go
                    MonoGameInstall = MonoGameInstallType.Installed;
                }
                else
                {
                    //  MonoGame is installed, but the version installed
                    //  is not one tested with the current version of 
                    //  MonoGame Hub
                    MonoGameInstall = MonoGameInstallType.UnsupportedInstall;
                }
            }

#if DEBUG
            if (_debugFirstRun)
            {
                MonoGameInstall = MonoGameInstallType.UnsupportedInstall;
                _debugFirstRun = false;
            }
#endif
            return MonoGameInstall;
        }


    }
}
