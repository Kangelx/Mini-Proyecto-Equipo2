using System;
using RetoDI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetoDI.Administrador;



namespace RetoDI
{
    public partial class Botones : Form
    {
        public Botones()
        {
            InitializeComponent();
            try{Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");this.BackgroundImage = img;}catch (Exception ex) { }
        }

        private void btnAministracion_Click(object sender, EventArgs e)
        {
            Administracion administracion = new Administracion();
            administracion.ShowDialog(); 
            this.Close();
        }

        private void btProyectos_Click(object sender, EventArgs e)
        {
            Subirarchivoproyecto subir = new Subirarchivoproyecto();
            subir.ShowDialog();
            this.Hide();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            GestiiónInterna gestioninterna = new GestiiónInterna();
            gestioninterna.ShowDialog();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.ShowDialog();
            this.Hide();
        }
    }
}
