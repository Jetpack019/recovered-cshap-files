using System;
using System.Collections.Generic;

namespace EmployeeManagementApp {
    public class Employee {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Project> Projects { get; set; }

        public Employee() {
            Projects = new List<Project>();
        }

        public override string ToString() {
            return $"{FirstName} {LastName} (Employee ID: {EmployeeId})";
        }
    }
}
