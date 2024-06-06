using School.Model.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    public class Student : Basic
    {
        public string PhoneNumber { get; set; }

        public long Card { get; set; }
        public long TcNo { get; set; }

        //public int CourseId { get; set; }
        //public Course Course { get; set; }
    }
}
