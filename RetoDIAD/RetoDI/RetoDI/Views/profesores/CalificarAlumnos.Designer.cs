using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class CalificarAlumnos
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.txtBuscarAlumno = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombreproyecto = new System.Windows.Forms.Label();
            this.lvAlumnos = new System.Windows.Forms.ListView();
            this.Alumno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proyecto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(402, 308);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(151, 41);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(337, 241);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(79, 17);
            this.lblCalificacion.TabIndex = 1;
            this.lblCalificacion.Text = "Calificación";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(340, 282);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(213, 20);
            this.txtCalificacion.TabIndex = 2;
            // 
            // txtBuscarAlumno
            // 
            this.txtBuscarAlumno.Location = new System.Drawing.Point(15, 282);
            this.txtBuscarAlumno.Name = "txtBuscarAlumno";
            this.txtBuscarAlumno.Size = new System.Drawing.Size(253, 20);
            this.txtBuscarAlumno.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(173, 308);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 41);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblNombreproyecto
            // 
            this.lblNombreproyecto.AutoSize = true;
            this.lblNombreproyecto.Location = new System.Drawing.Point(12, 243);
            this.lblNombreproyecto.Name = "lblNombreproyecto";
            this.lblNombreproyecto.Size = new System.Drawing.Size(82, 13);
            this.lblNombreproyecto.TabIndex = 8;
            this.lblNombreproyecto.Text = "Nombre Alumno";
            // 
            // lvAlumnos
            // 
            this.lvAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Alumno,
            this.Proyecto,
            this.Calificacion});
            this.lvAlumnos.HideSelection = false;
            this.lvAlumnos.Location = new System.Drawing.Point(15, 23);
            this.lvAlumnos.Name = "lvAlumnos";
            this.lvAlumnos.Size = new System.Drawing.Size(538, 205);
            this.lvAlumnos.TabIndex = 11;
            this.lvAlumnos.UseCompatibleStateImageBehavior = false;
            this.lvAlumnos.View = System.Windows.Forms.View.Details;
            // 
            // Alumno
            // 
            this.Alumno.Text = "Alumno";
            this.Alumno.Width = 159;
            // 
            // Proyecto
            // 
            this.Proyecto.Text = "Proyecto";
            this.Proyecto.Width = 213;
            // 
            // Calificacion
            // 
            this.Calificacion.Text = "Calificación";
            this.Calificacion.Width = 200;
            // 
            // CalificarAlumnos
            // 
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.lvAlumnos);
            this.Controls.Add(this.txtBuscarAlumno);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombreproyecto);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.btnGuardar);
            this.Name = "CalificarAlumnos";
            this.Text = "CalificarAlumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardar;
        private Label lblCalificacion;
        private TextBox txtCalificacion;
        private TextBox txtBuscarAlumno;
        private Button btnBuscar;
        private Label lblNombreproyecto;
        private ListView lvAlumnos;
        private ColumnHeader Alumno;
        private ColumnHeader Proyecto;
        private ColumnHeader Calificacion;
    }
}