using School.Model.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    class Teacher : Basic
    {
        public decimal Salary { get; set; }
        public long Phone { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
