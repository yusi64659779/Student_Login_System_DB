using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Exam2_Practice3.Models
{
    public class Exam
    {
        [Key]
        public string ExamId { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public string Mark { get; set; }
    }
}
