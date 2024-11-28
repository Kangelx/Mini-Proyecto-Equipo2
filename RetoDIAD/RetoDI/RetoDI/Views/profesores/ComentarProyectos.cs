using RetoDI.frmAlumno;
using RetoDI.Controles;
using RetoDI.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class ComentarProyectos : Form
    {


        public ComentarProyectos()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {

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
            foreach (ListViewItem item in lblcomentar.Items)
            {
                // Si el nombre del proyecto coincide con el texto de búsqueda
                if (item.Text.ToLower().Contains(nombreProyecto.ToLower()))  // Búsqueda insensible a mayúsculas/minúsculas
                {
                    // Seleccionar el item correspondiente en el ListView
                    item.Selected = true;
                    lblcomentar.EnsureVisible(item.Index); // Asegurar que el proyecto sea visible
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
            if (lblcomentar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proyecto.");
                return;
            }

            // Verificar y guardar el comentario
            // await VerificarComentarioExistente();
        }


    }
}
