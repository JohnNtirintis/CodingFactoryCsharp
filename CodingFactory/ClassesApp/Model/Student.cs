using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp.Model
{
    internal class Student
    {
        // default access modifier is private
        private int id;
        private string? firstname;
        private string? lastname;

        public Student() { }

        /*public Student(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }*/

        // With init keyword, you can init ONCE
        // after that the value is immutable (final)
        public int Id { get => id; set => id = value; }   
        public string? Firstname { get {  return firstname; } set {  firstname = value; } }
        public string? Lastname { get { return lastname; } set { lastname = value; } }
    }
}
