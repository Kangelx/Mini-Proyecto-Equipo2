using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoDI.UtilidadesAPI
{
    public class Reply
    {
        public string StatusCode { get; set; }   //para almacenar el codigo de estado de la respuesta HTTP
        public object Data { get; set; }    //objeto generico con los datos que devuelve la API
    }

    public enum methodHttp
    {
        GET,
        POST,
        PUT,
        DELETE
    }
}
