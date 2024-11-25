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
using RetoDI.Views.profesores;




namespace RetoDI
{
    public partial class Botones : Form
    {
        private bool esAdministrador;  // Variable para guardar si el usuario es administrador

        public Botones(bool esAdministrador)
        {
            InitializeComponent();
            this.esAdministrador = esAdministrador;
            ConfigurarBotones();

        }


        // Configura los botones dependiendo de si el usuario es administrador o profesor
        private void ConfigurarBotones()
        {
            if (esAdministrador)
            {
                // Si es administrador, habilitar todos los botones
                btnAministracion.Enabled = true;  // Habilitar el botón de administración
                btProyectos.Enabled = true;       // Habilitar el botón de proyectos
                btnGestion.Enabled = true;        // Habilitar el botón de gestión
            }
            else
            {
                // Si es profesor, deshabilitar el botón de administración
                btnAministracion.Enabled = false;  // Deshabilitar el botón de administración
                btProyectos.Enabled = true;        // Habilitar el resto de botones
                btnGestion.Enabled = true;
            }
        }


        private void btnAministracion_Click(object sender, EventArgs e)
        {
            if (!btnAministracion.Enabled)
            {
                // Si el botón está deshabilitado, mostrar un mensaje
                MessageBox.Show("Este botón solo está disponible para los administradores.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución si el botón está deshabilitado
            }

            // Si el botón está habilitado, ejecutar la acción correspondiente
            Administracion administracion = new Administracion();
            administracion.ShowDialog();
            this.Close();
        }

        private void btProyectos_Click(object sender, EventArgs e)
        {
            Proyectos proyectos = new Proyectos();
            proyectos.ShowDialog();
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
