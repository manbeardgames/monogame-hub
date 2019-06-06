using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameHub.Models
{
    public class ProjectModel
    {
        public MonoGameProjectTemplate ProjectType { get; set; }
        public string Name { get; set; }
        public string Directory { get; set; }
        public string SolutionName { get; set; }
        public bool ShareName { get; set; }
        public bool ShareDirectory { get; set; }
        public string PathToProject { get; set; }
        public string PathToSolution { get; set; }


    }
}
