namespace RetoDI
{
    partial class frmGestiiónInterna
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnAñadircomentarios = new System.Windows.Forms.Button();
            this.btnSubirarchivos = new System.Windows.Forms.Button();
            this.btn_Cerrarsesion = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 80);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnVolver);
            this.splitContainer1.Panel1.Controls.Add(this.btnCalificar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAñadircomentarios);
            this.splitContainer1.Panel1.Controls.Add(this.btnSubirarchivos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(797, 368);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(124, 333);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalificar.Location = new System.Drawing.Point(12, 164);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(187, 23);
            this.btnCalificar.TabIndex = 2;
            this.btnCalificar.Text = "Calificar Alumnos";
            this.btnCalificar.UseVisualStyleBackColor = false;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnAñadircomentarios
            // 
            this.btnAñadircomentarios.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAñadircomentarios.Location = new System.Drawing.Point(12, 99);
            this.btnAñadircomentarios.Name = "btnAñadircomentarios";
            this.btnAñadircomentarios.Size = new System.Drawing.Size(187, 23);
            this.btnAñadircomentarios.TabIndex = 1;
            this.btnAñadircomentarios.Text = "Comentar Proyectos";
            this.btnAñadircomentarios.UseVisualStyleBackColor = false;
            this.btnAñadircomentarios.Click += new System.EventHandler(this.btnAñadircomentarios_Click);
            // 
            // btnSubirarchivos
            // 
            this.btnSubirarchivos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSubirarchivos.Location = new System.Drawing.Point(12, 36);
            this.btnSubirarchivos.Name = "btnSubirarchivos";
            this.btnSubirarchivos.Size = new System.Drawing.Size(187, 23);
            this.btnSubirarchivos.TabIndex = 0;
            this.btnSubirarchivos.Text = "Subir archivos de Proyecto";
            this.btnSubirarchivos.UseVisualStyleBackColor = false;
            this.btnSubirarchivos.Click += new System.EventHandler(this.btnSubirarchivos_Click);
            // 
            // btn_Cerrarsesion
            // 
            this.btn_Cerrarsesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrarsesion.ForeColor = System.Drawing.Color.Black;
            this.btn_Cerrarsesion.Location = new System.Drawing.Point(696, 51);
            this.btn_Cerrarsesion.Name = "btn_Cerrarsesion";
            this.btn_Cerrarsesion.Size = new System.Drawing.Size(89, 23);
            this.btn_Cerrarsesion.TabIndex = 3;
            this.btn_Cerrarsesion.Text = "Cerrar Sesión";
            this.btn_Cerrarsesion.UseVisualStyleBackColor = false;
            this.btn_Cerrarsesion.Click += new System.EventHandler(this.btn_Cerrarsesion_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(693, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(93, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "nombre usuario";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RetoDI.Properties.Resources.logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(353, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GestiiónInterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RetoDI.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 448);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btn_Cerrarsesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "GestiiónInterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestiiónInterna";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAñadircomentarios;
        private System.Windows.Forms.Button btnSubirarchivos;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btn_Cerrarsesion;
        private System.Windows.Forms.Label lblUsuario;
    }
}