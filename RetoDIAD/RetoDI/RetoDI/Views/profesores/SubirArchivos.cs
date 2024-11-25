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
        private ControlRealizan ControlRealizan;
        //Inicializamos el modelo, es un objeto que almacena los datos
        //deserializados de la API
        private Realizadas realizan;
        public SubirArchivos()
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
                   


                    // Agregar el item al ListView
                    lvArchivos.Items.Add(item);
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
