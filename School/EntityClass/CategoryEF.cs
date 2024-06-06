using School.Crud.EF_FileClass;
using School.EntityInterfaceForClass;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.EntityClass
{
    public class CategoryEF : Repository<Category>, ICategory
    {

        public CategoryEF() 
        { 
        }

        public CategoryEF(string name )
        {
            
        }
    }
}
