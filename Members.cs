namespace LibrarySystem
{
    class Members
    {
        private string Name;
        private string Age;
        private string Address;
        private string MemberType;
        public Members(string Name, string Age, string Address, string MemberType)
        {
            this.Name = Name;
            this.Age = Age;
            this.Address = Address;
            this.MemberType = MemberType;
        }
        public void BorrowABook(Book book)
        {
            book.IsBorrwed = true;
            book.Borrower = this.Name;
            book.BorroweMemberType = this.MemberType;
            book.BorrowerInfo["Name"] = this.Name;
            book.BorrowerInfo["Age"] = this.Age;
            book.BorrowerInfo["Address"] = this.Address;
        }
        public void ReturnABook(Book book)
        {
            book.IsBorrwed = false;
            book.BorrowerInfo.Clear(); // Clear Borrower
        }
    }
}
