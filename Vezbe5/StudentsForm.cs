using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vezbe5
{
    public partial class StudentsForm : Form
    {
        private string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // nakaciti se na bazu podataka i prikazati podatke iz tabele Students
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;

                List<Student> students = new List<Student>();

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

                foreach (Student s in students)
                {
                    listBoxStudents.Items.Add(s.Id + ". " +
                        s.Name + " " + s.Surname + " - " + s.Age +
                        " (" + s.IndexNumber + ")");
                }
            }
        }
    }
}
