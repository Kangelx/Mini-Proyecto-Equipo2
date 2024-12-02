using RetoDI.frmAlumno;
using RetoDI.Controles;
using RetoDI.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class ComentarProyectos : Form
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

        public ComentarProyectos()
        {
            InitializeComponent();
            controlAlumnos = new ControlAlumnos();
            controlProfesores = new ControlProfesores();
            controlProyectos = new ControlProyectos();
            controlCiclos = new ControlCiclos();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private async Task btnAñadir_ClickAsync(object sender, EventArgs e)
        {

        }
        private void lblcomentar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay un proyecto seleccionado
            if (lblcomentar.SelectedItems.Count > 0)
            {
                // Obtener el proyecto desde el Tag del ListViewItem seleccionado
                Proyecto proyecto = (Proyecto)lblcomentar.SelectedItems[0].Tag;

                // Cargar el comentario en el TextBox (supongo que el TextBox se llama txtComentario)
                txtComentario.Text = proyecto.comentarios;
            }
        }

        private async void btnAñadir_Click(object sender, EventArgs e)
        {
            // Verificar si un proyecto ha sido seleccionado
            if (lblcomentar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proyecto.");
                return;
            }
            if (lblcomentar.SelectedItems.Count > 0)
            {
                Proyecto proyecto = (Proyecto)lblcomentar.SelectedItems[0].Tag;
                // Verificar que el comentario no esté vacío
                if (string.IsNullOrEmpty(txtComentario.Text.Trim()))
                {
                    MessageBox.Show("Por favor, ingrese un comentario.");
                    return;
                }

                // Asignar el comentario ingresado en el TextBox al proyecto
                proyecto.comentarios = txtComentario.Text.Trim();

                // Llamar al método GuardarProyecto del controlador para guardar el comentario en la API
                bool resultado = await controlProyectos.GuardarProyecto(proyecto);

                // Verificar si el comentario fue guardado correctamente
                if (resultado)
                {
                    foreach (ListViewItem item in lblcomentar.Items)
                    {
                        // Verificamos si el Tag coincide con el proyecto
                        if (item.Tag == proyecto)
                        {
                            // Actualizamos el comentario en el ListViewItem
                            item.SubItems[2].Text = proyecto.comentarios; // Suponiendo que la segunda columna contiene los comentarios
                            break;
                        }
                    }                
                }
                else
                {
                    MessageBox.Show("Error al guardar el comentario.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

