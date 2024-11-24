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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNombreproyecto = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtxComentario = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.ColumnAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaolumnPoroyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAlumno,
            this.CaolumnPoroyecto,
            this.ColumnCalificación,
            this.ColumnComentario});
            this.dataGridView1.Location = new System.Drawing.Point(10, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(506, 289);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblNombreproyecto
            // 
            this.lblNombreproyecto.AutoSize = true;
            this.lblNombreproyecto.Location = new System.Drawing.Point(541, 28);
            this.lblNombreproyecto.Name = "lblNombreproyecto";
            this.lblNombreproyecto.Size = new System.Drawing.Size(86, 13);
            this.lblNombreproyecto.TabIndex = 5;
            this.lblNombreproyecto.Text = "NombreProyecto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 82);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 19);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 7;
            // 
            // txtxComentario
            // 
            this.txtxComentario.Location = new System.Drawing.Point(541, 150);
            this.txtxComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtxComentario.Multiline = true;
            this.txtxComentario.Name = "txtxComentario";
            this.txtxComentario.Size = new System.Drawing.Size(172, 124);
            this.txtxComentario.TabIndex = 8;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(541, 126);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(60, 13);
            this.lblComentario.TabIndex = 9;
            this.lblComentario.Text = "Comentario";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(541, 283);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(117, 28);
            this.btnAñadir.TabIndex = 10;
            this.btnAñadir.Text = "Añadir Comentario";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // ColumnAlumno
            // 
            this.ColumnAlumno.HeaderText = "Alumno";
            this.ColumnAlumno.MinimumWidth = 6;
            this.ColumnAlumno.Name = "ColumnAlumno";
            // 
            // CaolumnPoroyecto
            // 
            this.CaolumnPoroyecto.HeaderText = "Proyecto";
            this.CaolumnPoroyecto.MinimumWidth = 6;
            this.CaolumnPoroyecto.Name = "CaolumnPoroyecto";
            // 
            // ColumnCalificación
            // 
            this.ColumnCalificación.HeaderText = "Calificación";
            this.ColumnCalificación.MinimumWidth = 6;
            this.ColumnCalificación.Name = "ColumnCalificación";
            this.ColumnCalificación.Width = 125;
            // 
            // ColumnComentario
            // 
            this.ColumnComentario.HeaderText = "Comentario";
            this.ColumnComentario.MinimumWidth = 6;
            this.ColumnComentario.Name = "ColumnComentario";
            this.ColumnComentario.Width = 125;
            // 
            // ComentarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 341);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.txtxComentario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombreproyecto);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ComentarProyectos";
            this.Text = "ComentarProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblNombreproyecto;
        private Button btnBuscar;
        private TextBox textBox1;
        private TextBox txtxComentario;
        private Label lblComentario;
        private Button btnAñadir;
        private DataGridViewTextBoxColumn ColumnAlumno;
        private DataGridViewTextBoxColumn CaolumnPoroyecto;
        private DataGridViewTextBoxColumn ColumnCalificación;
        private DataGridViewTextBoxColumn ColumnComentario;
    }
}