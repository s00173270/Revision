using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _20162017.Models
{
    public class ContextInitializer :DropCreateDatabaseIfModelChanges<CoreContext>
    {
        protected override void Seed(CoreContext context)
        {
            var students = new List<Student>
            {
                new Student() {FirstName="John", SecondName="Kelly",CollegeID="ITS"},
                new Student() {FirstName="Alan", SecondName="Smith", CollegeID="DKIT" }
            };


            var modules = new List<Module>
            {
                new Module(){ID=1, ModuleName="RAD 302"},
                new Module(){ID=2, ModuleName="Server Management 302"}
            };

            var attendances = new List<Attendance>
            {
                new Attendance() {ID=1, CollegeID="ITS", ModuleID=1, Present=true},
                new Attendance() {ID=2, CollegeID="DKIT", ModuleID=2, Present=false}
            };

            students.ForEach(u => context.StudentRef.Add(u));
            modules.ForEach(u => context.ModulesRef.Add(u));
            attendances.ForEach(u => context.AttendanceRef.Add(u));
           

            base.Seed(context);
        }
    }
}