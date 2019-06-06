using MonoGameHub.Models;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MonoGameHub.Views
{
    public partial class ConfigureProjectView : UserControl
    {
        /// <summary>
        ///     Occurs when the <see cref="btnBack"/> control is clicked
        /// </summary>
        public event EventHandler Back;

        /// <summary>
        ///     Occurs when the <see cref="btnCreate"/> control is clicked
        /// </summary>
        public event EventHandler Create;




        /// <summary>
        ///     Creates a new <see cref="ConfigureProjectView"/> instance
        /// </summary>
        public ConfigureProjectView()
        {
            InitializeComponent();

            txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        /// <summary>
        ///     Handles the MouseClick event for the <see cref="btnBack"/> button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_MouseClick(object sender, MouseEventArgs e)
        {
            Back?.Invoke(this, null);
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtLocation.Text = fbd.SelectedPath;
                }
            }
        }


        private void TxtProjectName_TextChanged(object sender, EventArgs e)
        {
            if (chkShareName.Checked)
            {
                txtSolutionName.Text = txtProjectName.Text;
            }

            EnableCreateButton();
        }

        private void ChkShareName_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShareName.Checked)
            {
                txtSolutionName.Text = txtProjectName.Text;
                txtSolutionName.Enabled = false;
            }
            else
            {
                txtSolutionName.Enabled = true;
            }
        }

        private void TxtLocation_TextChanged(object sender, EventArgs e)
        {
            EnableCreateButton();
        }

        private void TxtSolutionName_TextChanged(object sender, EventArgs e)
        {
            EnableCreateButton();
        }

        private void EnableCreateButton()
        {
            bool enable = !string.IsNullOrWhiteSpace(txtProjectName.Text);
            enable = !string.IsNullOrWhiteSpace(txtLocation.Text);
            enable = !string.IsNullOrWhiteSpace(txtSolutionName.Text);
            btnCreate.Enabled = enable;

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Create?.Invoke(this, null);
        }
    }
}
