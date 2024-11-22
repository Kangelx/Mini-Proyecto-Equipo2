namespace RetoDI.Alumno
{
    partial class Alumno
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnMisProyectos = new System.Windows.Forms.Button();
            this.btnAniadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 73);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnAniadir);
            this.splitContainer1.Panel1.Controls.Add(this.btnMisProyectos);
            this.splitContainer1.Panel1.Controls.Add(this.btnSubir);
            this.splitContainer1.Panel1.Controls.Add(this.btnConsultar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Size = new System.Drawing.Size(920, 457);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(59, 62);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(148, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar Información";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(59, 154);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(148, 23);
            this.btnSubir.TabIndex = 1;
            this.btnSubir.Text = "Subir Archivos";
            this.btnSubir.UseVisualStyleBackColor = true;
            // 
            // btnMisProyectos
            // 
            this.btnMisProyectos.Location = new System.Drawing.Point(59, 235);
            this.btnMisProyectos.Name = "btnMisProyectos";
            this.btnMisProyectos.Size = new System.Drawing.Size(148, 23);
            this.btnMisProyectos.TabIndex = 2;
            this.btnMisProyectos.Text = "Mis proyectos";
            this.btnMisProyectos.UseVisualStyleBackColor = true;
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(59, 327);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(148, 23);
            this.btnAniadir.TabIndex = 3;
            this.btnAniadir.Text = "Añadir Comentario";
            this.btnAniadir.UseVisualStyleBackColor = true;
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(920, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnMisProyectos;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnConsultar;
    }
}