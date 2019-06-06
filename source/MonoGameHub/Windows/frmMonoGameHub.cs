using MonoGameHub.Models;
using MonoGameHub.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGameHub.Windows
{
    public partial class frmMonoGameHub : Form
    {
        /// <summary>
        ///     Referencd to the <see cref="HomeView"/> control that is displayed
        ///     in the <see cref="pnlContentRegion"/> panel
        /// </summary>
        private HomeView _homeView;
        
        /// <summary>
        ///     Reference to the <see cref="ChooseTemplateView"/> control that is displayed
        ///     in the <see cref="pnlContentRegion"/> panel
        /// </summary>
        private ChooseTemplateView _chooseTemplateView;

        /// <summary>
        ///     Reference to the <see cref="ConfigureProjectView"/> control that is displayed
        ///     in the <see cref="pnlContentRegion"/> panel
        /// </summary>
        private ConfigureProjectView _configureProjectView;

        //  Refrence for building a new project
        private ProjectModel _newProject = new ProjectModel();

        /// <summary>
        ///     Creates a new <see cref="frmMonoGameHub"/> instance
        /// </summary>
        public frmMonoGameHub()
        {
            //  Create a new splash form window and show it as a dialog.
            //  The splash window performs an initial check to see if the MonoGame
            //  SDK is installed.  Once the check is finished, it will automatically
            //  close itself out so that this form can be shown.
            using (var splash = new frmSplash())
            {
                splash.ShowDialog();
            }

            InitializeComponent();

            //  Create a new HomeView control and add it to the content region panel
            _homeView = new HomeView();
            _homeView.Dock = DockStyle.Fill;
            _homeView.NewProjectClicked += (_, e) =>
            {
                pnlContentRegion.Controls.Remove(_homeView);
                pnlContentRegion.Controls.Add(_chooseTemplateView);
            };
            _homeView.Initialize();


            _chooseTemplateView = new ChooseTemplateView();
            _chooseTemplateView.Dock = DockStyle.Fill;
            _chooseTemplateView.Cancel += (_, e) =>
            {
                pnlContentRegion.Controls.Remove(_chooseTemplateView);
                pnlContentRegion.Controls.Add(_homeView);
            };

            _chooseTemplateView.Next += (_, e) =>
            {
                pnlContentRegion.Controls.Remove(_chooseTemplateView);
                _newProject.ProjectType = _chooseTemplateView.TemplateChoosen;
                pnlContentRegion.Controls.Add(_configureProjectView);

            };

            _configureProjectView = new ConfigureProjectView();
            _configureProjectView.Dock = DockStyle.Fill;
            _configureProjectView.Back += (_, e) =>
            {
                pnlContentRegion.Controls.Remove(_configureProjectView);
                pnlContentRegion.Controls.Add(_chooseTemplateView);
            };






            pnlContentRegion.Controls.Add(_homeView);
        }

        /// <summary>
        ///     Handles action to perform when <see cref="btnClose"/> is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            //  Close the window
            this.Close();
        }

        //---------------------------------------------------------------------
        //  For styling purposes, this form is displayed as borderless. This
        //  means there is no legit way of grabbing the window with the mouse
        //  and moving it somewhere differeng on the users screen if they wish.
        //
        //  The following fields and functions resolve this.  Various controls
        //  on the form use the MouseDown, MouseMove, and MouseUp events below
        //  which will allow users to click and drag the window
        //
        //  This could have been done using the user32.dll DLLImport, but I found
        //  this solution much cleaner and without having to use unmanaged code

        #region Allowing Borderless Form Window To Move With Mouse Implementation
        //  Tracks the last mouse location.
        private Point _lastMouseLocation;
        //  Is the mouse left button down
        private bool _isMouseDown;

        /// <summary>
        ///     Handles the action to perform when the mouse left button is down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            //  Set that the mouse is down
            _isMouseDown = true;

            //  Cache the location the location
            _lastMouseLocation = e.Location;
        }

        /// <summary>
        ///     Handles the action to perform when the mouse cursor moves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                //  Calculate new location for this form
                this.Location = new Point(
                    (Location.X - _lastMouseLocation.X) + e.X, (Location.Y - _lastMouseLocation.Y) + e.Y);
                Update();
            }
        }

        /// <summary>
        ///     Handles the action to perform when the mouse left button is released
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            //  Set that the mouse is no longer down
            _isMouseDown = false;
        }
        #endregion Allowing Borderless Form Window To Move With Mouse Implementation

        //---------------------------------------------------------------------
    }
}
