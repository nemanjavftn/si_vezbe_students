using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class StudentBusiness
    {
        private readonly StudentRepository studentRepository;
        public StudentBusiness()
        {
            this.studentRepository = new StudentRepository();
        }

        public List<Student> GetAllStudents()
        {
            return this.studentRepository.GetStudents();
        }

        public Student GetStudentById(int id)
        {
            return this.studentRepository.GetStudents().FirstOrDefault(s => s.Id == id);
        }

        public List<Student> GetStudentsStartingWith(string startingLetter)
        {
            return this.studentRepository.GetStudents().Where(s => s.Name.StartsWith(startingLetter)).ToList();
        }

        public bool InsertOneStudent(Student s)
        {
            if (this.studentRepository.InsertStudent(s) > 0)
            {
                // uspešan unos
                return true;
            }
            // neuspešan unos
            return false;
        }
    }
}
