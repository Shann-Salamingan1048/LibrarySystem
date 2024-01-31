using System.Collections.Generic;
namespace LibrarySystem
{ // Make a student, etc members because I am too lazy to make
    class Teacher : Members // class Teacher inhirited Members
    {
        public Teacher(string name, string age, string address) : base(name, age, address,"Teacher")
        {
        }
    }
}
