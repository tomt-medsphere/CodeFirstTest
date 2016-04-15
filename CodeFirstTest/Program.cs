using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                ctx.Database.Initialize(true);

                //Student stud = new Student() { StudentName = "New Student" };
                //ctx.Students.Add(stud);
                //ctx.SaveChanges();
            }
            Console.WriteLine("hello Tom!");
            Console.ReadLine();
        }
    }
}
