using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoDI.Models
{
    public class Realizada
    {
        public int id {  get; set; }
        public int calificacion { get; set; }
        public Alumno alumno { get; set; }
        public Proyecto proyecto { get; set; }
        public string comentario { get; set; }
    }
}
