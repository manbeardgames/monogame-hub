using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MonoGameHub.Views
{
    public partial class InstallView : UserControl
    {
        private bool _isVisualStudioInstalled;
        private bool _isMonoGameInstalled;

        VisualStudioInstallView _visualStudioInstallView;
        DownloadMonoGameView _downloadMonoGameView;

        public InstallView()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            //  Create the visual studio install view
            _visualStudioInstallView = new VisualStudioInstallView();
            _visualStudioInstallView.Dock = DockStyle.Fill;
            _visualStudioInstallView.VisualStudioVerified += (sender, e) =>
            {
                pnlContentRegion.Controls.Remove(_visualStudioInstallView);
                pnlContentRegion.Controls.Add(_downloadMonoGameView);
            };


            //  Create the download monogame view
            _downloadMonoGameView = new DownloadMonoGameView();
            _downloadMonoGameView.Dock = DockStyle.Fill;
            _downloadMonoGameView.DownloadCompleted += (sender, e) =>
            {
                MessageBox.Show("Download Completed");
            };


            pnlContentRegion.Controls.Add(_visualStudioInstallView);

            _visualStudioInstallView.VerifyVisualStudioInstall();

        }
    }
}
