using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class ComentarProyectos
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
            dataGridView1 = new DataGridView();
            ColumnAlumno = new DataGridViewTextBoxColumn();
            CaolumnPoroyecto = new DataGridViewTextBoxColumn();
            ColumnCalificación = new DataGridViewTextBoxColumn();
            ColumnComentario = new DataGridViewTextBoxColumn();
            lblNombreproyecto = new Label();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            txtxComentario = new TextBox();
            lblComentario = new Label();
            btnAñadir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnAlumno, CaolumnPoroyecto, ColumnCalificación, ColumnComentario });
            dataGridView1.Location = new Point(12, 34);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(638, 334);
            dataGridView1.TabIndex = 4;
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
            // ColumnComentario
            // 
            ColumnComentario.HeaderText = "Comentario";
            ColumnComentario.MinimumWidth = 6;
            ColumnComentario.Name = "ColumnComentario";
            ColumnComentario.Width = 125;
            // 
            // lblNombreproyecto
            // 
            lblNombreproyecto.AutoSize = true;
            lblNombreproyecto.Location = new Point(666, 34);
            lblNombreproyecto.Name = "lblNombreproyecto";
            lblNombreproyecto.Size = new Size(98, 15);
            lblNombreproyecto.TabIndex = 5;
            lblNombreproyecto.Text = "NombreProyecto";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(666, 96);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(666, 62);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 7;
            // 
            // txtxComentario
            // 
            txtxComentario.Location = new Point(666, 174);
            txtxComentario.Margin = new Padding(3, 2, 3, 2);
            txtxComentario.Multiline = true;
            txtxComentario.Name = "txtxComentario";
            txtxComentario.Size = new Size(200, 142);
            txtxComentario.TabIndex = 8;
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Location = new Point(666, 146);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(70, 15);
            lblComentario.TabIndex = 9;
            lblComentario.Text = "Comentario";
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(666, 328);
            btnAñadir.Margin = new Padding(3, 2, 3, 2);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(136, 32);
            btnAñadir.TabIndex = 10;
            btnAñadir.Text = "Añadir Comentario";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // ComentarProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 394);
            Controls.Add(btnAñadir);
            Controls.Add(lblComentario);
            Controls.Add(txtxComentario);
            Controls.Add(textBox1);
            Controls.Add(btnBuscar);
            Controls.Add(lblNombreproyecto);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ComentarProyectos";
            Text = "ComentarProyectos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblNombreproyecto;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn ColumnAlumno;
        private DataGridViewTextBoxColumn CaolumnPoroyecto;
        private DataGridViewTextBoxColumn ColumnCalificación;
        private DataGridViewTextBoxColumn ColumnComentario;
        private TextBox textBox1;
        private TextBox txtxComentario;
        private Label lblComentario;
        private Button btnAñadir;
    }
}