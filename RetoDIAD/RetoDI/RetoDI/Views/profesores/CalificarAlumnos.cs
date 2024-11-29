using RetoDI.Controles;
using RetoDI.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class CalificarAlumnos : Form
    {
        private ControlRealizan controlRealizan;
        private Realizada realizada;

        public CalificarAlumnos()
        {
            InitializeComponent();
            controlRealizan = new ControlRealizan();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreAlumno = txtBuscarAlumno.Text.Trim(); // Obtener el nombre ingresado

            if (string.IsNullOrEmpty(nombreAlumno))
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar.");
                return;
            }

            bool encontrado = false;

            // Recorrer los elementos del ListView de alumnos
            foreach (ListViewItem item in lvAlumnos.Items)
            {
                // Si el nombre del alumno coincide con el texto de búsqueda
                if (item.Text.ToLower().Contains(nombreAlumno.ToLower()))  // Búsqueda insensible a mayúsculas/minúsculas
                {
                    // Seleccionar el item correspondiente en el ListView
                    item.Selected = true;
                    lvAlumnos.EnsureVisible(item.Index); // Asegurar que el alumno sea visible
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron alumnos con ese nombre.");
            }
        }

        // Evento del botón de Guardar calificación
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si un proyecto ha sido seleccionado
            if (lvAlumnos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un alumno.");
                return;
            }
            if (lvAlumnos.SelectedItems.Count > 0)
            {
                Realizada realizada = (Realizada)lvAlumnos.SelectedItems[0].Tag;
                
                if (string.IsNullOrEmpty(txtCalificacion.Text.Trim()))
                {
                    MessageBox.Show("Por favor, ingrese una calificacion.");
                    return;
                }

                // Asignar el comentario ingresado en el TextBox al proyecto
                realizada.calificacion = int.Parse(txtCalificacion.Text.Trim());

                // Llamar al método GuardarProyecto del controlador para guardar el comentario en la API
                bool resultado = await controlRealizan.GuardarRealizada(realizada);

                // Verificar si el comentario fue guardado correctamente
                if (resultado)
                {
                    foreach (ListViewItem item in lvAlumnos.Items)
                    {
                        // Verificamos si el Tag coincide con el proyecto
                        if (item.Tag == realizada)
                        {
                            // Actualizamos el comentario en el ListViewItem
                            item.SubItems[2].Text = realizada.calificacion.ToString(); // Suponiendo que la segunda columna contiene los comentarios
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error al guardar la calificacion.");
                }
            }
        }


        private void lvAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lvAlumnos.SelectedItems.Count > 0)
            {              
                Realizada realizada = (Realizada)lvAlumnos.SelectedItems[0].Tag;               
                txtCalificacion.Text = realizada.calificacion.ToString();
            }
        }
    }
    }
