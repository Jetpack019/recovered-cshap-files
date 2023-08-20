using System;
using System.Collections.Generic;

namespace LMSApp {
    public class Student {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> EnrolledCourses { get; set; }

        public Student() {
            EnrolledCourses = new List<Course>();
        }

        public override string ToString() {
            return $"{FirstName} {LastName} (Student ID: {StudentId})";
        }
    }
}
