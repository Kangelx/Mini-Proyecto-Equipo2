using RetoDI.Controles;
using RetoDI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoDI.frmAlumno
{
    public partial class frmAlumno : Form
    {
        // private readonly ApiService _apiService;
        private ControlAlumnos controlAlumnos;
        private ControlProyectos controlProyectos;
        private ControlProfesores controlProfesores;
        private ControlCiclos controlCiclos;
        private Alumnos alumnos;
        private Proyectos proyectos;
        private Profesores profesores;
        private Ciclos ciclos;
        public frmAlumno(frmLogin frmLogin)
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
            panel3.Dock = DockStyle.Fill;
            panel4.Dock = DockStyle.Fill;
            //nos aseguramos de que todo este invisible
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;


            controlAlumnos = new ControlAlumnos();
            controlProfesores = new ControlProfesores();
            controlProyectos = new ControlProyectos();
            controlCiclos = new ControlCiclos();
        }

        private void btn_Cerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                         "¿Está seguro de que desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                         "Se va a cerrar sesion, ¿Está seguro de que desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //proyectos = await controlProyectos.GetProyectosidalumno();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnMisProyectos_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }
    }
}
