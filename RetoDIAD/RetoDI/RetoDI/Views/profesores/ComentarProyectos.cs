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
    public partial class ComentarProyectos : Form
    {
        public ComentarProyectos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //busca el nombre de proyecto, se autoselecciona el proyecto si es 1 y si son varios se selecciona
            //cual se quiere comentar, se selecciona y se añade el comentario.
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //se muestra un mensaje de estas seguro que quieres guardar el comentario, si es si se añade a al lista
        }
    }
}
