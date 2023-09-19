using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopyApp.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public Address? StudentAddress { get; set; }

        public override string? ToString()
        {
            return $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, Student Address: {StudentAddress}";
        }

        public Student GetCopyByReference()
        {
            return this;
        }

        public Student GetShallowCopy() 
        {
            return (Student)MemberwiseClone();
        }

        public Student GetDeepCopy()
        {
            Student? student = MemberwiseClone() as Student;
            if (student is not null)
            {
                student.StudentAddress = new Address()
                {
                    Street = StudentAddress?.Street,
                    Number = StudentAddress?.Number,
                    Zipcode = StudentAddress?.Zipcode
                };
            }

            return student!;
        }

        public Student(Student student)
        {
            Id = student.Id;
            FirstName = student.FirstName;
            LastName = student.LastName;
            StudentAddress = new Address()
            {
                Street = student?.StudentAddress?.Street,
                Number = student?.StudentAddress?.Number,
                Zipcode= student?.StudentAddress?.Zipcode
            };
        }
    }
}
