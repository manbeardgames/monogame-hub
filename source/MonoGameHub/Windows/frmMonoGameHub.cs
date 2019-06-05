using MonoGameHub.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGameHub.Windows
{
    public partial class frmMonoGameHub : Form
    {
        private HomeView _homeView;
        private Point _lastMouseLocation;
        private bool _isMouseDown;

        public frmMonoGameHub()
        {
            using (var splash = new frmSplash())
            {
                splash.ShowDialog();
            }

            InitializeComponent();

            _homeView = new HomeView();
            _homeView.Dock = DockStyle.Fill;
            _homeView.Initialize();

            pnlContentRegion.Controls.Add(_homeView);
        }


        /// <summary>
        ///     Setups initial views for the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMonoGameHub_Load(object sender, EventArgs e)
        {
            //  Initialize the contorls for the install tab
            //InitializeInstallTab();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            _lastMouseLocation = e.Location;
        }

        private void MoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                Location = new Point(
                    (Location.X - _lastMouseLocation.X) + e.X, (Location.Y - _lastMouseLocation.Y) + e.Y);
                Update();
            }
        }

        private void MoveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
        }
    }
}
