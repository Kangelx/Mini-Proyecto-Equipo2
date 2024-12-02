using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoDI.Models
{
    public class Profesor
    {
        public string idprofesor { get; set; }

        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public string password_encr { get; set; }
        public string telefono { get; set; }
        public string genero { get; set; }
        public DateTime fechaNac { get; set; }
        public string especialidad { get; set; }
        public bool activo { get; set; }
        public bool admin { get; set; }
    }
}
