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
        frmLogin inicio;
        public frmBotones(frmLogin frmLogin)
        {
            InitializeComponent();
            inicio = frmLogin;
            if (SessionData.TipoUsuario != "Administrador")
            {
                btnAministracion.Hide();
            }
        }

        private void btnAministracion_Click(object sender, EventArgs e)
        {
            frmAdministracion administracion = new frmAdministracion();
            administracion.ShowDialog(); 
            
        }

        private void btProyectos_Click(object sender, EventArgs e)
        {
            frmProyectoo proyecto = new frmProyectoo();     
            proyecto.ShowDialog();
           
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            frmGestiiónInterna gestioninterna = new frmGestiiónInterna();
            gestioninterna.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Botones_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicio.Show();
        }
    }
}
