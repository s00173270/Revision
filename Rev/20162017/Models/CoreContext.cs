using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _20162017.Models
{
    public class CoreContext:DbContext
    {
        public DbSet<Student> StudentRef { get; set; }
        public DbSet<Module> ModulesRef { get; set; }
        public DbSet<Attendance> AttendanceRef { get; set; }

        public CoreContext()
            :base("CoreContext")
        {
            Database.SetInitializer(new ContextInitializer());
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}