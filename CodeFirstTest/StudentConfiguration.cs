using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    public class StudentConfiguation : EntityTypeConfiguration<Student>
    {
        public StudentConfiguation()
        {
            ToTable("Students");
            HasKey(p => p.StudentID);
            Property(p => p.StudentName).IsRequired().HasMaxLength(40);
        }
    }
}
