using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library<Book> library = new Library<Book>("Shann's Library");
            Book book1 = new Book() {Author = "Shanny Salamingan", Title = "C++ With Shanny 7th Edition", BookID = 51252};
            Book book2 = new Book() { Author = "Salamingan", Title = "C# Depth Learning 9th Edition", BookID = 12512 };
            library.AddBook(book1);
            library.AddBook(book2);
            library.AvailbleBooks();
            Teacher t1 = new Teacher("Samira", "33", "San Juan Purok 4");
            t1.BorrowABook(book1);

            library.AvailbleBooks();
            library.BorrowedBooks();
            t1.ReturnABook(book1);
            library.AvailbleBooks();
            Console.ReadKey();
        }
    }
}
