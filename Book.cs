using System.Collections.Generic;

namespace LibrarySystem
{
    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int BookID { get; set; }
        public bool IsBorrwed { get; set; }
        public string Borrower { get; set; }
        public string BorroweMemberType { get; set; } // Techer or Studennt etc
        public Dictionary<string , string> BorrowerInfo = new Dictionary<string , string>();
    }
}
