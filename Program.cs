using System;
using System.Linq;
using EntityFramework;

namespace CodeFirstDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please wait...");
            using (var context = new SchoolContext())
            {
                // Add a new student
                var student = new Student
                {
                    Name = "Cem Topaloglu",
                    EnrollmentDate = DateTime.Now
                };

                context.Students.Add(student);
                context.SaveChanges();

                // Display all students
                var students = context.Students.ToList();
                Console.WriteLine("Student List:");
                foreach (var s in students)
                {
                    Console.WriteLine($"ID: {s.StudentId}, Name: {s.Name}, Enrolled: {s.EnrollmentDate}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
