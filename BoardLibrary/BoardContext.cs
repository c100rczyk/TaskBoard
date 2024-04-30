using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class BoardContext : DbContext
    {
        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<ProjectModel> Project { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UBHQ494; Database=TaskBoard;
                                        Trusted_Connection=True; TrustServerCertificate=True");
            
        }
    }
}

//base.OnConfiguring(optionsBuilder);

