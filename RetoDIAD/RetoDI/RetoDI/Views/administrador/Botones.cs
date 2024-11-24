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
using WinFormsApp1;




namespace RetoDI
{
    public partial class Botones : Form
    {
        public Botones()
        {
            InitializeComponent();
        }

        private void btnAministracion_Click(object sender, EventArgs e)
        {
            Administracion administracion = new Administracion();
            administracion.ShowDialog(); 
            this.Close();
        }

        private void btProyectos_Click(object sender, EventArgs e)
        {
            SubirArchivos subir = new SubirArchivos();
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
            frmLogin form = new frmLogin();
            form.ShowDialog();
            this.Hide();
        }
    }
}
