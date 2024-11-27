using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoDI.Models
{
    public class Profesor
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string CorreoElectronico { get; set; }
        public string ContraseñaEncriptada { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Especialidad { get; set; }
        public bool ActivoActualmente { get; set; }
        public bool EsAdministrador { get; set; }
    }
}
