using MonoGameHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameHub.Repositories
{
    public class ProjectsRepository
    {
        public ProjectsRepository()
        {

        }

        public List<ProjectModel> LoadTestProjects()
        {
            ProjectModel projectOne = new ProjectModel()
            {
                Name = "Ophidian",
                SolutionName = "Ophidian",
                PathToProject = @"C:\Users\ManBeardGames\Desktop\projects\Ophidian\Ophidian\Ophidian.csproj",
                PathToSolution = @"C:\Users\ManBeardGames\Desktop\projects\Ophidian\Ophidian.sln"
            };


            List<ProjectModel> projects = new List<ProjectModel>()
            {
                projectOne
            };

            return projects;
        }
    }
}
