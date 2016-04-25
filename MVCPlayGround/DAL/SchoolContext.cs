using MVCPlayGround.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCPlayGround.DAL
{
    public class SchoolContext : DbContext
    {
        // TODO:[3] Replace constuctor base and define DbSets to be replicated in DB

        //Constructor 
        public SchoolContext()
            : base("SchoolContext")//Connection string name of the Web.config
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Force to crete singular table names 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}