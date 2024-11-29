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
            this.txtarchivo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionearchivo
            // 
            this.lblSeleccionearchivo.AutoSize = true;
            this.lblSeleccionearchivo.Location = new System.Drawing.Point(413, 61);
            this.lblSeleccionearchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionearchivo.Name = "lblSeleccionearchivo";
            this.lblSeleccionearchivo.Size = new System.Drawing.Size(202, 16);
            this.lblSeleccionearchivo.TabIndex = 0;
            this.lblSeleccionearchivo.Text = "Seleccione el Archivo para Subir";
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(574, 152);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(153, 44);
            this.btnSubir.TabIndex = 3;
            this.btnSubir.Text = "Subir Archivo";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click_2);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(13, 9);
            this.lblAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(289, 16);
            this.lblAlumno.TabIndex = 4;
            this.lblAlumno.Text = "Seleccione un Proyecto para asignar el archivo";
            // 
            // lvArchivos
            // 
            this.lvArchivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellidos});
            this.lvArchivos.HideSelection = false;
            this.lvArchivos.Location = new System.Drawing.Point(16, 44);
            this.lvArchivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvArchivos.Name = "lvArchivos";
            this.lvArchivos.Size = new System.Drawing.Size(361, 387);
            this.lvArchivos.TabIndex = 6;
            this.lvArchivos.UseCompatibleStateImageBehavior = false;
            this.lvArchivos.View = System.Windows.Forms.View.Details;
            this.lvArchivos.SelectedIndexChanged += new System.EventHandler(this.lvArchivos_SelectedIndexChanged_1);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Proyecto";
            this.Nombre.Width = 205;
            // 
            // Apellidos
            // 
            this.Apellidos.Text = "Archivo";
            this.Apellidos.Width = 163;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtarchivo
            // 
            this.txtarchivo.Location = new System.Drawing.Point(416, 100);
            this.txtarchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtarchivo.Name = "txtarchivo";
            this.txtarchivo.Size = new System.Drawing.Size(311, 22);
            this.txtarchivo.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(586, 390);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 41);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // SubirArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 455);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtarchivo);
            this.Controls.Add(this.lvArchivos);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.lblSeleccionearchivo);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
        public ListView lvArchivos;
        private ColumnHeader Nombre;
        private ColumnHeader Apellidos;
        private OpenFileDialog openFileDialog1;
        private TextBox txtarchivo;
        private Button btnGuardar;
    }
}