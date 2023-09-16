using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp.Model
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public override bool Equals(object? obj)
        {
            // is, checks of obs is an instance of teacher
            return obj is Teacher teacher &&
                   Id == teacher.Id &&
                   Firstname == teacher.Firstname &&
                   Lastname == teacher.Lastname;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Firstname, Lastname);
        }

        public override string ToString() => $"{Id} {Firstname} {Lastname} ";
        

    }
}
