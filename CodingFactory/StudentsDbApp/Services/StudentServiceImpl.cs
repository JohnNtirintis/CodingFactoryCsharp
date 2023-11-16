using AutoMapper;
using StudentsDbApp.DAO;
using StudentsDbApp.DTO;
using StudentsDbApp.Models;
using System.Transactions;

namespace StudentsDbApp.Services
{
    public class StudentServiceImpl : IStudentService
    {
        private readonly IStudentDAO _studentDAO;
        private readonly IMapper _mapper;
        private readonly ILogger<StudentServiceImpl> _logger;

        public StudentServiceImpl(IStudentDAO studentDAO, IMapper mapper, ILogger<StudentServiceImpl> logger)
        {
            this._studentDAO = studentDAO;
            _mapper = mapper;
            _logger = logger;
        }

        public IList<Student> GetAllStudents()
        {
            try
            {
                IList<Student> students = _studentDAO.GetAll();
                return students;
            } catch (Exception e)
            {
                _logger.LogError("An error occured while fetching all students: {ErrorMessage}", e.Message);
                throw;
            }
        }

        public Student? GetStudent(int id)
        {
            try
            {
                return _studentDAO.GetById(id);
            } catch (Exception e)
            {
                _logger.LogError("An error occured while trying to get the student via id: {StudentId}. Error: {ErrorMessage}", id, e.Message);
                throw;
            }
        }

        public Student? InsertStudent(StudentInsertDTO studentInsertDTO)
        {
            if (studentInsertDTO == null) return null;

            var student = _mapper.Map<Student>(studentInsertDTO);

            try
            {
                using TransactionScope scope = new();
                Student? insertedStudent = _studentDAO.Insert(student);
                scope.Complete();
                return insertedStudent;

            } catch(Exception e)
            {
                _logger.LogError("An error occured while inserting student: {ErrorMessage}", e.Message);
                throw;
            }
        }

        public Student? UpdateStudent(StudentUpdateDTO studentUpdateDTO)
        {
            if(studentUpdateDTO == null) return null;

            Student? student = _mapper.Map<Student>(studentUpdateDTO);
            Student? updatedStudent = null;

            try
            {
                using TransactionScope scope = new();
                updatedStudent = _studentDAO.GetById(student.Id);

                if (updatedStudent == null) return null;
                updatedStudent = _studentDAO.Update(student);
                scope.Complete();
            } catch(Exception e)
            {
                _logger.LogError("An error occured while updating student: {ErrorMessage}", e.Message);
                throw;
            }

            return updatedStudent;
        }

        public Student? DeleteStudent(int id)
        {
            Student? deletedStudent = null;

            try
            {
                using TransactionScope scope = new();
                deletedStudent = _studentDAO.GetById(id);

                if(deletedStudent == null) return null;

                _studentDAO.Delete(id);
                scope.Complete();
            } catch (Exception e) 
            {
                _logger.LogError("An error occured while deleting student with id: {id}. Error: {ErrorMessage}", id, e.Message);
                throw;
            }

            return deletedStudent;
        }
    }
}
