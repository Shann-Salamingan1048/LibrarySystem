using System.Collections.Generic;
namespace LibrarySystem
{ // Make a student, etc members because I am too lazy to make
    class Teacher : Members // class Teacher inhirited Members
    {
        public Dictionary<string, string> TeacherInfo = new Dictionary<string, string>();
        public Teacher(string name, string age, string address) : base(name, "Teacher")
        {
            TeacherInfo["Name"] = name;
            TeacherInfo["Name"] = age;
            TeacherInfo["Name"] = address;
        }
    }
}
