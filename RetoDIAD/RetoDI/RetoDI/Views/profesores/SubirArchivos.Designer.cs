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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.btnSubir.Location = new System.Drawing.Point(11, 260);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(115, 36);
            this.btnSubir.TabIndex = 3;
            this.btnSubir.Text = "Subir Archivo";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click_1);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(236, 24);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(223, 13);
            this.lblAlumno.TabIndex = 4;
            this.lblAlumno.Text = "Seleccione un Alumno para asignar el archivo";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(238, 57);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(232, 288);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellidos";
            this.columnHeader2.Width = 163;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SubirArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 370);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.lblSeleccionearchivo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SubirArchivos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SubirArchivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSeleccionearchivo;
        private Button btnSubir;
        private Label lblAlumno;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private OpenFileDialog openFileDialog1;
    }
}