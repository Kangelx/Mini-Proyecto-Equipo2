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
            this.lblNombreproyecto = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarProyecto = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lblcomentar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblNombreproyecto
            // 
            this.lblNombreproyecto.AutoSize = true;
            this.lblNombreproyecto.Location = new System.Drawing.Point(23, 226);
            this.lblNombreproyecto.Name = "lblNombreproyecto";
            this.lblNombreproyecto.Size = new System.Drawing.Size(86, 13);
            this.lblNombreproyecto.TabIndex = 5;
            this.lblNombreproyecto.Text = "NombreProyecto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(123, 275);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 19);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProyecto
            // 
            this.txtBuscarProyecto.Location = new System.Drawing.Point(22, 241);
            this.txtBuscarProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarProyecto.Name = "txtBuscarProyecto";
            this.txtBuscarProyecto.Size = new System.Drawing.Size(172, 20);
            this.txtBuscarProyecto.TabIndex = 7;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(242, 194);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(310, 124);
            this.txtComentario.TabIndex = 8;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(239, 169);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(60, 13);
            this.lblComentario.TabIndex = 9;
            this.lblComentario.Text = "Comentario";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(435, 322);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(117, 28);
            this.btnAñadir.TabIndex = 10;
            this.btnAñadir.Text = "Añadir Comentario";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // lblcomentar
            // 
            this.lblcomentar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lblcomentar.HideSelection = false;
            this.lblcomentar.Location = new System.Drawing.Point(9, 22);
            this.lblcomentar.Margin = new System.Windows.Forms.Padding(2);
            this.lblcomentar.Name = "lblcomentar";
            this.lblcomentar.Size = new System.Drawing.Size(543, 136);
            this.lblcomentar.TabIndex = 11;
            this.lblcomentar.UseCompatibleStateImageBehavior = false;
            this.lblcomentar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Alumno";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Proyecto";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Calificación";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Comentario";
            this.columnHeader4.Width = 143;
            // 
            // ComentarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.lblcomentar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtBuscarProyecto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombreproyecto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ComentarProyectos";
            this.Text = "ComentarProyectos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblNombreproyecto;
        private Button btnBuscar;
        private TextBox txtBuscarProyecto;
        private TextBox txtComentario;
        private Label lblComentario;
        private Button btnAñadir;
        public ListView lblcomentar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}