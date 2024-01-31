using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    class Library<T> where T : Book // This Constraints that it only accept the class "Book"
        // Generic type T to be either the Book class or a class derived from the Book class
    {
        private string Name;
        private List<T> Books = new List<T>();
        public Library(string Name)
        {
            this.Name = Name;
        }
        public void AddBook(T book)
        {
            this.Books.Add(book);
        }
        public void RemoveBook(T book)
        {
            this.Books.Remove(book);
        }
        public void AvailbleBooks()
        {
            UInt16 count = 1;
            Console.WriteLine(this.Name);
            foreach (T book in this.Books)
            { 
                if (!(book.IsBorrwed)) // if it is not borrowed then display the availble books
                {
                    Console.WriteLine();
                    Console.WriteLine("Book #{0}",count);
                    Console.WriteLine("Title: {0}",book.Title);
                    Console.WriteLine("Author: {0}", book.Author);
                    Console.WriteLine("Book ID: {0}", book.BookID);
                    Console.WriteLine();
                    count++;
                }
            }
        }
        public void BorrowedBooks()
        {
            UInt16 count = 1;
            Console.WriteLine(this.Name);
            foreach (T book in this.Books)
            {
                if (book.IsBorrwed)
                {
                    Console.WriteLine();
                    Console.WriteLine("Book #{0}", count);
                    Console.WriteLine("Title: {0}", book.Title);
                    Console.WriteLine("Author: {0}", book.Author);
                    Console.WriteLine("Book ID: {0}", book.BookID);
                    Console.WriteLine("Borrowed by: {0} [{1}]", book.Borrower, book.BorroweMemberType);
                    Console.WriteLine();
                    count++;
                }
            }
        }
    }
}
