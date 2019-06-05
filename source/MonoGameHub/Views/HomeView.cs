using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonoGameHub.Controls;
using MonoGameHub.Repositories;
using MonoGameHub.Models;

namespace MonoGameHub.Views
{
    public partial class HomeView : UserControl
    {
        [Browsable(true)]
        public event EventHandler InstallMonoGameClicked;
        [Browsable(true)]
        public event EventHandler NewProjectClicked;
        [Browsable(true)]
        public event EventHandler OpenProjectClicked;
        [Browsable(true)]
        public event EventHandler LearnMonoGameClicked;


        /// <summary>
        ///     Creates a new <see cref="HomeView"/> instance
        /// </summary>
        public HomeView()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Initializes the controls that are not added through the designer
        /// </summary>
        public void Initialize()
        {
            //  If MonoGame installation was not detected, add the download/install button
            if(Program.MonoGameInstall != MonoGameInstallType.Installed)
            {
                DownloadInstallButton installButton = new DownloadInstallButton();
                installButton.Initialize();
                installButton.MouseEnter += GettingStartedButton_MouseEnter;
                installButton.MouseLeave += GettingStartedButton_MouseLeave;
                installButton.DownloadAndInstallCompleted += (_, e) =>
                {
                    pnlGettingStartedList.Controls.Remove(installButton);
                };
                pnlGettingStartedList.Controls.Add(installButton);
                pnlGettingStartedList.Controls.SetChildIndex(installButton, 0);

            }


            //  Load projects
            ProjectsRepository repo = new ProjectsRepository();
            List<ProjectModel> projects = repo.LoadTestProjects();
            foreach(var project in projects)
            {
                ButtonWithContent button = new ButtonWithContent();
                button.BackColor = Color.Transparent;
                button.Size = new Size(468, 75);
                button.Logo = MonoGameHub.Properties.Resources.file_document_box_multiple_outline;
                button.TitleText = project.Name;
                button.DescriptionText = project.PathToSolution;
                pnlProjectList.Controls.Add(button);
            }

            foreach (var project in projects)
            {
                ButtonWithContent button = new ButtonWithContent();
                button.BackColor = Color.Transparent;
                button.Size = new Size(468, 75);
                button.Logo = MonoGameHub.Properties.Resources.file_document_box_multiple_outline;
                button.TitleText = project.Name;
                button.DescriptionText = project.PathToSolution;
                pnlProjectList.Controls.Add(button);
            }

            foreach (var project in projects)
            {
                ButtonWithContent button = new ButtonWithContent();
                button.BackColor = Color.Transparent;
                button.Size = new Size(468, 75);
                button.Logo = MonoGameHub.Properties.Resources.file_document_box_multiple_outline;
                button.TitleText = project.Name;
                button.DescriptionText = project.PathToSolution;
                pnlProjectList.Controls.Add(button);
            }

            foreach (var project in projects)
            {
                ButtonWithContent button = new ButtonWithContent();
                button.BackColor = Color.Transparent;
                button.Size = new Size(468, 75);
                button.Logo = MonoGameHub.Properties.Resources.file_document_box_multiple_outline;
                button.TitleText = project.Name;
                button.DescriptionText = project.PathToSolution;
                pnlProjectList.Controls.Add(button);
            }

            foreach (var project in projects)
            {
                ButtonWithContent button = new ButtonWithContent();
                button.BackColor = Color.Transparent;
                button.Size = new Size(468, 75);
                button.Logo = MonoGameHub.Properties.Resources.file_document_box_multiple_outline;
                button.TitleText = project.Name;
                button.DescriptionText = project.PathToSolution;
                pnlProjectList.Controls.Add(button);
            }

            foreach (var project in projects)
            {
                ButtonWithContent button = new ButtonWithContent();
                button.BackColor = Color.Transparent;
                button.Size = new Size(468, 75);
                button.Logo = MonoGameHub.Properties.Resources.file_document_box_multiple_outline;
                button.TitleText = project.Name;
                button.DescriptionText = project.PathToSolution;
                pnlProjectList.Controls.Add(button);
            }                               
        }

        /// <summary>
        ///     Handles the MouseEnter event for all buttons in the <see cref="pnlGettingStartedList"/>
        ///     panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GettingStartedButton_MouseEnter(object sender, EventArgs e)
        {
            //  Get reference to the button as a Control
            Control button = sender as Control;

            //  Change the background color to show that the button is highlighted
            button.BackColor = Color.FromArgb(230, 60, 0);
        }

        /// <summary>
        ///     Handles the MouseLeave event for all buttons in the <see cref="pnlGettingStartedList"/>
        ///     panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GettingStartedButton_MouseLeave(object sender, EventArgs e)
        {
            //  Get refrence to the button as a Control
            Control button = sender as Control;

            //  Change the background color to show that the button is no longer highlighted
            button.BackColor = Color.FromArgb(51, 51, 55);
        }

        private void BtnInstall_MouseClick(object sender, MouseEventArgs e)
        {
            InstallMonoGameClicked?.Invoke(this, null);
        }

        private void BtnLearn_MouseClick(object sender, MouseEventArgs e)
        {
            LearnMonoGameClicked?.Invoke(this, null);
        }

        private void BtnOpenProject_MouseClick(object sender, MouseEventArgs e)
        {
            OpenProjectClicked?.Invoke(this, null);
        }

        private void BtnNewProject_MouseClick(object sender, MouseEventArgs e)
        {
            NewProjectClicked?.Invoke(this, null);
        }
    }
}
