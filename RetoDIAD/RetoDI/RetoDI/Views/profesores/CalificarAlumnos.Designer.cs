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
            this.listViewAlumnos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(449, 326);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(151, 41);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(382, 248);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(102, 26);
            this.lblCalificacion.TabIndex = 1;
            this.lblCalificacion.Text = "Calificación";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(387, 288);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(213, 22);
            this.txtCalificacion.TabIndex = 2;
            // 
            // txtBuscarAlumno
            // 
            this.txtBuscarAlumno.Location = new System.Drawing.Point(12, 288);
            this.txtBuscarAlumno.Name = "txtBuscarAlumno";
            this.txtBuscarAlumno.Size = new System.Drawing.Size(253, 22);
            this.txtBuscarAlumno.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(170, 326);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 41);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblNombreproyecto
            // 
            this.lblNombreproyecto.AutoSize = true;
            this.lblNombreproyecto.Location = new System.Drawing.Point(12, 248);
            this.lblNombreproyecto.Name = "lblNombreproyecto";
            this.lblNombreproyecto.Size = new System.Drawing.Size(104, 16);
            this.lblNombreproyecto.TabIndex = 8;
            this.lblNombreproyecto.Text = "Nombre Alumno";
            // 
            // listViewAlumnos
            // 
            this.listViewAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewAlumnos.HideSelection = false;
            this.listViewAlumnos.Location = new System.Drawing.Point(15, 22);
            this.listViewAlumnos.Name = "listViewAlumnos";
            this.listViewAlumnos.Size = new System.Drawing.Size(585, 205);
            this.listViewAlumnos.TabIndex = 11;
            this.listViewAlumnos.UseCompatibleStateImageBehavior = false;
            this.listViewAlumnos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Alumno";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Proyecto";
            this.columnHeader2.Width = 213;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Calificación";
            this.columnHeader3.Width = 200;
            // 
            // CalificarAlumnos
            // 
            this.ClientSize = new System.Drawing.Size(615, 416);
            this.Controls.Add(this.listViewAlumnos);
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
        private ListView listViewAlumnos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}