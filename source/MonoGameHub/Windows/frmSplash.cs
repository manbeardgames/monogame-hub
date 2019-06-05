using System;
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
        ///     Called when the this <see cref="frmSplash"/> instance first loads
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

        /// <summary>
        ///     Called when this <see cref="frmSplash"/> instance is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
        }
    }
}
