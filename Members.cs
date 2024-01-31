namespace LibrarySystem
{
    class Members
    {
        private string Name;
        private string MemberType;
        public Members(string Name, string MemberType)
        {
            this.Name = Name;
            this.MemberType = MemberType;
        }
        public void BorrowABook(Book book)
        {
            book.IsBorrwed = true;
            book.Borrower = this.Name;
            book.BorroweMemberType = this.MemberType; 
        }
        public void ReturnABook(Book book)
        {
            book.IsBorrwed = false;
        }
    }
}
