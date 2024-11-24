namespace RetoDI
{
    partial class Botones
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
            this.btnGestion = new System.Windows.Forms.Button();
            this.btProyectos = new System.Windows.Forms.Button();
            this.btnAministracion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestion
            // 
            this.btnGestion.Font = new System.Drawing.Font("Noto Sans", 8.25F);
            this.btnGestion.Location = new System.Drawing.Point(548, 323);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(112, 56);
            this.btnGestion.TabIndex = 10;
            this.btnGestion.Text = "Gestión Interna";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btProyectos
            // 
            this.btProyectos.Font = new System.Drawing.Font("Noto Sans", 8.25F);
            this.btProyectos.Location = new System.Drawing.Point(346, 323);
            this.btProyectos.Name = "btProyectos";
            this.btProyectos.Size = new System.Drawing.Size(112, 56);
            this.btProyectos.TabIndex = 9;
            this.btProyectos.Text = "Proyectos";
            this.btProyectos.UseVisualStyleBackColor = true;
            this.btProyectos.Click += new System.EventHandler(this.btProyectos_Click);
            // 
            // btnAministracion
            // 
            this.btnAministracion.Font = new System.Drawing.Font("Noto Sans", 8.25F);
            this.btnAministracion.Location = new System.Drawing.Point(134, 323);
            this.btnAministracion.Name = "btnAministracion";
            this.btnAministracion.Size = new System.Drawing.Size(112, 56);
            this.btnAministracion.TabIndex = 8;
            this.btnAministracion.Text = "Administración";
            this.btnAministracion.UseVisualStyleBackColor = true;
            this.btnAministracion.Click += new System.EventHandler(this.btnAministracion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RetoDI.Properties.Resources.logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(249, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(17, 24);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 19);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Botones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RetoDI.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGestion);
            this.Controls.Add(this.btProyectos);
            this.Controls.Add(this.btnAministracion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Botones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Botones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btProyectos;
        private System.Windows.Forms.Button btnAministracion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}