using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace MonoGameHub.Views
{
    public partial class VisualStudioInstallView : UserControl
    {
        public event EventHandler VisualStudioVerified;


        public VisualStudioInstallView()
        {
            InitializeComponent();
        }


        private void BtnVerify_Click(object sender, EventArgs e)
        {
            VerifyVisualStudioInstall();
        }

        public void VerifyVisualStudioInstall()
        {

            //  Holds the resulting output from vswhere process
            string result = string.Empty;

            //  Use vswhere to check for visual studio installation
            using (var vshwere = new Process())
            {
                vshwere.StartInfo.CreateNoWindow = true;
                vshwere.StartInfo.UseShellExecute = false;
                vshwere.StartInfo.RedirectStandardOutput = true;
                vshwere.StartInfo.FileName =
                    Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "vswhere.exe");

                vshwere.Start();
                result = vshwere.StandardOutput.ReadToEnd();
                vshwere.WaitForExit();
            }

            //  The resulting output will be different properties seperated by a line break.  For eample
            //  propertyOne: value
            //  propertyTwo: value
            //  So we'll use a string reader to read it line by line to find the
            //  displayName property and get that value
            using (var stringReader = new StringReader(result))
            {
                //  Read the first line
                string line = stringReader.ReadLine();

                //  Now iterate using a while lop as long as line is not null
                while (line != null)
                {
                    //  Check if the line starts with the 'displayName' property name
                    if (line.StartsWith("displayName"))
                    {
                        //  display name was found, which means VS2017 or higher is installed
                        VisualStudioVerified?.Invoke(this, null);
                        break;
                    }

                    //   Read next line
                    line = stringReader.ReadLine();
                }
            }
        }
    }
}
