using Microsoft.EntityFrameworkCore;
using BoardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace BoardLibrary
{
    
    public class DbContextConnectorClass : DbContext
    {
        public IConfiguration _config { get; set; }

        public DbContextConnectorClass(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DataBaseConnection"));
        }
        //public DbContextConnectorClass() : base()
        //{

        //}

        public DbSet<PersonModel> People { get; set; }
        //public DbSet<ProjectModel> Projects { get; set; }
        //public DbSet<TaskModel> Tasks { get; set; }

    }
}
