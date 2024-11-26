using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoDI.Views.profesores
{
    public partial class Proyectoo : Form
    {       

        public Proyectoo()
        {
            InitializeComponent();
        }      
        

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cerrarsesion_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "¿Está seguro de que desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }
    }
    }

