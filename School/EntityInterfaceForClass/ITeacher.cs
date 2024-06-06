using School.Crud.Interface;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.EntityInterfaceForClass
{
    interface ITeacher : IRepository<Teacher>
    {
    }
}
