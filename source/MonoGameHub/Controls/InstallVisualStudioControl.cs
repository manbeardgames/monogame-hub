using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoGameHub.Controls
{
    public partial class InstallVisualStudioControl : UserControl
    {
        public bool IsVisualStudioInstalled { get; private set; }
        public string DisplayName = string.Empty;
        public event EventHandler OnVerified;

        public InstallVisualStudioControl()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //  Open the downloads page for Visual Studio using the users default browser
            Process.Start(@"https://visualstudio.microsoft.com/downloads/");
        }

        private void CheckVisualStudioInstallation()
        {
            //  First we need to check if visual studio is already installed. This will
            //  determine the element and their properties for this control
            string result = string.Empty;
            using (var vswhere = new Process())
            {
                vswhere.StartInfo.CreateNoWindow = true;
                vswhere.StartInfo.UseShellExecute = false;
                vswhere.StartInfo.RedirectStandardOutput = true;
                vswhere.StartInfo.FileName =
                    Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "vswhere.exe");
                vswhere.Start();
                result = vswhere.StandardOutput.ReadToEnd();
                vswhere.WaitForExit();
            }

            using (var stringReader = new StringReader(result))
            {
                string line = stringReader.ReadLine();
                while (line != null)
                {
                    if (line.StartsWith("displayName"))
                    {
                        DisplayName = line.Replace("displayName:", "");
                        IsVisualStudioInstalled = true;
                        break;
                    }
                    line = stringReader.ReadLine();

                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            Verify();
        }

        public void Verify()
        {
            CheckVisualStudioInstallation();
            if (IsVisualStudioInstalled)
            {
                pictureBox.Image = MonoGameHub.Properties.Resources.check;
                lblMessage.Text = $"{DisplayName} is installed";
                linkLabel.Visible = false;
                btnVerify.Enabled = false;
                btnVerify.Visible = false;
                OnVerified?.Invoke(this, null);
            }
            else
            {
                pictureBox.Image = MonoGameHub.Properties.Resources.close;
                lblMessage.Text = "Visual Studio 2017 must be installed before installing the MonoGame SDK.";
                linkLabel.Visible = true;
                btnVerify.Enabled = true;
                btnVerify.Visible = true;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
