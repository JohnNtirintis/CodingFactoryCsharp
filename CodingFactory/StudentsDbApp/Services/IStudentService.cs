using StudentsDbApp.DTO;
using StudentsDbApp.Models;

namespace StudentsDbApp.Services
{
    public interface IStudentService
    {
        IList<Student> GetAllStudents();
        Student? GetStudent(int id);
        Student? InsertStudent(StudentInsertDTO studentInsertDTO);
        Student? UpdateStudent(StudentUpdateDTO studentUpdateDTO);
        Student? DeleteStudent(int id);

        // 2/10
        // 1:42:52
    }
}
