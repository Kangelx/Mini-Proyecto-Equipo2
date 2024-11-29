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
        private ControlCiclos controlCiclos;
        private Alumnos alumnos;
        private Proyectos proyectos;
        private Profesores profesores;
        private Ciclos ciclos;
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
            controlCiclos = new ControlCiclos();


            

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBotones frmBotones = new frmBotones();
            frmBotones.Show();
        }


        private async void btnDatoProyecto_Click(object sender, EventArgs e)
        {
            proyectos = await controlProyectos.GetAllProyectos();
            profesores = await controlProfesores.GetAllProfesores();
            ciclos = await controlCiclos.GetAllCiclos();

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

            cmbCicloProyecto.Items.Clear();
            cmbTutorProyecto.Items.Clear();

            foreach (Ciclo ciclo in ciclos.results)
            {
                cmbCicloProyecto.Items.Add(ciclo.codCiclo);
            }

            foreach (Profesor profesor in profesores.results)
            {
                cmbTutorProyecto.Items.Add(profesor.apellidos);
            }

            lvwProyectos.Items.Clear();
            ListViewItem item;
            foreach (Proyecto proyecto in proyectos.results)
            {
                item = new ListViewItem(new[] { proyecto.nombre, proyecto.anno_acad.ToString() });
                item.Tag = proyecto;
                lvwProyectos.Items.Add(item);
            }
        }
        private void lvwProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwProyectos.SelectedItems.Count > 0)
            {
                Proyecto proyecto = (Proyecto)lvwProyectos.SelectedItems[0].Tag;


                txtNombreProyecto.Text = proyecto.nombre == null ? null : proyecto.nombre.ToString();
                txtTipoProyecto.Text = proyecto.tipo == null ? null : proyecto.tipo.ToString();
                txtResumenProyecto.Text = proyecto.resumen == null ? null : proyecto.resumen.ToString();
                txtAnnoProyecto.Text = proyecto.anno_acad == null ? null : proyecto.anno_acad.ToString();
                txtFechaProyecto.Text = proyecto.fecha_pres == null ? null : proyecto.fecha_pres.Value.ToShortDateString().ToString();
                txtLogoProyectos.Text = proyecto.logo == null ? null : proyecto.logo.ToString();
                txtMemoriaProyecto.Text = proyecto.memoria == null ? null : proyecto.memoria.ToString();
                txtArchivosProyecto.Text = proyecto.archivos == null ? null : proyecto.archivos.ToString();
                txtComentariosProyecto.Text = proyecto.comentarios == null ? null : proyecto.comentarios.ToString();
                cmbCicloProyecto.SelectedItem = proyecto.ciclo.codCiclo;
                cmbTutorProyecto.SelectedItem = proyecto.tutor.apellidos;


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

            txtFechaNacProfesor.Text = null;
            txtEspecialidadProfesor.Text = null;

            cmbGeneroProfesor.SelectedItem = null;
            cmbGeneroProfesor.SelectedItem = null;
            cmbAdminProfesor.SelectedItem = null;

            lvwProfesores.Items.Clear();
            ListViewItem item;
            foreach (Profesor profesor in profesores.results)
            {
                item = new ListViewItem(new[] { profesor.nombre, profesor.apellidos });
                item.Tag = profesor;
                lvwProfesores.Items.Add(item);
            }
        }
        private void lvwProfesores_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvwProfesores.SelectedItems.Count > 0)
            {
                Profesor profesor = (Profesor)lvwProfesores.SelectedItems[0].Tag;

                txtNombreProfesor.Text = profesor.nombre == null ? null : profesor.nombre.ToString();
                txtApellidosProfesor.Text = profesor.apellidos == null ? null : profesor.apellidos.ToString();
                txtDNIProfesor.Text = profesor.dni == null ? null : profesor.dni.ToString();
                txtEmailProfesor.Text = profesor.email == null ? null : profesor.email.ToString();
                txtPasswordProfesor.Text = profesor.password_encr == null ? null : profesor.password_encr.ToString();
                txtTelefonoProfesor.Text = profesor.telefono == null ? null : profesor.telefono.ToString();

                txtFechaNacProfesor.Text = profesor.fechaNac.ToShortDateString().ToString();
                txtEspecialidadProfesor.Text = profesor.especialidad == null ? null : profesor.especialidad.ToString();
                cmbGeneroProfesor.SelectedItem = profesor.genero.ToString();
                cmbActivoProfesor.SelectedItem = profesor.activo ? "Si" : "No";
                cmbAdminProfesor.SelectedItem = profesor.admin ? "Si" : "No";

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
            txtFechaNacAlumno.Text = null;
            cmbActivoAlumno.SelectedItem = null;
            cmbGeneroAlumno.SelectedItem = null;
            cmbCicloAlumno.SelectedItem = null;


            cmbCicloAlumno.Items.Clear();
            ciclos = await controlCiclos.GetAllCiclos();
            foreach (Ciclo ciclo in ciclos.results)
            {
                cmbCicloAlumno.Items.Add(ciclo.codCiclo);
            }


            lvwAlumnos.Items.Clear();
            ListViewItem item;
            foreach (Alumno alumno in alumnos.results)
            {
                item = new ListViewItem(new[] { alumno.nombre, alumno.apellido });
                item.Tag = alumno;
                lvwAlumnos.Items.Add(item);
            }
        }
        private void lvwAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwAlumnos.SelectedItems.Count > 0)
            {
                Alumno alumno = (Alumno)lvwAlumnos.SelectedItems[0].Tag;
                txtNombreAlumno.Text = alumno.nombre == null ? null : alumno.nombre.ToString();
                txtApellidosAlumno.Text = alumno.apellido == null ? null : alumno.apellido.ToString();
                txtDNIAlumno.Text = alumno.dni == null ? null : alumno.dni.ToString();
                txtEmailAlumno.Text = alumno.email == null ? null : alumno.email.ToString();
                txtPasswordAlumno.Text = alumno.password == null ? null : alumno.password.ToString();
                txtTelefonoAlumno.Text = alumno.telefono == null ? null : alumno.telefono.ToString();
                cmbGeneroAlumno.SelectedItem = alumno.genero;
                txtFechaNacAlumno.Text = alumno.fechaNacimiento.ToShortDateString().ToString();
                cmbActivoAlumno.Text = alumno.activo ? "Si" : "No";
                cmbCicloAlumno.SelectedItem = alumno.ciclo == null ? null : alumno.ciclo.codCiclo.ToString();
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

        private async void btnAceptarAlumnos_Click(object sender, EventArgs e)
        {
            if (lvwAlumnos.SelectedItems.Count > 0)
            {
                Alumno alumno = (Alumno)lvwAlumnos.SelectedItems[0].Tag;
                alumno.nombre = txtNombreAlumno.Text;
                alumno.apellido = txtApellidosAlumno.Text;
                alumno.dni = txtDNIAlumno.Text;
                alumno.email = txtEmailAlumno.Text;
                alumno.telefono = txtTelefonoAlumno.Text;
                alumno.genero = cmbGeneroAlumno.SelectedItem.ToString();
                alumno.activo = cmbActivoAlumno.Text == "Si";

                foreach (Ciclo ciclo in ciclos.results)
                {
                    if (ciclo.codCiclo == cmbCicloAlumno.Text)
                    {
                        alumno.ciclo = ciclo;
                    }
                }


                bool resultado = await controlAlumnos.GuardarAlumno(alumno);
            }
            btnDatosAlumnos_Click(sender, e);
        }


        private void btnCancelarAlumnos_Click(object sender, EventArgs e)
        {
            btnDatosAlumnos_Click(sender, e);
        }

        private async void btnAceptarProfesor_Click(object sender, EventArgs e)
        {
            if (lvwProfesores.SelectedItems.Count > 0)
            {
                Profesor profesor = (Profesor)lvwProfesores.SelectedItems[0].Tag;

                profesor.nombre = txtNombreProfesor.Text;
                profesor.apellidos = txtApellidosProfesor.Text;
                profesor.dni = txtDNIProfesor.Text;
                profesor.email = txtEmailProfesor.Text;

                profesor.telefono = txtTelefonoProfesor.Text;


                profesor.especialidad = txtEspecialidadProfesor.Text;

                profesor.genero = cmbGeneroProfesor.SelectedItem.ToString();
                profesor.genero = cmbGeneroProfesor.SelectedItem.ToString();
                profesor.admin = cmbAdminProfesor.SelectedItem.ToString() == "Si";

                bool resultado = await controlProfesores.GuardarProfesor(profesor);
            }

            btnDatoProfesores_Click(sender, e);
        }

        private void btnCancelarProfesor_Click(object sender, EventArgs e)
        {
            btnDatoProfesores_Click(sender, e);
        }

        private async void btnAceptarProyecto_Click(object sender, EventArgs e)
        {
            if (lvwProyectos.SelectedItems.Count > 0)
            {
                Proyecto proyecto = (Proyecto)lvwProyectos.SelectedItems[0].Tag;


                proyecto.nombre = txtNombreProyecto.Text;
                proyecto.tipo = txtTipoProyecto.Text;
                proyecto.resumen = txtResumenProyecto.Text;
                proyecto.anno_acad = int.Parse(txtAnnoProyecto.Text);
                if (txtFechaProyecto.Text.Length>1)
                {
                    proyecto.fecha_pres = DateTime.Parse(txtFechaProyecto.Text);
                }

                proyecto.logo = txtLogoProyectos.Text;
                proyecto.memoria = txtMemoriaProyecto.Text;
                proyecto.archivos = txtArchivosProyecto.Text;
                proyecto.comentarios = txtComentariosProyecto.Text;



                foreach (Profesor profesor in profesores.results)
                {
                    if (profesor.apellidos == cmbTutorProyecto.SelectedItem)
                    {
                        proyecto.tutor = profesor;
                    }
                }
                foreach (Ciclo ciclo in ciclos.results)
                {
                    if (ciclo.codCiclo == cmbCicloProyecto.SelectedItem)
                    {
                        proyecto.ciclo = ciclo;
                    }
                }

                bool resultado = await controlProyectos.GuardarProyecto(proyecto);
            }
            btnDatoProyecto_Click(sender, e);
        }

        private void btnCancelarProyecto_Click(object sender, EventArgs e)
        {
            btnDatoProyecto_Click(sender, e);
        }

        public void MostrarNombreProfesor()
        {
            lblNombre.Text = $"Bienvenido {SessionData.NombreProfesor} {SessionData.ApellidosProfesor}";
        }

        private void frmAdministracion_Load(object sender, EventArgs e)
        {
            MostrarNombreProfesor();
        }
    }
}
