using System;
using System.Collections.Generic;

namespace EmployeeManagementApp {
    class Program {
        static void Main(string[] args) {
            List<Department> departments = new List<Department>();

            Department hrDepartment = new Department { DepartmentName = "Human Resources" };
            Department itDepartment = new Department { DepartmentName = "Information Technology" };

            Employee employee1 = new Employee { EmployeeId = 1, FirstName = "Alice", LastName = "Johnson", DateOfBirth = new DateTime(1985, 5, 10) };
            Employee employee2 = new Employee { EmployeeId = 2, FirstName = "Bob", LastName = "Smith", DateOfBirth = new DateTime(1990, 8, 15) };
            
            Project project1 = new Project { ProjectName = "HR Onboarding", Description = "New employee onboarding process" };
            Project project2 = new Project { ProjectName = "IT System Upgrade", Description = "Upgrading company IT systems" };

            employee1.Projects.Add(project1);
            employee2.Projects.Add(project2);

            hrDepartment.Employees.Add(employee1);
            itDepartment.Employees.Add(employee2);

            departments.Add(hrDepartment);
            departments.Add(itDepartment);

            Console.WriteLine("Employee Management System:");
            foreach (Department department in departments) {
                Console.WriteLine($"Department: {department.DepartmentName}");
                foreach (Employee employee in department.Employees) {
                    Console.WriteLine($"  - {employee}");
                    foreach (Project project in employee.Projects) {
                        Console.WriteLine($"    - Project: {project.ProjectName}");
                    }
                }
            }
        }
    }
}
