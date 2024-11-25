using RetoDI.Alumno;
using RetoDI.Controles;
using RetoDI.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class ComentarProyectos : Form
    {
        //Declaramos el controlador, un objeto que controla la lógica
        //para obtener los personajes de la API
        private ControlAlumnos ControlAlumnos;
        //Inicializamos el modelo, es un objeto que almacena los datos
        //deserializados de la API
        private Alumnos alumnos;

        public ComentarProyectos()
        {
            InitializeComponent();
            ControlAlumnos = new ControlAlumnos();
            alumnos = new Alumnos();
        }

        //Método asíncrono para obtener los personajes de la API
        private async void GetAlumnos()
        {
            //Llama al método GetAllAlumnos para obtener los personajes de la API de manera asíncrona
            alumnos = await ControlAlumnos.GetAllAlumnos();

            //Verifica si el objeto personajes no es nulo, es decir, si la llamada a la API fue exitosa

            if (alumnos != null)
            {
                //Recorre la lista de resultados (alumnos) obtenidos desde la API
                foreach (var alumno in alumnos?.results)// ? e ! para permitir nulos y evitar errores
                {
                    // Crear un nuevo item 
                    //ListViewItem item = new ListViewItem(alumno.Alumno); // Primera columna

                    // Agregar los subítems (equivalentes a las celdas de las otras columnas)

                   // item.SubItems.Add(alumno.Proyecto); // Segunda columna
                    //item.SubItems.Add(alumno.Calificacion);  // Tercera columna

                    // Agregar el item al ListView
                    //lvAlumnos.Items.Add(item);
                }
            }

            else
            {
                MessageBox.Show("No se pudo obtener la petición", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAlumnos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreProyecto = txtBuscarProyecto.Text.Trim(); // Obtener el nombre del proyecto ingresado

            if (string.IsNullOrEmpty(nombreProyecto))
            {
                MessageBox.Show("Por favor, ingrese un nombre de proyecto para buscar.");
                return;
            }

            bool encontrado = false;

            // Recorrer los elementos del ListView de proyectos
            foreach (ListViewItem item in listViewProyectos.Items)
            {
                // Si el nombre del proyecto coincide con el texto de búsqueda
                if (item.Text.ToLower().Contains(nombreProyecto.ToLower()))  // Búsqueda insensible a mayúsculas/minúsculas
                {
                    // Seleccionar el item correspondiente en el ListView
                    item.Selected = true;
                    listViewProyectos.EnsureVisible(item.Index); // Asegurar que el proyecto sea visible
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron proyectos con ese nombre.");
            }
        }

        private async Task btnAñadir_ClickAsync(object sender, EventArgs e)
        {
            // Verificar si un proyecto ha sido seleccionado
            if (listViewProyectos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proyecto.");
                return;
            }

            // Verificar y guardar el comentario
           // await VerificarComentarioExistente();
        }

        /*
        // Método para verificar si el proyecto ya tiene un comentario
        private async Task VerificarComentarioExistente()
        {
            string proyectoSeleccionadoNombre = listViewProyectos.SelectedItems[0].Text;

            try
            {
                // Llamar a la API para verificar si el proyecto ya tiene un comentario
                string comentarioExistente = await _apiService.GetAsync<string>($"api/proyectos/comentario/{proyectoSeleccionadoNombre}");

                if (!string.IsNullOrEmpty(comentarioExistente))
                {
                    // Si ya tiene comentario, preguntar si deseas sobrescribirlo
                    DialogResult dialogResult = MessageBox.Show("Este proyecto ya tiene un comentario. ¿Desea sobrescribirlo?",
                        "Confirmar sobrescritura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Guardar el nuevo comentario
                        await GuardarComentario(proyectoSeleccionadoNombre);
                    }
                    else
                    {
                        MessageBox.Show("El comentario no ha sido modificado.");
                    }
                }
                else
                {
                    // Si no tiene comentario, guardar el nuevo
                    await GuardarComentario(proyectoSeleccionadoNombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el comentario: {ex.Message}");
            }
        }

        // Método para guardar el comentario en la API
        private async Task GuardarComentario(string proyectoSeleccionadoNombre)
        {
            string comentario = txtComentario.Text.Trim(); // Comentario del TextBox

            var requestBody = new
            {
                ProyectoNombre = proyectoSeleccionadoNombre,  // Usamos el nombre del proyecto
                Comentario = comentario
            };

            try
            {
                // Enviar el comentario a la API usando POST
                var resultado = await _apiService.PostAsync<bool>("api/proyectos/comentar", requestBody);

                if (resultado)
                {
                    MessageBox.Show("Comentario guardado correctamente.");

                    // Actualizar el comentario en el ListView
                    listViewProyectos.SelectedItems[0].SubItems[1].Text = comentario;

                    // Limpiar el campo de comentario
                    txtComentario.Clear();
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar el comentario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el comentario: {ex.Message}");
            }
        }
        */

    }
}
   