﻿namespace RetoDI
{
    partial class GestiiónInterna
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAubirarchivos = new System.Windows.Forms.Button();
            this.btnAñadircomentarios = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 72);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnCalificar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAñadircomentarios);
            this.splitContainer1.Panel1.Controls.Add(this.btnAubirarchivos);
            this.splitContainer1.Size = new System.Drawing.Size(800, 378);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAubirarchivos
            // 
            this.btnAubirarchivos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAubirarchivos.Location = new System.Drawing.Point(12, 36);
            this.btnAubirarchivos.Name = "btnAubirarchivos";
            this.btnAubirarchivos.Size = new System.Drawing.Size(205, 23);
            this.btnAubirarchivos.TabIndex = 0;
            this.btnAubirarchivos.Text = "Subir archivos de Proyecto";
            this.btnAubirarchivos.UseVisualStyleBackColor = false;
            // 
            // btnAñadircomentarios
            // 
            this.btnAñadircomentarios.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAñadircomentarios.Location = new System.Drawing.Point(12, 99);
            this.btnAñadircomentarios.Name = "btnAñadircomentarios";
            this.btnAñadircomentarios.Size = new System.Drawing.Size(205, 23);
            this.btnAñadircomentarios.TabIndex = 1;
            this.btnAñadircomentarios.Text = "Comentar Proyectos";
            this.btnAñadircomentarios.UseVisualStyleBackColor = false;
            // 
            // btnCalificar
            // 
            this.btnCalificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalificar.Location = new System.Drawing.Point(12, 164);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(205, 23);
            this.btnCalificar.TabIndex = 2;
            this.btnCalificar.Text = "Calificar Alumnos";
            this.btnCalificar.UseVisualStyleBackColor = false;
            // 
            // GestiiónInterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Name = "GestiiónInterna";
            this.Text = "GestiiónInterna";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAñadircomentarios;
        private System.Windows.Forms.Button btnAubirarchivos;
        private System.Windows.Forms.Button btnCalificar;
    }
}