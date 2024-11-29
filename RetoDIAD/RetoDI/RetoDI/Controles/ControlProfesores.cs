using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RetoDI.Models;
using System.Windows.Forms;

namespace RetoDI.Controles
{
    public class ControlProfesores
    {
        //Defino una variable privada de tipo HTTP de nombre client
        private HttpClient client;


        //Definimos el constructor
        public ControlProfesores()
        {
            //Creamos una instancia de nuestro cliente
            client = new HttpClient();
        }


        //Creamos nuestra petición,
        public async Task<Profesores> GetAllProfesores()

        {
            try
            {
                //Hacemos una instancia de Personajes
                Profesores profesores = new Profesores();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync("http://localhost:4000/profesor");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto de tipo "Personajes" utilizando la
                //biblioteca Newtonsoft.Json
                profesores.results = JsonConvert.DeserializeObject<List<Profesor>>(responseJson);

                //Devuelve el objeto "personajes" con los datos obtenidos de la API
                return profesores;

            }

            catch (Exception)
            {

                //Si ocurre algún error (como problemos de conexión o un JSON no válido),
                //captura la excepción y devuelve "null" como valor de error
                return null;

            }
        }

        public async Task<bool> GuardarProfesor(Profesor profesor)
        {
            try
            {
                // Convertir el objeto Realizada a JSON
                string json = JsonConvert.SerializeObject(profesor);

                // Crear el contenido de la solicitud (POST)
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                string id = profesor.idprofesor;
                // Realizar la solicitud POST a la API
                HttpResponseMessage response = await client.PutAsync($"http://localhost:4000/profesor/{id}", content);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Profesor guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
