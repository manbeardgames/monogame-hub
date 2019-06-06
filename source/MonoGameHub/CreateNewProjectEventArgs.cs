using System;

namespace MonoGameHub
{
    public class CreateNewProjectEventArgs : EventArgs
    {
        /// <summary>
        ///     The name of the project
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        ///     The name of the solution
        /// </summary>
        public string SolutionName { get; set; }

        /// <summary>
        ///     The fully qualified path to the directory to save the files
        /// </summary>
        public string Directory { get; set; }

        /// <summary>
        ///     Should the solution and project share the same directory
        /// </summary>
        public bool ShareDirectory { get; set; }

        /// <summary>
        ///     The type of MonoGame template to use
        /// </summary>
        public MonoGameProjectTemplate Template { get; set; }

        /// <summary>
        ///     Creates a new <see cref="CreateNewProjectEventArgs"/> instance
        /// </summary>
        public CreateNewProjectEventArgs() { }

        /// <summary>
        ///     Creates a new <see cref="CreateNewProjectEventArgs"/> instance
        /// </summary>
        /// <param name="projectName">The name of the project</param>
        /// <param name="solutionname">The name of the solution</param>
        /// <param name="directory">The fully qualifie dpath to the directory to save the files</param>
        /// <param name="shareDirectory">Should the solution and project share the same directory</param>
        /// <param name="template">The type of MonoGame template to use</param>
        public CreateNewProjectEventArgs(string projectName, string solutionname, string directory, bool shareDirectory, MonoGameProjectTemplate template)
        {
            ProjectName = projectName;
            SolutionName = solutionname;
            Directory = directory;
            ShareDirectory = shareDirectory;
            Template = template;
        }
    }
}
