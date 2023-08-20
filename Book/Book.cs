namespace LibraryApp {
    public class Book {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        public override string ToString() {
            return $"{Title} by {Author} ({YearPublished})";
        }
    }
}
