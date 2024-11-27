using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoDI.Models
{
    public class Alumno
    {
        public int id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string CorreoElectronico { get; set; }
        public string ContraseñaEncriptada { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EsAlumnoActual { get; set; }
        public Ciclo CicloFormativo { get; set; }
       
    }
   
    }
