﻿using Newtonsoft.Json;
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
    public class ControlProyectos
    {
        //Defino una variable privada de tipo HTTP de nombre client
        private HttpClient client;


        //Definimos el constructor
        public ControlProyectos()
        {
            //Creamos una instancia de nuestro cliente
            client = new HttpClient();
        }


        //Creamos nuestra petición,
        public async Task<Proyectos> GetAllProyectos()

        {
            try
            {
                //Hacemos una instancia de Personajes
                Proyectos proyectos = new Proyectos();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync("http://localhost:4000/proyecto");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto de tipo "Personajes" utilizando la
                //biblioteca Newtonsoft.Json
                proyectos.results = JsonConvert.DeserializeObject<List<Proyecto>>(responseJson);

                //Devuelve el objeto "personajes" con los datos obtenidos de la API
                return proyectos;

            }

            catch (Exception e)
            {

                //Si ocurre algún error (como problemos de conexión o un JSON no válido),
                //captura la excepción y devuelve "null" como valor de error
                MessageBox.Show(e.Message);
                return null;

            }
        }
    }
}