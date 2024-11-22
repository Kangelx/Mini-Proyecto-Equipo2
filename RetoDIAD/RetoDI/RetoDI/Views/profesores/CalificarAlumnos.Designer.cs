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
            btnGuardar = new Button();
            lblCalificacion = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ColumnAlumno = new DataGridViewTextBoxColumn();
            CaolumnPoroyecto = new DataGridViewTextBoxColumn();
            ColumnCalificación = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            btnBuscar = new Button();
            lblNombreproyecto = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(636, 344);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 56);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCalificacion
            // 
            lblCalificacion.AutoSize = true;
            lblCalificacion.Font = new Font("Noto Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalificacion.Location = new Point(638, 259);
            lblCalificacion.Name = "lblCalificacion";
            lblCalificacion.Size = new Size(102, 26);
            lblCalificacion.TabIndex = 1;
            lblCalificacion.Text = "Calificación";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(636, 298);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnAlumno, CaolumnPoroyecto, ColumnCalificación });
            dataGridView1.Location = new Point(27, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(578, 368);
            dataGridView1.TabIndex = 3;
            // 
            // ColumnAlumno
            // 
            ColumnAlumno.HeaderText = "Alumno";
            ColumnAlumno.MinimumWidth = 6;
            ColumnAlumno.Name = "ColumnAlumno";
            ColumnAlumno.Width = 200;
            // 
            // CaolumnPoroyecto
            // 
            CaolumnPoroyecto.HeaderText = "Proyecto";
            CaolumnPoroyecto.MinimumWidth = 6;
            CaolumnPoroyecto.Name = "CaolumnPoroyecto";
            CaolumnPoroyecto.Width = 200;
            // 
            // ColumnCalificación
            // 
            ColumnCalificación.HeaderText = "Calificación";
            ColumnCalificación.MinimumWidth = 6;
            ColumnCalificación.Name = "ColumnCalificación";
            ColumnCalificación.Width = 125;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(636, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 27);
            textBox2.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(636, 164);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombreproyecto
            // 
            lblNombreproyecto.AutoSize = true;
            lblNombreproyecto.Location = new Point(636, 81);
            lblNombreproyecto.Name = "lblNombreproyecto";
            lblNombreproyecto.Size = new Size(120, 20);
            lblNombreproyecto.TabIndex = 8;
            lblNombreproyecto.Text = "Nombre Alumno";
            // 
            // CalificarAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);

            ClientSize = new Size(877, 450);
            Controls.Add(textBox2);
            Controls.Add(btnBuscar);
            Controls.Add(lblNombreproyecto);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(lblCalificacion);
            Controls.Add(btnGuardar);
            Name = "CalificarAlumnos";
            Text = "CalificarAlumnos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label lblCalificacion;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnAlumno;
        private DataGridViewTextBoxColumn CaolumnPoroyecto;
        private DataGridViewTextBoxColumn ColumnCalificación;
        private TextBox textBox2;
        private Button btnBuscar;
        private Label lblNombreproyecto;
    }
}