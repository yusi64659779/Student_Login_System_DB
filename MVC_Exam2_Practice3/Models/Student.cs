﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Exam2_Practice3.Models
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
