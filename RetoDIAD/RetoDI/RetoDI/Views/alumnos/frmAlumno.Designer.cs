namespace RetoDI.frmAlumno
{
    partial class frmAlumno
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
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnMisProyectos = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cerrarsesion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 88);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnVolver);
            this.splitContainer1.Panel1.Controls.Add(this.btnAniadir);
            this.splitContainer1.Panel1.Controls.Add(this.btnMisProyectos);
            this.splitContainer1.Panel1.Controls.Add(this.btnSubir);
            this.splitContainer1.Panel1.Controls.Add(this.btnConsultar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Size = new System.Drawing.Size(920, 442);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
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
            // btnMisProyectos
            // 
            this.btnMisProyectos.Location = new System.Drawing.Point(59, 235);
            this.btnMisProyectos.Name = "btnMisProyectos";
            this.btnMisProyectos.Size = new System.Drawing.Size(148, 23);
            this.btnMisProyectos.TabIndex = 2;
            this.btnMisProyectos.Text = "Mis proyectos";
            this.btnMisProyectos.UseVisualStyleBackColor = true;
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
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(59, 62);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(148, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar Información";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RetoDI.Properties.Resources.logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(389, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cerrarsesion
            // 
            this.btn_Cerrarsesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrarsesion.ForeColor = System.Drawing.Color.Black;
            this.btn_Cerrarsesion.Location = new System.Drawing.Point(778, 13);
            this.btn_Cerrarsesion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cerrarsesion.Name = "btn_Cerrarsesion";
            this.btn_Cerrarsesion.Size = new System.Drawing.Size(129, 47);
            this.btn_Cerrarsesion.TabIndex = 4;
            this.btn_Cerrarsesion.Text = "Cerrar Sesión";
            this.btn_Cerrarsesion.UseVisualStyleBackColor = false;
            this.btn_Cerrarsesion.Click += new System.EventHandler(this.btn_Cerrarsesion_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(202, 401);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::RetoDI.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 530);
            this.Controls.Add(this.btn_Cerrarsesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnMisProyectos;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cerrarsesion;
        private System.Windows.Forms.Button btnVolver;
    }
}