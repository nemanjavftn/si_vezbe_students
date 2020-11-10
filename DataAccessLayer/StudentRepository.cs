using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class StudentRepository
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            // nakaciti se na bazu podataka i prikazati podatke iz tabele Students
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Constants.connectionString;

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Students";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Student student = new Student();
                    student.Id = sqlDataReader.GetInt32(0);
                    student.Name = sqlDataReader.GetString(1);
                    student.Surname = sqlDataReader.GetString(2);
                    student.Age = sqlDataReader.GetInt32(3);
                    student.IndexNumber = sqlDataReader.GetString(4);
                    students.Add(student);
                }

            }

            return students;
        }

        public int InsertStudent(Student s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                //sqlCommand.CommandText =
                //    "INSERT INTO Students VALUES ('" + s.Name + "','" + 
                //    s.Surname + "'," + s.Age + ",'" + s.IndexNumber + "')";

                sqlCommand.CommandText = string.Format(
                    "INSERT INTO Students VALUES ('{0}','{1}',{2},'{3}')",
                    s.Name, s.Surname, s.Age, s.IndexNumber);

                int result = sqlCommand.ExecuteNonQuery();

                return result;
            }
        }

        public int UpdateStudent(Student s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = string.Format(
                    "UPDATE Students SET Name='{0}',Surname='{1}',Age ={2},IndexNumber='{3}' " +
                    "WHERE Id={4}", s.Name, s.Surname, s.Age, s.IndexNumber, s.Id);

                int result = sqlCommand.ExecuteNonQuery();

                return result;
            }
        }
    }
}
