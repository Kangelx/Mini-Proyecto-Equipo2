using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RetoDI.UtilidadesAPI
{
    public class Consumer
    {
        // Método privado que traduce los métodos HTTP definidos en la enumeración "methodHttp"
        // a las instancias correspondientes de la clase HttpMethod.
        private static HttpMethod CreateHttpMethod(methodHttp method)
        {
            switch (method)
            {
                case methodHttp.GET:
                    return HttpMethod.Get;
                case methodHttp.POST:
                    return HttpMethod.Post;
                case methodHttp.PUT:
                    return HttpMethod.Put;
                case methodHttp.DELETE:
                    return HttpMethod.Delete;
                default:
                    throw new NotImplementedException("Método http no implementado");
            }

        }
        // Método público estático para ejecutar solicitudes HTTP.

        // Genera y envía una solicitud al API especificado y devuelve un objeto Reply.

        public static async Task<Reply> Execute<T>(string url, methodHttp method, T objectRequest)
        {
            // Se crea una instancia del objeto Reply para encapsular la respuesta de la API.
            Reply oReply = new Reply();
            try
            {
                // Se crea un cliente HTTP para manejar la solicitud.
                using (HttpClient client = new HttpClient())
                {
                    // Serializa (convierte un objeto de C#(objectRequest) en una cadena de texto en formato JSON)
                    // el objeto de la solicitud (request) a JSON.
                    var myContent = JsonConvert.SerializeObject(objectRequest);
                    // Convierte el contenido serializado en un array de bytes para enviarlo.
                    var bytecontent = new ByteArrayContent(Encoding.UTF8.GetBytes(myContent));
                    // Configura el encabezado de tipo de contenido como "application/json".
                    bytecontent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
 // Se construye la solicitud HTTP usando el método y la URL proporcionados.
// Para GET y DELETE no se incluye el contenido en la solicitud.
                    var request = new HttpRequestMessage(CreateHttpMethod(method), url)
                    {
                        //Si el método no es GET y tampoco Delete, entonces se incluye el contenido, si es delete el contenido es nulo y si es get, el contenido también es nulo
                        Content = (method != methodHttp.GET) ? method != methodHttp.DELETE ? bytecontent : null : null
                    };
                    //Envia la solicitud al servidor de forma asíncrona y espera la respuesta
                    using (HttpResponseMessage res = await client.SendAsync(request))
                    {
                        //Obtiene el contenido de la respuesta
                        using (HttpContent content = res.Content)
                        {
                            //Lee el contenido como una cadena
                            string data = await content.ReadAsStringAsync();
                            // Si hay datos en la respuesta, se deserializan al tipo genérico especificado.
                            if (data != null)
                                oReply.Data = JsonConvert.DeserializeObject<T>(data);
                            // Guarda el código de estado de la respuesta en el objeto Reply.
                            oReply.StatusCode = res.StatusCode.ToString();
                        }
                    }
                }
            }
            // Captura excepciones relacionadas con problemas del servidor o red.
            catch (WebException ex)
            {
                // Código genérico para errores del servidor.
                oReply.StatusCode = "ServerError";
                // Si hay una respuesta específica del servidor, se extrae su código de estado.
                var response = (HttpWebResponse)ex.Response;
                if (response != null)
                    oReply.StatusCode = response.StatusCode.ToString();
            }
            // Captura otras excepciones no relacionadas con la red.
            catch (Exception ex)
            {
                oReply.StatusCode = "AppError";
            }
            // Devuelve el objeto Reply con la respuesta procesada.
            return oReply;

        }

    }

}
