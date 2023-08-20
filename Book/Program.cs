using System;
using LibraryApp;

namespace LibraryConsoleApp {
    class Program {
        static void Main(string[] args) {
            Library library = new Library();

            Book book1 = new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", YearPublished = 1951 };
            Book book2 = new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 };

            library.AddBook(book1);
            library.AddBook(book2);

            Console.WriteLine("Library Books:");
            foreach (Book book in library.GetAllBooks()) {
                Console.WriteLine(book);
            }
        }
    }
}
