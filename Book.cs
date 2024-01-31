using System;
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
        public void PrintBorrowerInfo()
        {
            if (BorrowerInfo.Count > 0)
            {
                Console.WriteLine();
                foreach (var i in BorrowerInfo)
                {
                    Console.WriteLine("{0}: {1}", i.Key, i.Value);
                }
            }
            else
            {
                Console.WriteLine("No Current Borrower.");
            }
        }
    }
}
