using MonoGameHub.Models;
using System;
using System.Collections.Generic;
using System.IO;
using MonoGameHub.Utils;

namespace MonoGameHub.Utils
{
    public static class SaveLoad
    {
        /// <summary>
        ///     Saves the collection of projects to disk
        /// </summary>
        /// <param name="projects">The collection of projects to save</param>
        public static void Save(List<ProjectModel> projects)
        {
            EnsureDirectory();

            using (FileStream stream = new FileStream(Path.Combine(Constants.DATA_ROOT_DIR, Constants.DATA_PROJECTS_FILENAME), FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    // First write how many projects we'll be saving
                    writer.Write(projects.Count);

                    //  Next iterate each of the projects and serialize out their properties
                    for (int i = 0; i < projects.Count; i++)
                    {
                        writer.Write(projects[i].ProjectName);
                        writer.Write(projects[i].SolutionName);
                        writer.Write(projects[i].ProjectPath);
                        writer.Write(projects[i].SolutionPath);
                        writer.Write(projects[i].Version);
                        writer.Write(projects[i].Created.ToBinary());
                        writer.Write(projects[i].Modified.ToBinary());
                    }
                }
            }
        }

        public static List<ProjectModel> LoadProjects()
        {
            //  Create a new collection of ProjectModel.
            List<ProjectModel> projects = new List<ProjectModel>();

            //  Check if the projects list file exists. If it doesn't just return
            //  our empty list
            if (!File.Exists(Path.Combine(Constants.DATA_ROOT_DIR, Constants.DATA_PROJECTS_FILENAME)))
            {
                return projects;
            }

            using (FileStream stream = new FileStream(Path.Combine(Constants.DATA_ROOT_DIR, Constants.DATA_PROJECTS_FILENAME), FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    //  Read how many projects there are
                    int count = reader.ReadInt32();

                    //  Read the projects
                    for (int i = 0; i < count; i++)
                    {
                        ProjectModel project = new ProjectModel();
                        project.ProjectName = reader.ReadString();
                        project.SolutionName = reader.ReadString();
                        project.ProjectPath = reader.ReadString();
                        project.SolutionPath = reader.ReadString();
                        project.Version = reader.ReadString();
                        project.Created = DateTime.FromBinary(reader.ReadInt64());
                        project.Modified = DateTime.FromBinary(reader.ReadInt64());
                        projects.Add(project);
                    }
                }
            }

            return projects;
        }

        /// <summary>
        ///     Ensures that the <see cref="ROOT_DIRECTORY"/> exists
        /// </summary>
        internal static void EnsureDirectory()
        {
            if (!Directory.Exists(Constants.DATA_ROOT_DIR))
            {
                Directory.CreateDirectory(Constants.DATA_ROOT_DIR);
            }
        }
    }
}
