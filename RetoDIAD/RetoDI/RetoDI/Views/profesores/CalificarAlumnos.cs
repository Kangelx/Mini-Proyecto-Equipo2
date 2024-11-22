using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CalificarAlumnos : Form
    {
        public CalificarAlumnos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //se pregunta si esta seguro y se añade a la lista
            //si ya hay una calificacion se pregunta si se quiere sobreescribir si es si se guarda si es no se deja la que estba
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //se busca nombre alumno y se seleciona
        }
    }
}
