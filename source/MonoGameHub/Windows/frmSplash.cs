using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoGameHub.Windows
{
    public partial class frmSplash : Form
    {
        //  Used to keep spalsh form on screen for at minimum 1 second
        private Timer _timer;

        //  Determines if the spalsh screen can close when the timer interval is called
        private bool _canClose;


        /// <summary>
        ///     Creates a new instance
        /// </summary>
        public frmSplash()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Called when the this <see cref="frmSplash"/> first loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSplash_Load(object sender, EventArgs e)
        {
            _canClose = false;

            //  Initialize the timer with a 1 sec interval
            _timer = new Timer();
            _timer.Interval = 1000;

            //  Tick method just stops the timer, checks if the form can
            //  close and closes it if it can
            _timer.Tick += (obj, args) =>
            {
                if (_canClose)
                {
                    Close();
                }
            };

            _timer.Start();

            //  Verify the monogame install
            Program.VerifyMonoGameInstall();

            //  Now that verification is done, the splash can close if it wants
            _canClose = true;
        }

        ///// <summary>
        /////     Gets if MonoGame is installed
        ///// </summary>
        ///// <returns>True if MonoGame is installed; otherwise false</returns>
        //private bool IsMonoGameInstalled()
        //{
        //    //  To verify if MonoGame is installed, we're going to check for the MonoGame key in the
        //    //  Uninstall registry
        //    var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\MonoGame") ??
        //        Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\MonoGame");

        //    if (key == null)
        //    {
        //        //  If the key is null, then MonoGame is not installed
        //        MonoGameVersion = null;
        //        return false;
        //    }
        //    else
        //    {
        //        //  Get the displayVersion value from the key
        //        string displayVersion = key.GetValue("DisplayVersion") as string;

        //        //  Instantiate the version
        //        MonoGameVersion = new Version(displayVersion);

        //        return true;
        //    }
        //}

        private void FrmSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
        }
    }
}
