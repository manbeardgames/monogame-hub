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

            ProjectModel projectTwo = new ProjectModel()
            {
                Name = "Echo",
                SolutionName = "Echo",
                PathToProject = @"C:\Users\ManBeardGames\Desktop\projects\Echo\Echo\Echo.csproj",
                PathToSolution = @"C:\Users\ManBeardGames\Desktop\projects\Echo\Echo.sln"
            };

            ProjectModel projectThree = new ProjectModel()
            {
                Name = "ManBeardvsManBear",
                SolutionName = "ManBeardvsManBear",
                PathToProject = @"C:\Users\ManBeardGames\Desktop\projects\ManBeardvsManBear\ManBeardvsManBear\ManBeardvsManBear.csproj",
                PathToSolution = @"C:\Users\ManBeardGames\Desktop\projects\ManBeardvsManBear\ManBeardvsManBear.sln"
            };

            List<ProjectModel> projects = new List<ProjectModel>()
            {
                projectOne,
                projectTwo,
                projectThree
            };

            return projects;
        }
    }
}
