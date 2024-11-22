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
            lblSeleccionearchivo = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            btnSubir = new Button();
            lblAlumno = new Label();
            dataGridView1 = new DataGridView();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblSeleccionearchivo
            // 
            lblSeleccionearchivo.AutoSize = true;
            lblSeleccionearchivo.Location = new Point(10, 28);
            lblSeleccionearchivo.Name = "lblSeleccionearchivo";
            lblSeleccionearchivo.Size = new Size(175, 15);
            lblSeleccionearchivo.TabIndex = 0;
            lblSeleccionearchivo.Text = "Seleccione el Archivo para Subir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(10, 56);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 175, 0);
            label1.Size = new Size(215, 17);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(246, 52);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(266, 348);
            btnSubir.Margin = new Padding(3, 2, 3, 2);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(134, 41);
            btnSubir.TabIndex = 3;
            btnSubir.Text = "Subir Archivo";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(10, 96);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(247, 15);
            lblAlumno.TabIndex = 4;
            lblAlumno.Text = "Seleccione un Alumno para asignar el archivo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnNombre, ColumnApellido });
            dataGridView1.Location = new Point(10, 121);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(401, 185);
            dataGridView1.TabIndex = 5;
            // 
            // ColumnNombre
            // 
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.MinimumWidth = 6;
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.Width = 200;
            // 
            // ColumnApellido
            // 
            ColumnApellido.HeaderText = "Apellidos";
            ColumnApellido.MinimumWidth = 6;
            ColumnApellido.Name = "ColumnApellido";
            ColumnApellido.Width = 200;
            // 
            // SubirArchivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 438);
            Controls.Add(dataGridView1);
            Controls.Add(lblAlumno);
            Controls.Add(btnSubir);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(lblSeleccionearchivo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SubirArchivos";
            RightToLeft = RightToLeft.No;
            Text = "SubirArchivos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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