using RetoDI.frmAlumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                SessionData.TipoUsuario = "Administrador";
                frmBotones adminVentana = new frmBotones(this);
                adminVentana.Show();
                this.Hide();
            }
            else if (usuario == "Profesor" && contrasenia == "12345")
            {

                SessionData.TipoUsuario = "Profesor";
                frmBotones profVentana = new frmBotones(this);
                profVentana.Show();
                this.Hide();
            }
            else if (usuario == "Alumno" && contrasenia == "12345")
            {
                frmAlumno.frmAlumno alumnoVentana = new frmAlumno.frmAlumno(this);
                alumnoVentana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtContrasenia.Text = "";
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
    public static class SessionData
    {
        public static string TipoUsuario { get; set; }
    }
}
