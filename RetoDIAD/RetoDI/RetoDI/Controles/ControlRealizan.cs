using Newtonsoft.Json;
using RetoDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoDI.Controles
{
    public class ControlRealizan
    {
        //Defino una variable privada de tipo HTTP de nombre client
        private HttpClient client;


        //Definimos el constructor
        public ControlRealizan()
        {
            //Creamos una instancia de nuestro cliente
            client = new HttpClient();
        }


        //Creamos nuestra petición,
        public async Task<Realizadas> GetAllRealizas()

        {
            try
            {
                //Hacemos una instancia 
                Realizadas realizan = new Realizadas();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync("http://localhost:4000/realizan");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto de tipo "Personajes" utilizando la
                //biblioteca Newtonsoft.Json

                realizan.results = JsonConvert.DeserializeObject<List<Realizada>>(responseJson);

                //Devuelve el objeto "personajes" con los datos obtenidos de la API
                return realizan;

            }

            catch (Exception e)
            {

                //Si ocurre algún error (como problemos de conexión o un JSON no válido),
                //captura la excepción y devuelve "null" como valor de error

                MessageBox.Show(e.Message);
                return null;

            }
        }
        //peticion para guardar calificacion
        public async Task<bool> GuardarRealizada(Realizada realizada)
        {
            try
            {
                int id = realizada.id;
                // Creamos la URL para la API donde se guardarán los proyectos
                string apiUrl = $"http://localhost:4000/realizada/{id}";  // Cambia esta URL según tu servidor y API

                // Creamos un objeto HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Creamos un objeto con los datos que queremos enviar en el cuerpo de la solicitud
                    var content = new StringContent(
                        JsonConvert.SerializeObject(realizada),
                        Encoding.UTF8,
                        "application/json"
                    );

                    // Enviamos la solicitud POST a la API
                    HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                    // Verificamos si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("calificacion guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        string errorDetails = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Error al guardar la calificacion. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, mostramos un mensaje de error
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }

}
/*
try
            {
                // Convertir el objeto Realizada a JSON
                string json = JsonConvert.SerializeObject(realizada);

                // Crear el contenido de la solicitud (POST)
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                int id = realizada.id;
                // Realizar la solicitud POST a la API
                HttpResponseMessage response = await client.PutAsync($"http://localhost:4000/realizan/{id}", content);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Realizada guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true; // La calificación fue guardada con éxito
                }
                else
                {
                    MessageBox.Show(response.RequestMessage.ToString());
                    return false; // Hubo un error
                }
            }
            catch (Exception e)
            {
                // Captura cualquier excepción y muestra un mensaje de error
                MessageBox.Show($"Error: {e.Message}");
                return false;
            }
        }

    }
}
*/