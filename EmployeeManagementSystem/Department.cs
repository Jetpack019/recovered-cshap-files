using System.Collections.Generic;

namespace EmployeeManagementApp {
    public class Department {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }

        public Department() {
            Employees = new List<Employee>();
        }
    }
}
