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
using Microsoft.Win32;

namespace MonoGameHub.Views
{
    public partial class InstallMonoGameView : UserControl
    {

        public event EventHandler InstallCompleted;
        public event EventHandler CouldNotFindFile;


        public InstallMonoGameView()
        {
            InitializeComponent();
        }

        private void BtnInstall_Click(object sender, EventArgs e)
        {

        }

        private void InstallMonoGame()
        {
            //  This is the path to the monogamesetup.exe that we downloaded on the previous view
            string fileName = Path.Combine(Path.GetTempPath(), "monogamesetup.exe");


            //  Ensure the file still exists (why wouldn't it? who knows?
            if (File.Exists(fileName))
            {
                using (var installer = new Process())
                {
                    installer.StartInfo.FileName = fileName;
                    installer.StartInfo.CreateNoWindow = false;
                    installer.Start();
                    installer.WaitForExit();
                }
                VerifyMonoGameInstall();
            }
            else
            {
                //  File somehow mysteriously was deleted from the users %temp% directory
                //  between the previous screen and now. So we just let em know
                string message = $"Unable to locate the file {fileName}.";
                Program.Log.Error(message);
                MessageBox.Show($"{message}  Please try downloading again");
                CouldNotFindFile?.Invoke(this, null);
            }

        }

        public void VerifyMonoGameInstall()
        {
            //  To validate that monogame is installed, we're going to check the uninstall registry to see if it has
            //  a valid key there
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Window\CurrentVersion\Uninstall\MonoGame") ??
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\MonoGame");

            //  If the key is null, then MonoGame is not installed
            if(key == null)
            {
                
            }
        }
    }
}
