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
        public string idAlumno { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string telefono { get; set; }
        public string genero { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool activo { get; set; }
        public Ciclo ciclo { get; set; }
       
    }
   
    }
