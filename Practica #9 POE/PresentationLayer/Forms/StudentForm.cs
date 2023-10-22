using BusinessLayer.CRUD;
using CommonLayer;
using FluentValidation.Results;
using PresentationLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class StudentForm : Form
    {
        private bool isEditMode = false;

        public StudentForm()
        {
            InitializeComponent();
            LoadStudentsData();
        }

        private void LoadStudentsData()
        {
            StudentBusiness studentBusiness = new StudentBusiness();
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = studentBusiness.GetStudents();
        }

        private void clear()
        {
            txtId.Clear();
            txtNombreAlumno.Clear();
            txtCodigoAlumno.Clear();
            txtTelefonoAlumno.Clear();
            txtCiudadAlumno.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StudentBusiness studentBusiness = new StudentBusiness();
            Student student = new Student();

            student.name = txtNombreAlumno.Text;
            student.code = txtCodigoAlumno.Text;
            student.numberphone = txtTelefonoAlumno.Text;
            student.city = txtCiudadAlumno.Text;

            /*VALIDACIONES*/
            StudentsValidator studentValidator = new StudentsValidator();
            ValidationResult result = studentValidator.Validate(student);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    MessageBox.Show("Error: " + failure.ErrorMessage);
                }
            }
            else
            {
                if (isEditMode == false)
                {
                    studentBusiness.AddStudents(student);
                    LoadStudentsData();
                    clear();
                }
                else
                {
                    student.id = int.Parse(dgvStudents.CurrentRow.Cells[0].Value.ToString());
                    studentBusiness.UpdateStudents(student);
                    LoadStudentsData();
                    clear();
                    isEditMode = false;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            StudentBusiness studentBusiness = new StudentBusiness();
            Student student = new Student();

            if (dgvStudents.SelectedRows.Count > 0)
            {
                student.id = int.Parse(dgvStudents.CurrentRow.Cells[0].Value.ToString());

                studentBusiness.DeleteStudents(student);

                LoadStudentsData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                txtId.Text = dgvStudents.CurrentRow.Cells[0].Value.ToString();
                txtNombreAlumno.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString();
                txtCodigoAlumno.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString();
                txtTelefonoAlumno.Text = dgvStudents.CurrentRow.Cells[3].Value.ToString();
                txtCiudadAlumno.Text = dgvStudents.CurrentRow.Cells[4].Value.ToString();
                isEditMode = true;
            }
            else
            {

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            StudentBusiness studentBusiness = new StudentBusiness();
            dgvStudents.DataSource = studentBusiness.SearchStudents(txtBuscar.Text);
        }
    }
}
