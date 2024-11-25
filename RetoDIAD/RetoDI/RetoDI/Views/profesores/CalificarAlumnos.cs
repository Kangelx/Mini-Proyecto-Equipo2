using RetoDI.Models;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class CalificarAlumnos : Form
    {
      

            public CalificarAlumnos()
            {
                InitializeComponent();

            // Instanciar ApiService con la URL base  API
           
            // Cargar la lista de alumnos al iniciar el formulario
           // _ = CargarListaAlumnos();
            }
        
        /*
        // Método para cargar la lista de alumnos en el ListView
        private async Task CargarListaAlumnos()
        {
            try
            {
                // Llamar al API para obtener la lista de alumnos
                var alumnos = await _apiService.GetAsync<List<Alumno>>("api/alumno"); // Cambia el endpoint según tu API

                // Limpiar el ListView y agregar los alumnos
                listViewAlumnos.Items.Clear();

                foreach (var alumno in alumnos)
                {
                    var listItem = new ListViewItem(alumno.Nombre);
                    listItem.SubItems.Add(""); 
                    listItem.Tag = alumno; // Guardar el objeto Alumno en la propiedad Tag
                    listViewAlumnos.Items.Add(listItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de alumnos: {ex.Message}");
            }
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
            foreach (ListViewItem item in listViewAlumnos.Items)
            {
                // Si el nombre del alumno coincide con el texto de búsqueda
                if (item.Text.ToLower().Contains(nombreAlumno.ToLower()))  // Búsqueda insensible a mayúsculas/minúsculas
                {
                    // Seleccionar el item correspondiente en el ListView
                    item.Selected = true;
                    listViewAlumnos.EnsureVisible(item.Index); // Asegurar que el alumno sea visible
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
            if (listViewAlumnos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un alumno.");
                return;
            }

            // Verificar y guardar la calificación
            await VerificarCalificacionExistente();
        }
        
        
        
        // Método para verificar si el alumno ya tiene una calificación     
        
        private async Task VerificarCalificacionExistente()
        {
            string alumnoSeleccionadoNombre = listViewAlumnos.SelectedItems[0].Text;

            try
            {
                // Llamar a la API para verificar si el alumno ya tiene una calificación
                bool tieneCalificacion = await _apiService.GetAsync<bool>($"api/calificaciones/existe/{alumnoSeleccionadoNombre}");

                if (tieneCalificacion)
                {
                    // Si tiene calificación, preguntar si deseas sobrescribir
                    DialogResult dialogResult = MessageBox.Show("Este alumno ya tiene una calificación. ¿Desea sobrescribirla?",
                                                               "Confirmar sobrescritura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Guardar la calificación nueva
                        await GuardarCalificacion();
                    }
                    else
                    {
                        MessageBox.Show("La calificación no ha sido modificada.");
                    }
                }
                else
                {
                    // Si no tiene calificación, guardamos la nueva
                    await GuardarCalificacion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar la calificación: {ex.Message}");
            }
        }

        // Método para guardar la calificación en la API
        private async Task GuardarCalificacion()
        {
            string alumnoSeleccionadoNombre = listViewAlumnos.SelectedItems[0].Text;
            decimal calificacion = Convert.ToDecimal(txtCalificacion.Text); // Calificación del TextBox

            var requestBody = new
            {
                AlumnoNombre = alumnoSeleccionadoNombre,  // Usamos el nombre del alumno
                Calificacion = calificacion
            };

            try
            {
                // Enviar la calificación a la API usando POST
                var resultado = await _apiService.PostAsync<bool>("api/calificaciones/guardar", requestBody);

                if (resultado)
                {
                    MessageBox.Show("Calificación guardada correctamente.");

                    // Actualizar la calificación en el ListView
                    listViewAlumnos.SelectedItems[0].SubItems[1].Text = calificacion.ToString();
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar la calificación.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la calificación: {ex.Message}");
            }
        }
    
        */
    }
}