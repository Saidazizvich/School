using School.Model.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    class Department :Basic
    {
        public IList<Teacher> Teachers  { get; set; }
    }
}
