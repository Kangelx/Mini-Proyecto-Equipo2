using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoDI.Models
{
    public class Proyecto
    {
        public int idproyecto { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string resumen { get; set; }
        public int anno_acad { get; set; }
        public DateTime? fecha_pres { get; set; }
        public string logo { get; set; }
        public string memoria { get; set; }
        public string archivos { get; set; }
        public string comentarios { get; set; }
        public Ciclo ciclo { get; set; }
        public Profesor tutor { get; set; }

    }
}
