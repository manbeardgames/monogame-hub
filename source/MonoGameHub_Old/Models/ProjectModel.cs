using System;

namespace MonoGameHub.Models
{
    public class ProjectModel
    {
        /// <summary>
        ///     The name of the project
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        ///     The name of the solution for the project
        /// </summary>
        public string SolutionName { get; set; }

        /// <summary>
        ///     The fully qualified path to the solution (.sln) file
        /// </summary>
        public string SolutionPath { get; set; }

        /// <summary>
        ///     The fully qualified path to the project (.csproj) file
        /// </summary>
        public string ProjectPath { get; set; }

        /// <summary>
        ///     The MonoGame version used
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        ///     The date and time the project was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        ///     The last date and time the project was modified
        /// </summary>        
        public DateTime Modified { get; set; }

        public override string ToString()
        {
            return $"ProjectName: {ProjectName} -- SolutionName: {SolutionName} -- ProjectPath: {ProjectPath} -- SolutionPath {SolutionPath} -- Version {Version} -- Created: {Created} -- Modified: {Modified}";
        }
    }
}
