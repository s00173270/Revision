using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20162017.Models
{
    public class Module
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Module Name")]
        public string ModuleName { get; set; }

        public virtual Attendance AttendanceRef { get; set; }
    }
}