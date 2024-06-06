using School.Model.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    class Course : Basic
    {
        public string Address { get; set; }
        public string Location { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Student> Students { get; set; }
    }
}
