using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Student
    {
        public int StudentId { get; set; }  // Primary Key
        public string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
