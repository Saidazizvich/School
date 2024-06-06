using School.Model.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Crud.Interface
{
    public interface IRepository<T> where T : class
    {    void Insert(int id, string name);

        void Delete(int id);

        void Update(int id, string name);

        List<T> GetListAll();

        T GetById(int id);
    }
}
