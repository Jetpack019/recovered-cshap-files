using System;
using System.Collections.Generic;

namespace LMSApp {
    public class Course {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Instructor { get; set; }
        public List<Assignment> Assignments { get; set; }

        public Course() {
            Assignments = new List<Assignment>();
        }

        public override string ToString() {
            return $"{Title} (Instructor: {Instructor})";
        }
    }
}
