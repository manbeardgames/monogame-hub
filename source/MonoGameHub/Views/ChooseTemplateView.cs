using MonoGameHub.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGameHub.Views
{
    public partial class ChooseTemplateView : UserControl
    {
        /// <summary>
        ///     Occurs when the <see cref="btnCancel"/> control is clicked
        /// </summary>
        public event EventHandler Cancel;

        /// <summary>
        ///     Occurs when the <see cref="btnNext"/> control is clicked
        /// </summary>
        public event EventHandler Next;

        /// <summary>
        ///     The <see cref="MonoGameProjectTemplate"/> choosen by the user
        /// </summary>
        public MonoGameProjectTemplate TemplateChoosen { get; set; }


        private ButtonWithContent _selected;

        /// <summary>
        ///     Creates a new <see cref="ChooseTemplateView"/> instance
        /// </summary>
        public ChooseTemplateView()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Handles the MouseClick event for the <see cref="btnCancel"/> button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(this, null);
        }

        /// <summary>
        ///     Handles the MouseClick event for the <see cref="btnNext"/> button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            Next?.Invoke(this, null);
        }

        /// <summary>
        ///     Handles the MouseEnter event for all buttons in the <see cref="pnlTemplateList"/>
        ///     panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TemplateButton_MouseEnter(object sender, EventArgs e)
        {
            //  Get reference to the button as a Control
            Control button = sender as Control;

            //  Change the background color to show that the button is highlighted
            button.BackColor = Color.FromArgb(230, 60, 0);
        }

        /// <summary>
        ///     Handles the MouseLeave event for all buttons in the <see cref="pnlTemplateList"/>
        ///     panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TemplateButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is ButtonWithContent btn)
            {
                if (!btn.IsSelected)
                {
                    btn.BackColor = Color.FromArgb(51, 51, 55);
                }
            }
        }

        /// <summary>
        ///     Handles the MouseClick event for the <see cref="btnWindowsProject"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWindowsProject_MouseClick(object sender, MouseEventArgs e)
        {
            SetSelected(sender as ButtonWithContent);
            TemplateChoosen = MonoGameProjectTemplate.Windows;
        }

        /// <summary>
        ///     Handles the MouseDoubleClick event for the <see cref="btnWindowsProject"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWindowsProject_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetSelected(sender as ButtonWithContent);
            TemplateChoosen = MonoGameProjectTemplate.Windows;
            Next?.Invoke(this, null);

        }



        /// <summary>
        ///     Handles the MouseClick event for the <see cref="btnAndroid"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAndroid_MouseClick(object sender, MouseEventArgs e)
        {
            SetSelected(sender as ButtonWithContent);
            TemplateChoosen = MonoGameProjectTemplate.Android;
            
        }

        /// <summary>
        ///     Handles the MouseDoubleClick event for the <see cref="btnAndroid"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAndroid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetSelected(sender as ButtonWithContent);
            TemplateChoosen = MonoGameProjectTemplate.Android;
            Next?.Invoke(this, null);
        }

        /// <summary>
        ///     Handles the MouseClick event for the <see cref="btnCrossPlatform"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCrossPlatform_MouseClick(object sender, MouseEventArgs e)
        {
            SetSelected(sender as ButtonWithContent);
            TemplateChoosen = MonoGameProjectTemplate.CrossPlatform;
        }

        /// <summary>
        ///     Handles the MouseDoubleClick event for the <see cref="btnCrossPlatform"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCrossPlatform_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetSelected(sender as ButtonWithContent);
            TemplateChoosen = MonoGameProjectTemplate.CrossPlatform;
            Next?.Invoke(this, null);
        }

        /// <summary>
        ///     Handles the MouseClick event for the <see cref="btnIos"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIos_MouseClick(object sender, MouseEventArgs e)
        {
            SetSelected(sender as ButtonWithContent);
            TemplateChoosen = MonoGameProjectTemplate.IOS;
        }

        /// <summary>
        ///     Handles the MouseDoubleClick event for the <see cref="btnCrossPlatform"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetSelected(sender as ButtonWithContent);
            TemplateChoosen = MonoGameProjectTemplate.IOS;
            Next?.Invoke(this, null);
        }


        private void SetSelected(ButtonWithContent control)
        {
            if (_selected == control) { return; }
            if (_selected != null)
            {
                _selected.BackColor = Color.FromArgb(51, 51, 55);
                _selected.IsSelected = false;
            }
            _selected = control;
            _selected.IsSelected = true;
            _selected.BackColor = Color.FromArgb(230, 60, 0);
        }

    }
}
