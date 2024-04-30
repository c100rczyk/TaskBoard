using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BoardLibrary
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? email { get; set; }

        public string FullName 
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

        //public virtual TaskModel? TaskModel { get; set; }
        //public virtual ProjectModel ProjectModel { get; set; }

        public PersonModel()
        {
        }
        public PersonModel(string firstName, string lastName, string mail)
        {
            FirstName = firstName;
            LastName = lastName;
            email = mail;
        }
    }
}
