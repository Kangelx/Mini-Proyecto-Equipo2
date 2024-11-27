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


namespace RetoDI.Administrador
{
    public partial class frmAdministracion : Form
    {
        // private readonly ApiService _apiService;
        private ControlAlumnos controlAlumnos;
        private ControlProyectos controlProyectos;
        private ControlProfesores controlProfesores;
        private Alumnos alumnos;
        private Proyectos proyectos;
        private Profesores profesores;
        public frmAdministracion()
        {
           // _apiService = new ApiService();
            InitializeComponent();
            //nos aseguramos de que todo este en dock fill

            pnlDatosAlumnos.Dock = DockStyle.Fill;
            pnlDatosProfesores.Dock = DockStyle.Fill;
            pnlDatosProyecto.Dock = DockStyle.Fill;
            //nos aseguramos de que todo este invisible
            pnlDatosAlumnos.Visible = false;
            pnlDatosProfesores.Visible = false;
            pnlDatosProyecto.Visible = false;


            controlAlumnos = new ControlAlumnos();
            controlProfesores = new ControlProfesores();
            controlProyectos = new ControlProyectos();
            try
            {
                Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
                this.BackgroundImage = img;
                this.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception ex) 
            {
            
            }     

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private async void btnDatosAlumnos_Click(object sender, EventArgs e)
        {
            alumnos = await controlAlumnos.GetAllAlumnos();
            pnlDatosAlumnos.Visible = true;
            pnlDatosProfesores.Visible = false;
            pnlDatosProyecto.Visible = false;

            ListViewItem item;
            foreach (Alumno alumno in alumnos.results)
            {
                item = new ListViewItem(new[] {alumno.Nombre, alumno.Apellido });
                lvwAlumnos.Items.Add(item);
            }
        }

        private async void btnDatoProfesores_Click(object sender, EventArgs e)
        {
            profesores = await controlProfesores.GetAllProfesores();
            pnlDatosAlumnos.Visible = false;
            pnlDatosProfesores.Visible = true;
            pnlDatosProyecto.Visible = false;


            ListViewItem item;
            foreach(Profesor profesor in profesores.results)
            {
                item = new ListViewItem(new[] { profesor.Nombre, profesor.Apellidos });
                lvwProfesores.Items.Add(item);
            }
        }
        private async void btnDatoProyecto_Click(object sender, EventArgs e)
        {
            proyectos = await controlProyectos.GetAllProyectos();
            pnlDatosAlumnos.Visible = false;
            pnlDatosProfesores.Visible = false;
            pnlDatosProyecto.Visible = true;


            ListViewItem item;
            foreach(Proyecto proyecto in proyectos.results)
            {
                item = new ListViewItem(new[] { proyecto.Nombre, proyecto.anno_acad.ToString() });
                item.Tag = proyecto;
                lvwProyectos.Items.Add(item);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "¿Está seguro de que desea salir de la aplicación?","Confirmar salida",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                
                this.Close(); 
            }
        }

        private void lvwAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
           Alumno alumno = (Alumno)lvwAlumnos.SelectedItems[0].Tag;
            txtNombreAlumno.Text = alumno.Nombre.ToString();
            txtApellidosAlumno.Text = alumno.Apellido.ToString();
            txtDNIAlumno.Text = alumno.DNI.ToString();
            txtEmailAlumno.Text = alumno.CorreoElectronico.ToString();
            txtPasswordAlumno.Text = alumno.ContraseñaEncriptada.ToString();
            txtTelefonoAlumno.Text = alumno.Telefono.ToString();
            txtGeneroAlumno.Text = alumno.Genero.ToString();
            
            txtActivoAlumno.Text = alumno.EsAlumnoActual.ToString();
 
            
            
         
        }

        private void btnAceptarAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarProfesor_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarProfesor_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarProyecto_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarProyecto_Click(object sender, EventArgs e)
        {

        }

        private void Administracion_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


    }
}
