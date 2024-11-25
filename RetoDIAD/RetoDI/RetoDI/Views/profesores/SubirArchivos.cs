using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SubirArchivos : Form
    {
        public SubirArchivos()
        {
            InitializeComponent();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            //perguntar si esta seguro y mostrar los detalles
        }

       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Llamamos a la API y obtenemos los alumnos
            //List<Alumno> alumnos = await ObtenerAlumnos();

            // Limpiar el ListView antes de agregar nuevos elementos
            listView1.Items.Clear();

           /* Agregar los alumnos al ListView
            if (alumnos != null)
            {
                foreach (Alumno alumno in alumnos)
                {
                    // Crear un nuevo item con el nombre y apellido del alumno
                    ListViewItem item = new ListViewItem(alumno.Nombre);
                    item.SubItems.Add(alumno.Apellido);

                    // Agregar el item al ListView
                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los alumnos.");
            }*/
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
    }
}
