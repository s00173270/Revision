using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _20162017.Models
{
    public class Attendance
    {
        [Key]
        [Display(Name = "Attendance ID")]
        public int ID { get; set; }

        [ForeignKey("ModulesRef")]
        public int ModuleID { get; set; }
        [ForeignKey("StudentsRef")]
        public string CollegeID { get; set; }
        [Display(Name = "Date and Time of Attendance")]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy HH:mm}", ApplyFormatInEditMode =false)]        
        public DateTime AttendanceDateTime { get; set; }
        [Display(Name = "Present")]
        public bool Present { get; set; }


        public virtual ICollection<Module> ModulesRef { get; set; }
        public virtual ICollection<Student> StudentsRef { get; set; }
    }
}