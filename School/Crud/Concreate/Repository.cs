using School.Crud.Interface;
using School.Model;
using School.Model.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace School.Crud.EF_FileClass
{
    public class Repository<T> : IRepository<T> where T : class 
    {

        List<Basic> basics = new List<Basic>()
        {
             new Student() { Id = 1, Name = "aziz", Card = 46376473, PhoneNumber = "52356362", TcNo = 532563452},
             new Student() { Id = 2, Name = "ege", Card = 00066473, PhoneNumber = "54326362", TcNo = 53299999},
             new Student() { Id = 3, Name = "cem", Card = 466345473, PhoneNumber = "000056362", TcNo = 00003452},
             new Student() { Id = 4, Name = "Kerim", Card = 46552425, PhoneNumber = "16700900", TcNo = 8880001},

             new Course() { Id = 1, Name = "It Programm", Address = "guven mah", Category = new Category(), Location ="Muratpasa" },
             new Course() { Id = 2, Name = "SMMA", Address = "yasar mah", Category = new Category(), Location ="Dosemalti" },
             new Course() { Id = 3, Name = "Pasta", Address = "ilec goya mah", Category = new Category(), Location ="Belek" },
             new Course() { Id = 4, Name = "Sibel Guvenlik", Address = "lavent mah", Category = new Category(), Location ="Konyaalti" },



             new  Category(){ Id = 1, Name = "Bilgisayar Yonetimi" ,Courses = new List<Course>() },
             new  Category(){ Id = 2, Name = "Yemek Dunyasi" ,Courses = new List<Course>() },

             new Teacher(){ Id = 1, Name = "Zehra",Phone = 66363345, Salary = 23000, DepartmentId =1 , Department = new Department()},
             new Teacher(){ Id = 2, Name = "Ayse",Phone = 363663645, Salary = 16000, DepartmentId =2 , Department = new Department()},
             new Teacher(){ Id = 3, Name = "Melih",Phone = 35463645, Salary = 20000, DepartmentId =3 , Department = new Department()},
             new Teacher(){ Id = 4, Name = "Burak",Phone = 0003345, Salary = 13000, DepartmentId =4 , Department = new Department()},

             new Department(){Id = 1, Name = "Matematik", Teachers = new List<Teacher>() },

             

        };




        public void Delete(int id)
        {
            var delete = basics.FirstOrDefault(x => x.Id == id);

            try
            {
                if (delete != null)
                {
                    basics.Remove(delete);
                    Console.Write("Lutfen bir rakam giriniz : " );
                    Console.WriteLine("Bu girdiniz bilgiler gogru tebrik ediyorum sistemeden sildiniz" + id);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Hepsi yanlis ve hatali tekrar deniyiniz");
            }


        }

        public T GetById(int id)
        {
            var getid = basics.Find(x => x.Id == id);

            try
            {


                for (int i = 0; i < getid.Id; i++)
                {
                    if (getid != null)
                    {
                        Console.WriteLine("Simdi siza id bilgiler galdi ve bilgi ala bilirsiniz " + i);
                    }

                }




            }
            catch (Exception)
            {

                Console.WriteLine("Hatali numaralar ve yanlis yol dikkat ");
            }

            return GetById(id);
        }

        public List<T> GetListAll()
        {
            var list = new List<T>();
            foreach (var property in list)
            {
                Console.WriteLine(property);
                basics.ToList();

            }

            return GetListAll().ToList();
        }

        public void Insert(int id, string name)
        {
            Basic basic = new Basic()
            {
                Id = id,
                Name = name
            };

            try
            {
                if (basic != null)
                {
                    basics.Add(basic);
                    Console.WriteLine("Hepsi kayit edildi ve eklendi siza bilgi vermekten cok memenunuz");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("hich ekmedi malesef hatali");
            }

        }

        public void Update(int id, string name)
        {
            var updateid = basics.Find(x => x.Id == id);

            try
            {
                if (updateid != null)
                {
                    updateid.Id = id;
                    updateid.Name = name;
                    basics.Contains(updateid);
                    Console.WriteLine("hepsi dogru yazmakda devam ediyoruz");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("cok yanlis dikkat");
            }
        }
    }

}
