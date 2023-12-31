using System.Collections.Generic;

namespace LibraryApp {
    public class Library {
        private List<Book> books;

        public Library() {
            books = new List<Book>();
        }

        public void AddBook(Book book) {
            books.Add(book);
        }

        public List<Book> GetAllBooks() {
            return books;
        }
    }
}
