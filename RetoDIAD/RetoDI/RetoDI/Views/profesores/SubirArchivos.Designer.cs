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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionearchivo
            // 
            this.lblSeleccionearchivo.AutoSize = true;
            this.lblSeleccionearchivo.Location = new System.Drawing.Point(9, 24);
            this.lblSeleccionearchivo.Name = "lblSeleccionearchivo";
            this.lblSeleccionearchivo.Size = new System.Drawing.Size(161, 13);
            this.lblSeleccionearchivo.TabIndex = 0;
            this.lblSeleccionearchivo.Text = "Seleccione el Archivo para Subir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 150, 0);
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(211, 45);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 19);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(346, 300);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(115, 36);
            this.btnSubir.TabIndex = 3;
            this.btnSubir.Text = "Subir Archivo";
            this.btnSubir.UseVisualStyleBackColor = true;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(9, 83);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(223, 13);
            this.lblAlumno.TabIndex = 4;
            this.lblAlumno.Text = "Seleccione un Alumno para asignar el archivo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnApellido});
            this.dataGridView1.Location = new System.Drawing.Point(9, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(452, 160);
            this.dataGridView1.TabIndex = 5;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.Width = 200;
            // 
            // ColumnApellido
            // 
            this.ColumnApellido.HeaderText = "Apellidos";
            this.ColumnApellido.MinimumWidth = 6;
            this.ColumnApellido.Name = "ColumnApellido";
            this.ColumnApellido.Width = 200;
            // 
            // SubirArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeleccionearchivo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SubirArchivos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SubirArchivos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSeleccionearchivo;
        private Label label1;
        private Button btnBuscar;
        private Button btnSubir;
        private Label lblAlumno;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido;
    }
}