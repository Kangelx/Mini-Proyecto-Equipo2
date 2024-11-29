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
using WinFormsApp1;


namespace RetoDI
{
    public partial class frmGestiiónInterna : Form
    {
        // private readonly ApiService _apiService;
        private ControlAlumnos controlAlumnos;
        private ControlProyectos controlProyectos;
        private ControlProfesores controlProfesores;
        private ControlRealizan controlRealizan;
        private Alumnos alumnos;
        private Proyectos proyectos;
        private Profesores profesores;
        private Realizadas realizadas;
        public frmGestiiónInterna()
        {
            InitializeComponent();
            controlAlumnos = new ControlAlumnos();
            controlProfesores = new ControlProfesores();
            controlProyectos = new ControlProyectos();
            controlRealizan = new ControlRealizan();
        }


        private async void btnSubirarchivos_Click(object sender, EventArgs e)
        {
            {
                proyectos = await controlProyectos.GetAllProyectos();
                // Crear una instancia del formulario Botones
                SubirArchivos subirArchivos = new SubirArchivos();
                // Configurar el formulario para que no sea independiente
                subirArchivos.TopLevel = false;
                subirArchivos.FormBorderStyle = FormBorderStyle.None;

                subirArchivos.Dock = DockStyle.Fill; // Ajustar al tamaño del panel
                // Limpiar cualquier control previo en el Panel2
                splitContainer1.Panel2.Controls.Clear();
                // Agregar el formulario al Panel2
                splitContainer1.Panel2.Controls.Add(subirArchivos);

                ListViewItem item;
                foreach (Proyecto proyecto in proyectos.results)
                {
                    item = new ListViewItem(new[] { proyecto.nombre, proyecto.archivos });
                    item.Tag = proyecto;
                    subirArchivos.lvArchivos.Items.Add(item);
                }
                // Mostrar el formulari.
                subirArchivos.Show();

            }
        }

        private async void btnAñadircomentarios_Click(object sender, EventArgs e)
        {

            {
                proyectos =  await controlProyectos.GetAllProyectos();
                // Crear una instancia del formulario Botones
                ComentarProyectos comentarios = new ComentarProyectos();

                // Configurar el formulario para que no sea independiente
                comentarios.TopLevel = false;
                comentarios.FormBorderStyle = FormBorderStyle.None;

                comentarios.Dock = DockStyle.Fill; // Ajustar al tamaño del panel

                // Limpiar cualquier control previo en el Panel2
                splitContainer1.Panel2.Controls.Clear();

                // Agregar el formulario al Panel2
                splitContainer1.Panel2.Controls.Add(comentarios);
                ListViewItem item;

                foreach (Proyecto proyecto in proyectos.results)
                {
                    item = new ListViewItem(new[] { proyecto.nombre, proyecto.resumen, proyecto.comentarios });
                    item.Tag = proyecto;
                    comentarios.lblcomentar.Items.Add(item);
                }

                // Mostrar el formulario
                comentarios.Show();
            }
        }

        private async void btnCalificar_Click(object sender, EventArgs e)
        {
            {
                realizadas = await controlRealizan.GetAllRealizas();
                // Crear una instancia del formulario Botones
                CalificarAlumnos calificar = new CalificarAlumnos();

                // Configurar el formulario para que no sea independiente
                calificar.TopLevel = false;
                calificar.FormBorderStyle = FormBorderStyle.None;

                calificar.Dock = DockStyle.Fill; // Ajustar al tamaño del panel

                // Limpiar cualquier control previo en el Panel2
                splitContainer1.Panel2.Controls.Clear();

                // Agregar el formulario al Panel2
                splitContainer1.Panel2.Controls.Add(calificar);
                ListViewItem item;
                foreach (Realizada realizada in realizadas.results)
                {
                    item = new ListViewItem(new[] { realizada.alumno.nombre, realizada.proyecto.nombre, realizada.calificacion.ToString() });
                    item.Tag = realizada;
                    calificar.lvAlumnos.Items.Add(item);
                }

                // Mostrar el formulario
                calificar.Show();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Cerrarsesion_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.ShowDialog();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //llamar al txtusuario de form1

        }
    }
}
