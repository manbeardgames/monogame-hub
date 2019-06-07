using MonoGameHub.Controls;
using MonoGameHub.Models;
using MonoGameHub.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGameHub.Views
{
    public partial class HomeView : UserControl
    {
        /// <summary>
        ///     Occurs when the <see cref="btnNewProject"/> control is clicked
        /// </summary>
        public event EventHandler NewProjectClicked;

        /// <summary>
        ///     Occurs when the <see cref="btnOpenProject"/> control is clicked
        /// </summary>
        public event EventHandler OpenProjectClicked;

        /// <summary>
        ///     Occurs when the <see cref="btnLearn"/> control is clicked
        /// </summary>
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
            if (Program.MonoGameInstall != MonoGameInstallType.Installed)
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
            foreach (var project in projects)
            {
                ButtonWithContent button = new ButtonWithContent();
                button.BackColor = Color.Transparent;
                button.Size = new Size(450, 75);
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

        /// <summary>
        ///     Handles the MouseClick event for the <see cref="btnLearn"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLearn_MouseClick(object sender, MouseEventArgs e)
        {
            //  Triggers the LearnMonoGameClicked event
            LearnMonoGameClicked?.Invoke(this, null);
        }

        /// <summary>
        ///     Handles the MouseClick event for the <see cref="btnOpenProject"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpenProject_MouseClick(object sender, MouseEventArgs e)
        {
            //  Trigger the OpenProjectClicked event
            OpenProjectClicked?.Invoke(this, null);
        }

        /// <summary>
        ///     Handles the MouseClick event for the <see cref="btnNewProject"/> control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewProject_MouseClick(object sender, MouseEventArgs e)
        {
            //  Trigger the NewProjectClicked event
            NewProjectClicked?.Invoke(this, null);
        }
    }
}
