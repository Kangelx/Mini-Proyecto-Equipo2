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
using RetoDI.Models;
using RetoDI.Views;
using RetoDI.Views.profesores;





namespace RetoDI
{
    public partial class frmBotones : Form
    {

        public frmBotones()
        {
            InitializeComponent();

            if (SessionData.TipoUsuario != "Administrador")
            {
                btnAministracion.Enabled = false;  // Deshabilitar el botón (no solo ocultarlo)
            }
        }

        private void btnAministracion_Click(object sender, EventArgs e)
        {
            frmAdministracion administracion = new frmAdministracion();
            administracion.ShowDialog(); 
            
        }

        private void btProyectos_Click(object sender, EventArgs e)
        {
            frmProyecto proyecto = new frmProyecto();     
            proyecto.ShowDialog();
           
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            frmGestionInterna gestioninterna = new frmGestionInterna();
            gestioninterna.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        "¿Está seguro de que desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

       
    }
}
