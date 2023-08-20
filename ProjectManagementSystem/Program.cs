using System;
using System.Collections.Generic;

namespace ProjectManagementApp {
    class Program {
        static void Main(string[] args) {
            List<Project> projects = new List<Project>();

            Project project1 = new Project { ProjectId = 1, Name = "Website Redesign", StartDate = new DateTime(2023, 1, 1), EndDate = new DateTime(2023, 6, 30) };
            Project project2 = new Project { ProjectId = 2, Name = "Mobile App Development", StartDate = new DateTime(2023, 2, 1), EndDate = new DateTime(2023, 7, 31) };

            Task task1 = new Task { TaskId = 1, Description = "Design mockups", IsCompleted = true };
            Task task2 = new Task { TaskId = 2, Description = "Front-end development", IsCompleted = false };

            TeamMember member1 = new TeamMember { TeamMemberId = 1, Name = "Alice", Role = "Designer" };
            TeamMember member2 = new TeamMember { TeamMemberId = 2, Name = "Bob", Role = "Developer" };

            project1.Tasks.Add(task1);
            project2.Tasks.Add(task2);

            project1.TeamMembers.Add(member1);
            project2.TeamMembers.Add(member2);

            projects.Add(project1);
            projects.Add(project2);

            Console.WriteLine("Project Management System:");
            foreach (Project project in projects) {
                Console.WriteLine(project);
                Console.WriteLine("Tasks:");
                foreach (Task task in project.Tasks) {
                    Console.WriteLine("  - " + task);
                }
                Console.WriteLine("Team Members:");
                foreach (TeamMember member in project.TeamMembers) {
                    Console.WriteLine("  - " + member.Name + " (" + member.Role + ")");
                }
            }
        }
    }
}
