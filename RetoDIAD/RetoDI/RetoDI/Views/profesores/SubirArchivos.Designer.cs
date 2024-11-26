using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class SubirArchivos
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
            this.lblSeleccionearchivo = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lvArchivos = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSeleccionearchivo
            // 
            this.lblSeleccionearchivo.AutoSize = true;
            this.lblSeleccionearchivo.Location = new System.Drawing.Point(10, 24);
            this.lblSeleccionearchivo.Name = "lblSeleccionearchivo";
            this.lblSeleccionearchivo.Size = new System.Drawing.Size(161, 13);
            this.lblSeleccionearchivo.TabIndex = 0;
            this.lblSeleccionearchivo.Text = "Seleccione el Archivo para Subir";
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(56, 91);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(115, 36);
            this.btnSubir.TabIndex = 3;
            this.btnSubir.Text = "Subir Archivo";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click_2);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(204, 24);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(223, 13);
            this.lblAlumno.TabIndex = 4;
            this.lblAlumno.Text = "Seleccione un Alumno para asignar el archivo";
            // 
            // lvArchivos
            // 
            this.lvArchivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellidos});
            this.lvArchivos.HideSelection = false;
            this.lvArchivos.Location = new System.Drawing.Point(207, 57);
            this.lvArchivos.Margin = new System.Windows.Forms.Padding(2);
            this.lvArchivos.Name = "lvArchivos";
            this.lvArchivos.Size = new System.Drawing.Size(271, 288);
            this.lvArchivos.TabIndex = 6;
            this.lvArchivos.UseCompatibleStateImageBehavior = false;
            this.lvArchivos.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Alumno";
            this.Nombre.Width = 135;
            // 
            // Apellidos
            // 
            this.Apellidos.Text = "Proyecto";
            this.Apellidos.Width = 163;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 7;
            // 
            // SubirArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 370);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvArchivos);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.lblSeleccionearchivo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SubirArchivos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubirArchivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSeleccionearchivo;
        private Button btnSubir;
        private Label lblAlumno;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView lvArchivos;
        private ColumnHeader Nombre;
        private ColumnHeader Apellidos;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
    }
}