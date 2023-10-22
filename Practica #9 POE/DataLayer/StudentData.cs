using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;

namespace DataLayer
{
    public class StudentData
    {
        Connection _connection = new Connection();
        SqlDataReader _reader;
        SqlCommand _cmd = new SqlCommand();
        DataTable studentTable = new DataTable();

        public DataTable GetAllStudents()
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM alumno";
            _cmd.CommandType = CommandType.Text;

            _reader = _cmd.ExecuteReader();
            studentTable.Load(_reader);

            _connection.CloseConnection();

            return studentTable;
        }

        public DataTable SearchStudents(string search)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM alumno WHERE nombre_alumno LIKE '%' + @search + '%'";
            _cmd.CommandType = CommandType.Text;
            _cmd.Parameters.AddWithValue("@search", search);

            _reader = _cmd.ExecuteReader();
            studentTable.Load(_reader);

            _connection.CloseConnection();

            return studentTable;
        }

        public void AddStudents(Student student)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "INSERT INTO alumno VALUES (@name, @code, @numberphone, @city)";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@name", student.name);
            _cmd.Parameters.AddWithValue("@code", student.code);
            _cmd.Parameters.AddWithValue("@numberphone", student.numberphone);
            _cmd.Parameters.AddWithValue("@city", student.city);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();

            _connection.CloseConnection();
        }

        public void UpdateStudents(Student student)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "UPDATE alumno SET nombre_alumno=@name, codigo_alumno=@code, telefono_Alumno=@numberphone, ciudad_alumno=@city " +
                "WHERE id_alumno = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@name", student.name);
            _cmd.Parameters.AddWithValue("@code", student.code);
            _cmd.Parameters.AddWithValue("@numberphone", student.numberphone);
            _cmd.Parameters.AddWithValue("@city", student.city);
            _cmd.Parameters.AddWithValue("@id", student.id);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteStudents(Student student)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "DELETE FROM alumno WHERE id_alumno = @id";
            _cmd.CommandType = CommandType.Text;

            _cmd.Parameters.AddWithValue("@id", student.id);

            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();

        }
    }
}
