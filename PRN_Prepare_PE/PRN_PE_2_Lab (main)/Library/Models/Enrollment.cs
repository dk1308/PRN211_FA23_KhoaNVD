﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Enrollment
    {
        public Enrollment() { }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime DateUpdate { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
