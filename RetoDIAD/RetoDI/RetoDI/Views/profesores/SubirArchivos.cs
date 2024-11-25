using RetoDI.Controles;
using RetoDI.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SubirArchivos : Form
    {
        //Declaramos el controlador, un objeto que controla la lógica
        //para obtener los personajes de la API
        private ControlAlumnos ControlAlumnos;
        //Inicializamos el modelo, es un objeto que almacena los datos
        //deserializados de la API
        private Alumnos alumnos;
        public SubirArchivos()
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
                foreach (Alumno alumno in alumnos?.results)// ? e ! para permitir nulos y evitar errores
                {
                    // Crear un nuevo item 
                    ListViewItem item = new ListViewItem(alumno.Nombre); // Primera columna

                    // Agregar los subítems (equivalentes a las celdas de las otras columnas)

                    item.SubItems.Add(alumno.Apellidos); // Segunda columna
                    

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

        private void btnSubir_Click(object sender, EventArgs e)
        {

            

        }

       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void btnSubir_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de todos los tipos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName; // Ruta del archivo seleccionado
                string fileName = Path.GetFileName(filePath); // Nombre del archivo

                // Llamar al método para subir el archivo a la API
                // SubirArchivoAAPI(filePath, fileName);
            }
        }

        private void btnSubir_Click_2(object sender, EventArgs e)
        {

        }
    }
}
