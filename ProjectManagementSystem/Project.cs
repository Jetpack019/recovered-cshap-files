using System;
using System.Collections.Generic;

namespace ProjectManagementApp {
    public class Project {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Task> Tasks { get; set; }
        public List<TeamMember> TeamMembers { get; set; }

        public Project() {
            Tasks = new List<Task>();
            TeamMembers = new List<TeamMember>();
        }

        public override string ToString() {
            return $"{Name} - Start: {StartDate}, End: {EndDate}";
        }
    }
}
