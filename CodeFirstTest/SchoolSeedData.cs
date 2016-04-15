using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    public class SchoolSeedData : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            GetStudents().ForEach(c => context.Students.Add(c));
            context.Students.Add(new Student { StudentName = "Tom Tucker" });

        }

        private static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student {StudentName = "John Doe"},
                new Student {StudentName = "Jane Doe"},
                new Student {StudentName = "Humpty J Dumpty"}
            };
        }

    }
}
