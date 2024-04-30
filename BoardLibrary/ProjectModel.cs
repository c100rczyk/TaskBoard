using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BoardLibrary
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string? ProjectName { get; set; }
        public string? Technology { get; set; }

        public ProjectModel()
        {
        }

        public ProjectModel(string projectname, string technology)
        {
            ProjectName = projectname;
            Technology = technology;
        }
    }

  
}
