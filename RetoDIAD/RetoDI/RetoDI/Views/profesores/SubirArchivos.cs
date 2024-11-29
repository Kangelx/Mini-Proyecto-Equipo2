using RetoDI.Controles;
using RetoDI.Models;
using System.IO;
using System.Windows.Forms;
using System;


namespace WinFormsApp1
{
    public partial class SubirArchivos : Form
    {
        private ControlProyectos controlProyectos;
        private Proyectos proyectos;
        public SubirArchivos()
        {
            InitializeComponent();
            controlProyectos = new ControlProyectos();
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
                txtarchivo.Text = fileName; // Mostrar nombre en el TextBox                                             
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
                txtarchivo.Text = filePath; // Mostrar la ruta en el TextBox
            }
        }



        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si un proyecto ha sido seleccionado
            if (lvArchivos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proyecto.");
                return;
            }
            if (lvArchivos.SelectedItems.Count > 0)
            {
                Proyecto proyecto = (Proyecto)lvArchivos.SelectedItems[0].Tag;
                
                if (string.IsNullOrEmpty(txtarchivo.Text.Trim()))
                {
                    MessageBox.Show("Por favor, suba un archivo.");
                    return;
                }

                
                proyecto.archivos = txtarchivo.Text.Trim();

                // Llamar al método GuardarProyecto del controlador para guardar el comentario en la API
                bool resultado = await controlProyectos.GuardarProyecto(proyecto);

               
                if (resultado)
                {
                    foreach (ListViewItem item in lvArchivos.Items)
                    {
                        // Verificamos si el Tag coincide con el proyecto
                        if (item.Tag == proyecto)
                        {                            
                            item.SubItems[1].Text = proyecto.archivos; 
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error al guardar el archivo.");
                }
            }
        }




    

        private void lvArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void lvArchivos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Verificar si hay un proyecto seleccionado
            if (lvArchivos.SelectedItems.Count > 0)
            {
                // Obtener el proyecto desde el Tag del ListViewItem seleccionado
                Proyecto proyecto = (Proyecto)lvArchivos.SelectedItems[0].Tag;

                // Cargar el comentario en el TextBox 
                
            }
        }
    }
}

