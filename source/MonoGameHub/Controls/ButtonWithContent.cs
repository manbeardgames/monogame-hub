using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGameHub.Controls
{
    public partial class ButtonWithContent : UserControl
    {
        [Category("Title")]
        public Font TitleFont
        {
            get { return lblTitle.Font; }
            set
            {
                if (lblTitle.Font == value) { return; }
                lblTitle.Font = value;
            }
        }
        [Category("Title")]
        public string TitleText
        {
            get { return lblTitle.Text; }
            set
            {
                if (lblTitle.Text == value) { return; }
                lblTitle.Text = value;
            }
        }

        [Category("Title")]
        public Color TitleForecolor
        {
            get { return lblTitle.ForeColor; }
            set
            {
                if (lblTitle.ForeColor == value) { return; }
                lblTitle.ForeColor = value;
            }
        }


        [Category("Description")]
        public Font DescriptionFont
        {
            get { return lblDescription.Font; }
            set
            {
                if (lblDescription.Font == value) { return; }
                lblDescription.Font = value;
            }
        }
        [Category("Description")]
        public string DescriptionText
        {
            get { return lblDescription.Text; }
            set
            {
                if (lblDescription.Text == value) { return; }
                lblDescription.Text = value;
            }
        }
        [Category("Description")]
        public Color DescriptionForecolor
        {
            get { return lblDescription.ForeColor; }
            set
            {
                if (lblDescription.ForeColor == value) { return; }
                lblDescription.ForeColor = value;
            }
        }

        [Category("Logo")]
        public Image Logo
        {
            get { return pictureBox.Image; }
            set
            {
                if (pictureBox.Image == value) { return; }
                pictureBox.Image = value;
            }
        }

        public bool IsSelected { get; set; }



        public ButtonWithContent()
        {
            InitializeComponent();
        }

        private void TriggerMouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void TriggerMouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void TriggerMouseCLick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }
    }
}
