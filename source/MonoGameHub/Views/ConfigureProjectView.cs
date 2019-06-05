using System;
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
        ///     Creates a new <see cref="ConfigureProjectView"/> instance
        /// </summary>
        public ConfigureProjectView()
        {
            InitializeComponent();
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
    }
}
