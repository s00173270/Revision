using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20162017.Models
{
    public class Student
    {
        [Key]

        public string CollegeID { get; set; }
        [Display (Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string SecondName { get; set; }

        public virtual ICollection<Attendance> AttendanceRef { get; set; }
    }
}