using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoDI.Models
{
    internal class Proyecto
    {
        public string Nombre { get; set; }
        public string tipo { get; set; }
        public string resumen { get; set; }
        public int añoacademico { get; set; }
        public DateTime fecha { get; set; }
        public string logo { get; set; }
        public string memoria { get; set; }
        public string archivos { get; set; }
        public string ciclo { get; set; }
        public string tutor { get; set; }
        public string Comentario { get; set; }
    }
}
