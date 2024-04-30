using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardLibrary
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? DifLevel { get; set; }
        public string? AssignedTo { get; set; }

        //[ForeignKey("ProjectModelId")]
        public string? Deadline { get; set; }

        public virtual string? ProjectName { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ Title } ({ DifLevel }|{ AssignedTo }|{ Deadline }|{ ProjectName })";
            }
        }

        public string Status { get; set; }

        //public virtual ICollection<PersonModel>? PersonModels { get; set; }
    }
}
