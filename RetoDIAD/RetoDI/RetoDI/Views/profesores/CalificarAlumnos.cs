using RetoDI.Controles;
using RetoDI.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class CalificarAlumnos : Form
    {
        //Declaramos el controlador, un objeto que controla la lógica
        //para obtener los personajes de la API
        private ControlRealizan ControlRealizan;
        //Inicializamos el modelo, es un objeto que almacena los datos
        //deserializados de la API
        private Realizadas realizan;

        public CalificarAlumnos()
        {
            InitializeComponent();
            ControlRealizan = new ControlRealizan();
            realizan = new Realizadas();
        }

        //Método asíncrono para obtener los personajes de la API
        private async void GetRealizan()
        {
            //Llama al método GetAllAlumnos para obtener los personajes de la API de manera asíncrona
            realizan = await ControlRealizan.GetAllRealizas();

            //Verifica si el objeto personajes no es nulo, es decir, si la llamada a la API fue exitosa

            if (realizan != null)
            {
                //Recorre la lista de resultados (alumnos) obtenidos desde la API
                foreach (Realizada realiza in realizan?.results)// ? e ! para permitir nulos y evitar errores
                {
                    // Crear un nuevo item 
                    ListViewItem item = new ListViewItem(realiza.alumno); // Primera columna

                    // Agregar los subítems (equivalentes a las celdas de las otras columnas)

                    item.SubItems.Add(realiza.proyecto); // Segunda columna
                    item.SubItems.Add(realiza.comentario); // tercera columna


                    // Agregar el item al ListView
                    lvAlumnos.Items.Add(item);
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

            // Verificar y guardar la calificación
         
        }
        
        
        
        
    }
}