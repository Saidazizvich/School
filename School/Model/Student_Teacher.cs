﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    class Student_Teacher // many to many
    {
        public int StudentId { get; set; }
        public int TeachertId { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
    }
}
