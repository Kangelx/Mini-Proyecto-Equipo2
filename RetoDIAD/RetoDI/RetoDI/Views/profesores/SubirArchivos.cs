using RetoDI.Controles;
using RetoDI.Models;
using System.IO;
using System.Windows.Forms;
using System;


namespace WinFormsApp1
{
    public partial class SubirArchivos : Form
    {

        public SubirArchivos()
        {
            InitializeComponent();

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
                textBox1.Text = fileName; // Mostrar nombre en el TextBox                                             
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
                string filePath = openFileDialog1.FileName; // Ruta del archivo seleccionado
                textBox1.Text = filePath; // Mostrar la ruta en el TextBox
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

            // Verificar si un proyecto ha sido seleccionado en el ListView
            if (lvArchivos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proyecto.");
                return;
            }

            // Obtener la fila seleccionada del ListView
            ListViewItem selectedItem = lvArchivos.SelectedItems[0];

            // Obtener los datos del proyecto desde la fila seleccionada
            string nombreProyecto = selectedItem.Text; // El nombre del proyecto está en la primera columna
            string cicloProyecto = selectedItem.SubItems[1].Text; // El nombre del ciclo está en la segunda columna
            string archivosProyecto = selectedItem.SubItems[2].Text; // Los archivos del proyecto están en la tercera columna

            // Verificar que el nombre del proyecto, ciclo y archivos estén disponibles
            if (string.IsNullOrEmpty(nombreProyecto) || string.IsNullOrEmpty(cicloProyecto))
            {
                MessageBox.Show("Faltan datos importantes (nombre del proyecto o ciclo).");
                return;
            }

            // Crear un objeto Proyecto con los datos del formulario
            Proyecto proyectoNuevo = new Proyecto
            {
                Nombre = nombreProyecto,
                ciclo = new Ciclo { nombre = cicloProyecto },
                archivos = archivosProyecto
            };

            // Crear una instancia del ControlProyectos para guardar el proyecto
            ControlProyectos controlProyectos = new ControlProyectos();

            // Llamar al método GuardarProyecto y esperar su resultado
            bool exito = await controlProyectos.GuardarProyecto(proyectoNuevo);

            // Realizar cualquier acción adicional si es necesario
            if (exito)
            {
                // Limpiar los campos después de guardar (opcional)               
            }
        }

        private void lvArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}

