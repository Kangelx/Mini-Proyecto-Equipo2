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
            Proyectoo proyecto = new Proyectoo();     
            proyecto.ShowDialog();
            this.Close();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            GestiiónInterna gestioninterna = new GestiiónInterna();
            gestioninterna.ShowDialog();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.ShowDialog();
            this.Close();
        }
    }
}
