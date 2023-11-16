﻿using StudentsDbApp.Models;
using StudentsDbApp.Services.DBHelper;
using System.Data.SqlClient;

namespace StudentsDbApp.DAO
{
    public class StudentDaoImpl : IStudentDAO
    {
        public List<Student> GetAll()
        {
            string sql = "SELECT * FROM STUDENTS";
            var students = new List<Student>();
            
            // using is similar to try with resources in Java
            using SqlConnection? conn = DBUtil.GetConnection();
            conn!.Open();

            using SqlCommand command = new(sql, conn);

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student student = new()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("ID")),
                    Firstname = reader.GetString(reader.GetOrdinal("FIRSTNAME")),
                    Lastname = reader.GetString(reader.GetOrdinal("LASTNAME"))
                };

                students.Add(student);
            }

            return students;
        }

        public Student? GetById(int id)
        {
            string sql = "SELECT * FROM STUDENTS WHERE ID = @id";
            Student? student = null;

            using SqlConnection? conn = DBUtil.GetConnection();
            conn!.Open();

            using SqlCommand command = new(sql, conn);
            command.Parameters.AddWithValue("@id", id);
            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                student = new()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("ID")),
                    Firstname = reader.GetString(reader.GetOrdinal("FIRSTNAME")),
                    Lastname = reader.GetString(reader.GetOrdinal("LASTNAME"))
                };
            }
            return student;
        }

        public Student? Insert(Student student)
        {
            if (student is null) return null;

            string sql = "INSERT INTO STUDENTS (FIRSTNAME, LASTNAME) VALUES (@firstname, @lastname); " +
                "SELECT SCOPE_IDENTITY();";

            Student? studentToReturn = null;

            using SqlConnection? conn = DBUtil.GetConnection();
            conn!.Open();

            using SqlCommand insertCommand = new(sql, conn);
            insertCommand.Parameters.AddWithValue("@firstname", student.Firstname);
            insertCommand.Parameters.AddWithValue("@lastname", student.Lastname);

            object insertObj = insertCommand.ExecuteScalar();
            int insertedId = 0;

            if(insertObj is not null)
            {
                if (!int.TryParse(insertObj.ToString(), out insertedId))
                {
                    Console.Error.WriteLine("Error in inserted id.");
                }
            }

            string sqlInsertedStudent = "SELECT * FROM STUDENTS WHERE ID = @id";

            using SqlCommand selectCommand = new(sqlInsertedStudent, conn);
            selectCommand.Parameters.AddWithValue("@id", insertedId);

            using SqlDataReader reader = selectCommand.ExecuteReader();
            if(reader.Read()) 
            {
                studentToReturn = new()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("ID")),
                    Firstname = reader.GetString(reader.GetOrdinal("FIRSTNAME")),
                    Lastname = reader.GetString(reader.GetOrdinal("LASTNAME")),
                };
            }

            reader.Close();

            return studentToReturn;
        }

        public Student? Update(Student student)
        {
            if (student == null) return null!;

            string sql = "UPDATE STUDENTS SET FIRSTNAME = @firstname, LASTNAME = @lastname WHERE ID = @id";
            Student?studentToUpdate = null;

            using SqlConnection? conn = DBUtil.GetConnection();
            conn!.Open();

            using SqlCommand updateCommand = new(sql, conn);
            updateCommand.Parameters.AddWithValue("@firstname", student.Firstname);
            updateCommand.Parameters.AddWithValue("@lastname", student.Lastname);
            updateCommand.Parameters.AddWithValue("@id", student.Id);
            updateCommand.ExecuteNonQuery();

            studentToUpdate = student;
            return studentToUpdate;

        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM STUDENTS WHERE ID = @id";

            using SqlConnection? conn = DBUtil.GetConnection();
            conn!.Open();

            using SqlCommand deleteCommand = new(sql, conn);
            deleteCommand.Parameters.AddWithValue("@id", id);
            deleteCommand.ExecuteNonQuery();

        }
    }
}
