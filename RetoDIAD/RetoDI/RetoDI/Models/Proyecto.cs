using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoDI.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string tipo { get; set; }
        public string resumen { get; set; }
        public int anno_acad { get; set; }
        public DateTime fecha { get; set; }
        public string logo { get; set; }
        public string memoria { get; set; }
        public string archivos { get; set; }
        public string Comentario { get; set; }
        public Ciclo ciclo { get; set; }
        public Profesor tutor { get; set; }

    }
}
