using RetoDI.Alumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetoDI.Profesor;
using System.Net.Http;



namespace RetoDI
{
    public partial class frmLogin : System.Windows.Forms.Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.KeyDown += LoginForm_KeyDown;
            this.KeyPreview = true;
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;


            if (usuario == "Administrador" && contrasenia == "12345")
            {
 
                Botones adminVentana = new Botones();
                adminVentana.Show();
                this.Hide();
            }
            else if (usuario == "Profesor" && contrasenia == "12345")
            {
                Profesor.Profesor profesorVentana = new Profesor.Profesor();
                profesorVentana.Show();
                this.Hide();
            }
            else if (usuario == "Alumno" && contrasenia == "12345")
            {
                Alumno.Alumno alumnoVentana = new Alumno.Alumno();
                alumnoVentana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void lkblContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor, contacte al administrador para recuperar su contraseña.", "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
 
                btnIniciar.PerformClick();
                e.Handled = true; 
            }
        }
    }
}
