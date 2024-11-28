using RetoDI.Controles;
using RetoDI.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class CalificarAlumnos : Form
    {


        public CalificarAlumnos()
        {
            InitializeComponent();
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
            // Verificar si un alumno ha sido seleccionado
            if (lvAlumnos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un alumno.");
                return;
            }

            // Obtener el nombre del alumno seleccionado
            ListViewItem selectedItem = lvAlumnos.SelectedItems[0];

            // Obtener el nombre del alumno y proyecto desde la fila seleccionada
            string nombreAlumno = selectedItem.Text; // Suponemos que el nombre está en la primera columna
            string nombreProyecto = selectedItem.SubItems[1].Text;

            // Verificar que el nombre del alumno y el proyecto estén disponibles
            if (string.IsNullOrEmpty(nombreAlumno) || string.IsNullOrEmpty(nombreProyecto))
            {
                MessageBox.Show("Faltan datos importantes (nombre del alumno o proyecto).");
                return;
            }

            // Obtener la calificación ingresada por el usuario
            string calificacion = txtCalificacion.Text.Trim();
            if (string.IsNullOrEmpty(calificacion))
            {
                MessageBox.Show("Por favor, ingrese una calificación.");
                return;
            }


            // Crear una nueva instancia de Realizada
            Realizada realizada = new Realizada
            {
                alumno = new Alumno { nombre = nombreAlumno }, // Suponemos que solo necesitas el nombre del alumno
                proyecto = new Proyecto { Nombre = nombreProyecto }, // Asumimos que solo necesitas el nombre del proyecto
                calificacion = int.Parse(calificacion), // Convertir la calificación a int

            };

            // Instanciar el controlador para la API
            ControlRealizan controlRealizan = new ControlRealizan();

            // Llamar al método para guardar los datos
            bool resultado = await controlRealizan.GuardarRealizada(realizada);

            // Verificar si la calificación fue guardada correctamente
            if (resultado)
            {
                MessageBox.Show("Calificación guardada correctamente.");
            }
            else
            {
                MessageBox.Show("Error al guardar la calificación.");
            }
        }
    }
}