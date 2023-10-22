using CommonLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.CRUD
{
    public class StudentBusiness
    {
        StudentData studentData = new StudentData();

        public DataTable GetStudents()
        {

            DataTable studentTable = new DataTable();
            studentTable = studentData.GetAllStudents();

            return studentTable;
        }

        public DataTable SearchStudents(string search)
        {

            DataTable studentTable = new DataTable();
            studentTable = studentData.SearchStudents(search);

            return studentTable;
        }

        public void AddStudents(Student student)
        {
            studentData.AddStudents(student);
        }

        public void UpdateStudents(Student student)
        {
            studentData.UpdateStudents(student);
        }

        public void DeleteStudents(Student student)
        {
            studentData.DeleteStudents(student);
        }
    }
}
