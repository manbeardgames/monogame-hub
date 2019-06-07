using MonoGameHub.Models;
using MonoGameHub.Views;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MonoGameHub.Windows
{
    public partial class frmMonoGameHub : Form
    {
        /// <summary>
        ///     Referencd to the <see cref="HomeView"/> control that is displayed
        ///     in the <see cref="pnlContentRegion"/> panel
        /// </summary>
        private HomeView _homeView;

        /// <summary>
        ///     Reference to the <see cref="ChooseTemplateView"/> control that is displayed
        ///     in the <see cref="pnlContentRegion"/> panel
        /// </summary>
        private ChooseTemplateView _chooseTemplateView;

        /// <summary>
        ///     Reference to the <see cref="ConfigureProjectView"/> control that is displayed
        ///     in the <see cref="pnlContentRegion"/> panel
        /// </summary>
        private ConfigureProjectView _configureProjectView;

        //  Refrence for building a new project
        private ProjectModel _newProject = new ProjectModel();

        /// <summary>
        ///     Creates a new <see cref="frmMonoGameHub"/> instance
        /// </summary>
        public frmMonoGameHub()
        {
            //  Create a new splash form window and show it as a dialog.
            //  The splash window performs an initial check to see if the MonoGame
            //  SDK is installed.  Once the check is finished, it will automatically
            //  close itself out so that this form can be shown.
            using (var splash = new frmSplash())
            {
                splash.ShowDialog();
            }

            InitializeComponent();

            //  Create a new HomeView control and add it to the content region panel
            _homeView = new HomeView();
            _homeView.Dock = DockStyle.Fill;
            _homeView.NewProjectClicked += (_, e) =>
            {
                pnlContentRegion.Controls.Remove(_homeView);
                pnlContentRegion.Controls.Add(_chooseTemplateView);
            };
            _homeView.Initialize();


            _chooseTemplateView = new ChooseTemplateView();
            _chooseTemplateView.Dock = DockStyle.Fill;
            _chooseTemplateView.Cancel += (_, e) =>
            {
                pnlContentRegion.Controls.Remove(_chooseTemplateView);
                pnlContentRegion.Controls.Add(_homeView);
            };

            _chooseTemplateView.Next += (_, e) =>
            {
                pnlContentRegion.Controls.Remove(_chooseTemplateView);
                _newProject.ProjectType = _chooseTemplateView.TemplateChoosen;
                pnlContentRegion.Controls.Add(_configureProjectView);

            };

            _configureProjectView = new ConfigureProjectView();
            _configureProjectView.Dock = DockStyle.Fill;
            _configureProjectView.Back += (_, e) =>
            {
                pnlContentRegion.Controls.Remove(_configureProjectView);
                pnlContentRegion.Controls.Add(_chooseTemplateView);
            };
            _configureProjectView.Create += (_, e) =>
            {
                ProjectModel project = new ProjectModel()
                {
                    Name = e.ProjectName,
                    Directory = e.Directory,
                    SolutionName = e.SolutionName,
                    ShareDirectory = e.ShareDirectory,
                    //  TODO: This could be brought in using an eventarg above, cachd, then retrieved here
                    ProjectType = _chooseTemplateView.TemplateChoosen,
                };
                CreateNewProject(project);
            };






            pnlContentRegion.Controls.Add(_homeView);
        }

        /// <summary>
        ///     Handles action to perform when <see cref="btnClose"/> is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            //  Close the window
            this.Close();
        }

        private void CreateNewProject(ProjectModel project)
        {
            //  TODO: This needs to be split between project types,
            //  but for testing right now, we'll just assume CrossPlatform
            //  always

            //  First we need to ensure the directory we are gonig to be saving the 
            //  files in exists
            string rootDirectory = project.Directory;
            string slnPath = Path.Combine(rootDirectory, $"{project.SolutionName}.sln");
            string projectDirectory = project.ShareDirectory ? rootDirectory :
                Path.Combine(rootDirectory, project.Name);
            string csprojPath = Path.Combine(projectDirectory, $"{project.Name}.csproj");
            string contentDirectory = Path.Combine(projectDirectory, "Content");
            string propertiesDirectory = Path.Combine(projectDirectory, "Properties");
            string lib32Directory = Path.Combine(projectDirectory, "x86");
            string lib64Directory = Path.Combine(projectDirectory, "x64");

            //  Now, we need to generate two GUIDs, one for the solution and one for the project
            Guid solutionGuid = Guid.NewGuid();
            Guid projectGuid = Guid.NewGuid();
            Guid assemblyGuid = Guid.NewGuid();

            //  Get the embedded resource templates
            Assembly assembly = Assembly.GetExecutingAssembly();
            string appManifestTemplateName = "MonoGameHub.Templates.DesktopGL.AppManifest.template";
            string assemblyInfoTemplateName = "MonoGameHub.Templates.DesktopGL.AssemblyInfo.template";
            string contentTemplateName = "MonoGameHub.Templates.DesktopGL.Content.template";
            string gameTemplateName = "MonoGameHub.Templates.DesktopGL.Game1.template";
            string iconBmpName = "MonoGameHub.Templates.DesktopGL.Icon.bmp";
            string iconIcoName = "MonoGameHub.Templates.DesktopGL.Icon.ico";
            string programTemplateName = "MonoGameHub.Templates.DesktopGL.Program.template";
            string projectTemplateName = "MonoGameHub.Templates.DesktopGL.Project.template";
            string solutionTemplateName = "MonoGameHub.Templates.DesktopGL.Solution.template";


            //  Create directories
            if (!Directory.Exists(rootDirectory))
            {
                Directory.CreateDirectory(rootDirectory);
            }

            if (!Directory.Exists(projectDirectory))
            {
                Directory.CreateDirectory(projectDirectory);
            }

            if (!Directory.Exists(contentDirectory))
            {
                Directory.CreateDirectory(contentDirectory);
            }

            if (!Directory.Exists(propertiesDirectory))
            {
                Directory.CreateDirectory(propertiesDirectory);
            }

            if (!Directory.Exists(lib32Directory))
            {
                Directory.CreateDirectory(lib32Directory);
            }

            if (!Directory.Exists(lib64Directory))
            {
                Directory.CreateDirectory(lib64Directory);
            }

            //  Create the solution file
            string solutionContents = string.Empty;
            using (Stream stream = assembly.GetManifestResourceStream(solutionTemplateName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    solutionContents = reader.ReadToEnd();
                }
            }

            //  Replace any template variables
            solutionContents = solutionContents.Replace("$projectname$", project.Name)
                .Replace("$projectguid$", projectGuid.ToString())
                .Replace("$solutionguid$", solutionGuid.ToString())
                .Replace("$safeprojectname$", project.Name)
                .Replace("$assemblyguid$", assemblyGuid.ToString())
                .Replace("$pathtoproject$", project.ShareDirectory ? "" : $"{project.Name}/");


            //  Write the solution file
            using (FileStream stream = new FileStream(Path.Combine(project.Directory, $"{project.SolutionName}.sln"), FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(solutionContents);
                }
            }

            //  Create the project file
            string projectContents = string.Empty;
            using (Stream stream = assembly.GetManifestResourceStream(projectTemplateName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    projectContents = reader.ReadToEnd();
                }
            }

            //  Replace any template variables
            projectContents = projectContents.Replace("$projectname$", project.Name)
                .Replace("$projectguid$", projectGuid.ToString())
                .Replace("$solutionguid$", solutionGuid.ToString())
                .Replace("$safeprojectname$", project.Name)
                .Replace("$assemblyguid$", assemblyGuid.ToString())
                .Replace("$pathtoproject$", project.ShareDirectory ? "" : $"{project.Name}/");

            //  Write the project file
            using (FileStream stream = new FileStream(Path.Combine(projectDirectory, $"{project.Name}.csproj"), FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(projectContents);
                }
            }


            //  Create the program file
            string programContents = string.Empty;
            using (Stream stream = assembly.GetManifestResourceStream(programTemplateName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    programContents = reader.ReadToEnd();
                }
            }

            //  Replace any template variables
            programContents = programContents.Replace("$projectname$", project.Name)
                .Replace("$projectguid$", projectGuid.ToString())
                .Replace("$solutionguid$", solutionGuid.ToString())
                .Replace("$safeprojectname$", project.Name)
                .Replace("$assemblyguid$", assemblyGuid.ToString())
                .Replace("$pathtoproject$", project.ShareDirectory ? "" : $"{project.Name}/");

            //  Write the project file
            using (FileStream stream = new FileStream(Path.Combine(projectDirectory, $"Program.cs"), FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(programContents);
                }
            }

            //  Create the Game1.cs file
            string gameContents = string.Empty;
            using (Stream stream = assembly.GetManifestResourceStream(gameTemplateName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    gameContents = reader.ReadToEnd();
                }
            }

            //  Replace any template variables
            gameContents = gameContents.Replace("$projectname$", project.Name)
                .Replace("$projectguid$", projectGuid.ToString())
                .Replace("$solutionguid$", solutionGuid.ToString())
                .Replace("$safeprojectname$", project.Name)
                .Replace("$assemblyguid$", assemblyGuid.ToString())
                .Replace("$pathtoproject$", project.ShareDirectory ? "" : $"{project.Name}/");

            //  Write the project file
            using (FileStream stream = new FileStream(Path.Combine(projectDirectory, $"Game1.cs"), FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(gameContents);
                }
            }

            //  Create the Content.mbcb file
            string contentContents = string.Empty;
            using (Stream stream = assembly.GetManifestResourceStream(contentTemplateName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    contentContents = reader.ReadToEnd();
                }
            }

            //  Replace any template variables
            contentContents = contentContents.Replace("$projectname$", project.Name)
                .Replace("$projectguid$", projectGuid.ToString())
                .Replace("$solutionguid$", solutionGuid.ToString())
                .Replace("$safeprojectname$", project.Name)
                .Replace("$assemblyguid$", assemblyGuid.ToString())
                .Replace("$pathtoproject$", project.ShareDirectory ? "" : $"{project.Name}/");

            //  Write the project file
            using (FileStream stream = new FileStream(Path.Combine(contentDirectory, $"Content.mgcb"), FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(contentContents);
                }
            }

            //  Create the Assembly.cs file
            string assemblyContents = string.Empty;
            using (Stream stream = assembly.GetManifestResourceStream(assemblyInfoTemplateName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    assemblyContents = reader.ReadToEnd();
                }
            }

            //  Replace any template variables
            assemblyContents = assemblyContents.Replace("$projectname$", project.Name)
                .Replace("$projectguid$", projectGuid.ToString())
                .Replace("$solutionguid$", solutionGuid.ToString())
                .Replace("$safeprojectname$", project.Name)
                .Replace("$assemblyguid$", assemblyGuid.ToString())
                .Replace("$pathtoproject$", project.ShareDirectory ? "" : $"{project.Name}/");

            //  Write the project file
            using (FileStream stream = new FileStream(Path.Combine(propertiesDirectory, $"AssemblyInfo.cs"), FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(assemblyContents);
                }
            }


            //  Create the app.manifest file
            string appManifestContents = string.Empty;
            using (Stream stream = assembly.GetManifestResourceStream(appManifestTemplateName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    appManifestContents = reader.ReadToEnd();
                }
            }

            //  Replace any template variables
            appManifestContents = appManifestContents.Replace("$projectname$", project.Name)
                .Replace("$projectguid$", projectGuid.ToString())
                .Replace("$solutionguid$", solutionGuid.ToString())
                .Replace("$safeprojectname$", project.Name)
                .Replace("$assemblyguid$", assemblyGuid.ToString())
                .Replace("$pathtoproject$", project.ShareDirectory ? "" : $"{project.Name}/");

            //  Write the project file
            using (FileStream stream = new FileStream(Path.Combine(projectDirectory, $"app.manifest"), FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(appManifestContents);
                }
            }









            //  Copy the Icon.bmp
            using (Stream stream = assembly.GetManifestResourceStream(iconBmpName))
            {
                using (FileStream fileStream = new FileStream(Path.Combine(projectDirectory, "Icon.bmp"), FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    stream.CopyTo(fileStream);
                }
            }

            //  Copy the Icon.ico
            using (Stream stream = assembly.GetManifestResourceStream(iconIcoName))
            {
                using (FileStream fileStream = new FileStream(Path.Combine(projectDirectory, "Icon.ico"), FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    stream.CopyTo(fileStream);
                }
            }

            ProcessStartInfo loadSolution = new ProcessStartInfo(Path.Combine(rootDirectory, $"{project.SolutionName}.sln"));
            loadSolution.UseShellExecute = true;
            Process.Start(loadSolution);
            Application.Exit();






            MessageBox.Show("Finished");
        }


        //---------------------------------------------------------------------
        //  For styling purposes, this form is displayed as borderless. This
        //  means there is no legit way of grabbing the window with the mouse
        //  and moving it somewhere differeng on the users screen if they wish.
        //
        //  The following fields and functions resolve this.  Various controls
        //  on the form use the MouseDown, MouseMove, and MouseUp events below
        //  which will allow users to click and drag the window
        //
        //  This could have been done using the user32.dll DLLImport, but I found
        //  this solution much cleaner and without having to use unmanaged code

        #region Allowing Borderless Form Window To Move With Mouse Implementation
        //  Tracks the last mouse location.
        private Point _lastMouseLocation;
        //  Is the mouse left button down
        private bool _isMouseDown;

        /// <summary>
        ///     Handles the action to perform when the mouse left button is down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            //  Set that the mouse is down
            _isMouseDown = true;

            //  Cache the location the location
            _lastMouseLocation = e.Location;
        }

        /// <summary>
        ///     Handles the action to perform when the mouse cursor moves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                //  Calculate new location for this form
                this.Location = new Point(
                    (Location.X - _lastMouseLocation.X) + e.X, (Location.Y - _lastMouseLocation.Y) + e.Y);
                Update();
            }
        }

        /// <summary>
        ///     Handles the action to perform when the mouse left button is released
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            //  Set that the mouse is no longer down
            _isMouseDown = false;
        }
        #endregion Allowing Borderless Form Window To Move With Mouse Implementation

        //---------------------------------------------------------------------
    }
}
