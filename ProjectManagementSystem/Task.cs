namespace ProjectManagementApp {
    public class Task {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString() {
            return $"{Description} - {(IsCompleted ? "Completed" : "Pending")}";
        }
    }
}
