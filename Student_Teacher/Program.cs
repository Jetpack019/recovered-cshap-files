using System;
using MyNamespace;

namespace MyApp {
    class Program {
        static void Main(string[] args) {
            Student student = new Student {
                FirstName = "John",
                LastName = "Doe",
                StudentId = 123,
                Major = "Computer Science"
            };

            Teacher teacher = new Teacher {
                FirstName = "Jane",
                LastName = "Smith",
                Subject = "Math",
                YearsOfExperience = 10
            };

            Console.WriteLine("Student: " + student.GetFullName()+" " + student.Major+" " + student.StudentId);
            Console.WriteLine("Teacher: " + teacher.GetFullName());
        }
    }
}
