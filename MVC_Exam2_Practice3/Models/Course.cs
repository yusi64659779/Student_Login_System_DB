using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Exam2_Practice3.Models
{
    public class Course
    {
        [Key]
        public string CourseId { get; set; }
        public string StudentId { get; set; }
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }
    }
}
