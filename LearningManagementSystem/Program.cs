using System;
using System.Collections.Generic;

namespace LMSApp {
    class Program {
        static void Main(string[] args) {
            List<Student> students = new List<Student>();
            List<Course> courses = new List<Course>();

            Course course1 = new Course { CourseId = 1, Title = "Introduction to Programming", Instructor = "Alice Johnson" };
            Course course2 = new Course { CourseId = 2, Title = "Web Development Fundamentals", Instructor = "Bob Smith" };

            Assignment assignment1 = new Assignment { AssignmentId = 1, Title = "Hello World Program", Description = "Write a simple 'Hello, world!' program.", IsCompleted = true };
            Assignment assignment2 = new Assignment { AssignmentId = 2, Title = "Create a Portfolio Website", Description = "Build a personal portfolio website.", IsCompleted = false };

            course1.Assignments.Add(assignment1);
            course2.Assignments.Add(assignment2);

            Student student1 = new Student { StudentId = 1, FirstName = "John", LastName = "Doe" };
            Student student2 = new Student { StudentId = 2, FirstName = "Jane", LastName = "Smith" };

            student1.EnrolledCourses.Add(course1);
            student2.EnrolledCourses.Add(course2);

            students.Add(student1);
            students.Add(student2);

            courses.Add(course1);
            courses.Add(course2);

            Console.WriteLine("Learning Management System:");
            foreach (Course course in courses) {
                Console.WriteLine(course);
                Console.WriteLine("Assignments:");
                foreach (Assignment assignment in course.Assignments) {
                    Console.WriteLine($"  - {assignment.Title} - {(assignment.IsCompleted ? "Completed" : "Pending")}");
                }
            }

            Console.WriteLine("\nStudents and Enrolled Courses:");
            foreach (Student student in students) {
                Console.WriteLine(student);
                Console.WriteLine("Enrolled Courses:");
                foreach (Course course in student.EnrolledCourses) {
                    Console.WriteLine($"  - {course.Title}");
                }
            }
        }
    }
}
