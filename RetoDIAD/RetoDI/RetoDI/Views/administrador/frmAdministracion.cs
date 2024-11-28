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


        private async void btnDatoProyecto_Click(object sender, EventArgs e)
        {
            proyectos = await controlProyectos.GetAllProyectos();
            pnlDatosAlumnos.Visible = false;
            pnlDatosProfesores.Visible = false;
            pnlDatosProyecto.Visible = true;


            txtNombreProyecto.Text = null;
            txtTipoProyecto.Text = null;
            txtResumenProyecto.Text = null;
            txtAnnoProyecto.Text = null;
            txtFechaProyecto.Text = null;
            txtLogoProyectos.Text = null;
            txtMemoriaProyecto.Text = null;
            txtArchivosProyecto.Text = null;
            txtComentariosProyecto.Text = null;
            txtCicloProyecto.Text = null;
            txtTutorProyecto.Text = null;



            lvwProyectos.Items.Clear();
            ListViewItem item;
            foreach(Proyecto proyecto in proyectos.results)
            {
                item = new ListViewItem(new[] { proyecto.Nombre, proyecto.anno_acad.ToString() });
                item.Tag = proyecto;
                lvwProyectos.Items.Add(item);
            }
        }
        private void lvwProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwProyectos.SelectedItems.Count > 0)
            {
                Proyecto proyecto = (Proyecto)lvwProyectos.SelectedItems[0].Tag;

                txtNombreProyecto.Text = proyecto.Nombre == null ? null : proyecto.Nombre.ToString();
                txtTipoProyecto.Text = proyecto.tipo == null ? null : proyecto.tipo.ToString();
                txtResumenProyecto.Text = proyecto.resumen == null ? null : proyecto.resumen.ToString();
                txtAnnoProyecto.Text = proyecto.anno_acad == null ? null : proyecto.anno_acad.ToString();
                txtFechaProyecto.Text = proyecto.fecha == null ? null : proyecto.fecha.ToString();
                txtLogoProyectos.Text = proyecto.logo == null ? null : proyecto.logo.ToString();
                txtMemoriaProyecto.Text= proyecto.memoria == null ? null : proyecto.memoria.ToString();
                txtArchivosProyecto.Text = proyecto.archivos == null ? null : proyecto.archivos.ToString();
                txtComentariosProyecto.Text = proyecto.Comentario == null ? null : proyecto.Comentario.ToString();
                txtCicloProyecto.Text = proyecto.ciclo == null ? null : proyecto.ciclo.nombre.ToString();
                txtTutorProyecto.Text = proyecto.tutor == null ? null : proyecto.tutor.Nombre.ToString();
            }
        }
        private async void btnDatoProfesores_Click(object sender, EventArgs e)
        {
            profesores = await controlProfesores.GetAllProfesores();
            pnlDatosAlumnos.Visible = false;
            pnlDatosProfesores.Visible = true;
            pnlDatosProyecto.Visible = false;


            txtNombreProfesor.Text = null;
            txtApellidosProfesor.Text = null;
            txtDNIProfesor.Text = null;
            txtEmailProfesor.Text = null;
            txtPasswordProfesor.Text = null;
            txtTelefonoProfesor.Text = null;
            txtGeneroProfesor.Text = null;
            txtFechaNacProfesor.Text = null;
            txtEspecialidadProfesor.Text = null;
            txtActivoProfesor.Text = null;
            txtAdminProfesor.Text = null;

            lvwProfesores.Items.Clear();
            ListViewItem item;
            foreach (Profesor profesor in profesores.results)
            {
                item = new ListViewItem(new[] { profesor.Nombre, profesor.Apellidos });
                item.Tag = profesor;
                lvwProfesores.Items.Add(item);
            }
        }
        private void lvwProfesores_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvwProfesores.SelectedItems.Count > 0)
            {
                Profesor profesor = (Profesor)lvwProfesores.SelectedItems[0].Tag;

                txtNombreProfesor.Text = profesor.Nombre == null ? null : profesor.Nombre.ToString();
                txtApellidosProfesor.Text= profesor.Apellidos == null ? null : profesor.Apellidos.ToString();
                txtDNIProfesor.Text= profesor.DNI == null ? null : profesor.DNI.ToString();
                txtEmailProfesor.Text = profesor.CorreoElectronico == null ? null : profesor.CorreoElectronico.ToString();
                txtPasswordProfesor.Text = profesor.ContraseñaEncriptada == null ? null : profesor.ContraseñaEncriptada.ToString();
                txtTelefonoProfesor.Text = profesor.Telefono == null ? null : profesor.Telefono.ToString();
                txtGeneroProfesor.Text = profesor.Genero == null ? null : profesor.Genero.ToString();
                txtFechaNacProfesor.Text = profesor.FechaNacimiento == null ? null : profesor.FechaNacimiento.ToString();
                txtEspecialidadProfesor.Text = profesor.Especialidad == null ? null : profesor.Especialidad.ToString();
                txtActivoProfesor.Text = profesor.ActivoActualmente.ToString();
                txtAdminProfesor.Text = profesor.EsAdministrador.ToString();

            }
        }
        private async void btnDatosAlumnos_Click(object sender, EventArgs e)
        {
            alumnos = await controlAlumnos.GetAllAlumnos();
            pnlDatosAlumnos.Visible = true;
            pnlDatosProfesores.Visible = false;
            pnlDatosProyecto.Visible = false;


            txtNombreAlumno.Text = null;
            txtApellidosAlumno.Text = null;
            txtDNIAlumno.Text = null;
            txtEmailAlumno.Text = null;
            txtPasswordAlumno.Text = null;
            txtTelefonoAlumno.Text = null;
            txtGeneroAlumno.Text = null;
            txtFechaNacAlumno.Text = null;
            txtActivoAlumno.Text = null;
            txtCicloAlumno.Text = null;


            lvwAlumnos.Items.Clear();
            ListViewItem item;
            foreach (Alumno alumno in alumnos.results)
            {
                item = new ListViewItem(new[] { alumno.Nombre, alumno.Apellido });
                item.Tag = alumno;
                lvwAlumnos.Items.Add(item);
            }
        }
        private void lvwAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwAlumnos.SelectedItems.Count > 0)
            {
                Alumno alumno = (Alumno)lvwAlumnos.SelectedItems[0].Tag;
                txtNombreAlumno.Text = alumno.Nombre == null ? null : alumno.Nombre.ToString();
                txtApellidosAlumno.Text = alumno.Apellido == null ? null : alumno.Apellido.ToString();
                txtDNIAlumno.Text = alumno.DNI == null ? null : alumno.DNI.ToString();
                txtEmailAlumno.Text = alumno.CorreoElectronico == null ? null : alumno.CorreoElectronico.ToString();
                txtPasswordAlumno.Text = alumno.ContraseñaEncriptada== null ? null : alumno.ContraseñaEncriptada.ToString();
                txtTelefonoAlumno.Text = alumno.Telefono == null ? null : alumno.Telefono.ToString();
                txtGeneroAlumno.Text = alumno.Genero == null ? null : alumno.Genero.ToString();
                txtFechaNacAlumno.Text = alumno.FechaNacimiento == null ? null : alumno.FechaNacimiento.ToString();
                txtActivoAlumno.Text = alumno.EsAlumnoActual.ToString();
                txtCicloAlumno.Text = alumno.CicloFormativo == null ? null : alumno.CicloFormativo.nombre.ToString(); 
            }



        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "¿Está seguro de que desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {


                this.Close();
            }
        }

        private void btnAceptarAlumnos_Click(object sender, EventArgs e)
        {
            if (lvwAlumnos.SelectedItems.Count > 0)
            {
                Alumno alumno = (Alumno)lvwAlumnos.SelectedItems[0].Tag;
                alumno.Nombre = txtNombreAlumno.Text;
                lvwAlumnos.SelectedItems[0].SubItems[0].Text = alumno.Nombre;
                lvwAlumnos.SelectedItems[0].Tag = alumno.Nombre;
            }
        }

        private void btnCancelarAlumnos_Click(object sender, EventArgs e)
        {
            btnDatosAlumnos_Click(sender, e);
        }

        private void btnAceptarProfesor_Click(object sender, EventArgs e)
        {
            if (lvwProfesores.SelectedItems.Count > 0)
            {
                Profesor profesor = (Profesor)lvwProfesores.SelectedItems[0].Tag;
            }
        }

        private void btnCancelarProfesor_Click(object sender, EventArgs e)
        {
            btnDatoProfesores_Click(sender, e);
        }

        private void btnAceptarProyecto_Click(object sender, EventArgs e)
        {
            if (lvwProyectos.SelectedItems.Count > 0)
            {
                Proyecto proyecto = (Proyecto)lvwProyectos.SelectedItems[0].Tag;
            }
        }

        private void btnCancelarProyecto_Click(object sender, EventArgs e)
        {
            btnDatoProyecto_Click(sender, e);
        }




    }
}
