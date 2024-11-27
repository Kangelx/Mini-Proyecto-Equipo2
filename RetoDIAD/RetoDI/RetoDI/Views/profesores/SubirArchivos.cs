using RetoDI.Controles;
using RetoDI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
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
                    ListViewItem item = new ListViewItem(realiza.alumno.Nombre); // Primera columna

                    // Agregar los subítems (equivalentes a las celdas de las otras columnas)

                    item.SubItems.Add(realiza.proyecto.Nombre); // Segunda columna
                   


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
               


        private void btnSubir_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de todos los tipos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName; // Ruta del archivo seleccionado
                string fileName = Path.GetFileName(filePath); // Nombre del archivo                
            }
        }

        private void btnSubir_Click_2(object sender, EventArgs e)
        {
            // Configuración del OpenFileDialog
            openFileDialog1.InitialDirectory = @"C:\"; // Establece la carpeta inicial para la búsqueda
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Filtro para archivos .txt y todos los archivos
            openFileDialog1.FilterIndex = 2; // Establece el filtro predeterminado
            openFileDialog1.RestoreDirectory = true; // Restaura la última carpeta abierta

            // Muestra el diálogo para seleccionar el archivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario selecciona un archivo, actualiza el TextBox con la ruta del archivo
                textBox1.Text = openFileDialog1.FileName;
            }
        }

       

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener la información que deseas guardar desde el TextBox (en este caso, la ruta de un archivo)
            string filePath = textBox1.Text;

            // Comprobar si el TextBox no está vacío
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Por favor, seleccione un archivo primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // URL de la API donde enviarás los datos
            string apiUrl = "URL API A GUARDAR ARCHIVO";  

            try
            {
                // Crear un objeto HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Crear un objeto con los datos que se quiere enviar 
                    var content = new FormUrlEncodedContent(new[]
                    {
                new KeyValuePair<string, string>("filePath", filePath)
            });

                    // Enviar la solicitud POST a la API
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Si la respuesta fue exitosa, muestra un mensaje al usuario
                        MessageBox.Show("Los cambios se guardaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si la solicitud no fue exitosa, muestra un mensaje de error
                        MessageBox.Show("Error al guardar los cambios. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, muestra el mensaje de error
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

