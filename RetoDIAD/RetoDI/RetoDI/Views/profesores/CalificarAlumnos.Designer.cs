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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaolumnPoroyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombreproyecto = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(636, 344);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 56);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(638, 259);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(86, 22);
            this.lblCalificacion.TabIndex = 1;
            this.lblCalificacion.Text = "Calificación";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(636, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAlumno,
            this.CaolumnPoroyecto,
            this.ColumnCalificación});
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(578, 368);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnAlumno
            // 
            this.ColumnAlumno.HeaderText = "Alumno";
            this.ColumnAlumno.MinimumWidth = 6;
            this.ColumnAlumno.Name = "ColumnAlumno";
            this.ColumnAlumno.Width = 200;
            // 
            // CaolumnPoroyecto
            // 
            this.CaolumnPoroyecto.HeaderText = "Proyecto";
            this.CaolumnPoroyecto.MinimumWidth = 6;
            this.CaolumnPoroyecto.Name = "CaolumnPoroyecto";
            this.CaolumnPoroyecto.Width = 200;
            // 
            // ColumnCalificación
            // 
            this.ColumnCalificación.HeaderText = "Calificación";
            this.ColumnCalificación.MinimumWidth = 6;
            this.ColumnCalificación.Name = "ColumnCalificación";
            this.ColumnCalificación.Width = 125;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(636, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(636, 164);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblNombreproyecto
            // 
            this.lblNombreproyecto.AutoSize = true;
            this.lblNombreproyecto.Location = new System.Drawing.Point(636, 81);
            this.lblNombreproyecto.Name = "lblNombreproyecto";
            this.lblNombreproyecto.Size = new System.Drawing.Size(82, 13);
            this.lblNombreproyecto.TabIndex = 8;
            this.lblNombreproyecto.Text = "Nombre Alumno";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 97);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CalificarAlumnos
            // 
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombreproyecto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.btnGuardar);
            this.Name = "CalificarAlumnos";
            this.Text = "CalificarAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ListView listView1;
    }
}