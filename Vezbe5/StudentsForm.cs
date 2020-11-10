using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vezbe5
{
    public partial class StudentsForm : Form
    {
        private readonly StudentBusiness studentBusiness;

        public StudentsForm()
        {
            this.studentBusiness = new StudentBusiness();
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            listBoxStudents.Items.Clear();

            List<Student> students = this.studentBusiness.GetAllStudents();

            foreach (Student s in students)
            {
                listBoxStudents.Items.Add(s.Id + ". " +
                    s.Name + " " + s.Surname + " - " + s.Age +
                    " (" + s.IndexNumber + ")");
            }
        }

        private void buttonInsertStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBoxStudentName.Text;
            s.Surname = textBoxStudentSurname.Text;
            s.Age = Convert.ToInt32(textBoxStudentAge.Text);
            s.IndexNumber = textBoxStudentIndexNumber.Text;

            bool result = this.studentBusiness.InsertOneStudent(s);

            if (result)
            {
                FillList();
                MessageBox.Show("Uspešan unos!");
            } 
            else
            {
                MessageBox.Show("Unos nije uspešan!");
            }
        }

        private void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBoxStudentName.Text;
            s.Surname = textBoxStudentSurname.Text;
            s.Age = Convert.ToInt32(textBoxStudentAge.Text);
            s.IndexNumber = textBoxStudentIndexNumber.Text;

            // selektovana stavka u listi, id (broj pre tačke)
            s.Id = int.Parse(listBoxStudents.SelectedItem.ToString().Split(".")[0]);

            bool result = this.studentBusiness.UpdateStudent(s);

            if (result)
            {
                FillList();
                MessageBox.Show("Uspešna izmena!");
            }
            else
            {
                MessageBox.Show("Izmena nije uspešna!");
            }
        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
