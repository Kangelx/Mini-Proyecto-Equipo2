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
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lblcomentar = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(12, 270);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(412, 152);
            this.txtComentario.TabIndex = 8;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(9, 233);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(76, 16);
            this.lblComentario.TabIndex = 9;
            this.lblComentario.Text = "Comentario";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(464, 264);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(156, 34);
            this.btnAñadir.TabIndex = 10;
            this.btnAñadir.Text = "Guardar Comentario";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblcomentar
            // 
            this.lblcomentar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1});
            this.lblcomentar.GridLines = true;
            this.lblcomentar.HideSelection = false;
            this.lblcomentar.Location = new System.Drawing.Point(12, 38);
            this.lblcomentar.Margin = new System.Windows.Forms.Padding(4);
            this.lblcomentar.MultiSelect = false;
            this.lblcomentar.Name = "lblcomentar";
            this.lblcomentar.Size = new System.Drawing.Size(710, 191);
            this.lblcomentar.TabIndex = 24;
            this.lblcomentar.UseCompatibleStateImageBehavior = false;
            this.lblcomentar.View = System.Windows.Forms.View.Details;
            this.lblcomentar.SelectedIndexChanged += new System.EventHandler(this.lblcomentar_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Proyecto";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Resumen";
            this.columnHeader8.Width = 169;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Comentario";
            this.columnHeader1.Width = 364;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Seleccione un proyecto para modificar el comentario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComentarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcomentar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.txtComentario);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ComentarProyectos";
            this.Text = "ComentarProyectos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtComentario;
        public Label lblComentario;
        private Button btnAñadir;
        public ListView lblcomentar;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader1;
        public Label label1;
    }
}