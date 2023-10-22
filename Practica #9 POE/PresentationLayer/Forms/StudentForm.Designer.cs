namespace PresentationLayer.Forms
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCiudadAlumno = new TextBox();
            txtNombreAlumno = new TextBox();
            txtCodigoAlumno = new TextBox();
            txtTelefonoAlumno = new TextBox();
            txtId = new TextBox();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            label6 = new Label();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 12);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowTemplate.Height = 25;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(362, 309);
            dgvStudents.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCiudadAlumno);
            groupBox1.Controls.Add(txtNombreAlumno);
            groupBox1.Controls.Add(txtCodigoAlumno);
            groupBox1.Controls.Add(txtTelefonoAlumno);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(396, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 309);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Campos A Rellenar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 35);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 9;
            label5.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 250);
            label4.Name = "label4";
            label4.Size = new Size(194, 15);
            label4.TabIndex = 8;
            label4.Text = "Ciudad de Procedencia del Alumno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 192);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefono del Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 132);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 6;
            label2.Text = "Codigo del Alumno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 71);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre del Alumno";
            // 
            // txtCiudadAlumno
            // 
            txtCiudadAlumno.Location = new Point(44, 268);
            txtCiudadAlumno.Name = "txtCiudadAlumno";
            txtCiudadAlumno.Size = new Size(286, 23);
            txtCiudadAlumno.TabIndex = 4;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(44, 89);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(286, 23);
            txtNombreAlumno.TabIndex = 3;
            // 
            // txtCodigoAlumno
            // 
            txtCodigoAlumno.Location = new Point(44, 150);
            txtCodigoAlumno.Name = "txtCodigoAlumno";
            txtCodigoAlumno.Size = new Size(286, 23);
            txtCodigoAlumno.TabIndex = 2;
            // 
            // txtTelefonoAlumno
            // 
            txtTelefonoAlumno.Location = new Point(44, 210);
            txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            txtTelefonoAlumno.Size = new Size(286, 23);
            txtTelefonoAlumno.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(330, 32);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(33, 23);
            txtId.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 345);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(156, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(223, 345);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(156, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(435, 345);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(632, 345);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(156, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 32);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(67, 29);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(180, 23);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox1);
            Controls.Add(dgvStudents);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudents;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCiudadAlumno;
        private TextBox txtNombreAlumno;
        private TextBox txtCodigoAlumno;
        private TextBox txtTelefonoAlumno;
        private TextBox txtId;
        private Label label5;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnSalir;
        private TextBox txtBuscar;
        private Label label6;
    }
}