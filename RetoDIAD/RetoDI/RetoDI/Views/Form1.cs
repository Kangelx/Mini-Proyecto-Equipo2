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
using RetoDI.Controles;
using RetoDI.Models;



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

        private Profesor profesorAutenticado;
        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseniaEncriptada = txtContrasenia.Text;


            ControlProfesores controlProfesores = new ControlProfesores();
            ControlAlumnos controlAlumnos = new ControlAlumnos();

            try
            {

                Profesores profesores = await controlProfesores.GetAllProfesores();
                Alumnos alumnos = await controlAlumnos.GetAllAlumnos();


                if (profesores != null && profesores.results != null)
                {
                    Profesor profesor = profesores.results
                        .FirstOrDefault(p => p.email == usuario && p.password_encr == contraseniaEncriptada);

                    if (profesor != null)
                    {


                        SessionData.TipoUsuario = profesor.admin ? "Administrador" : "Profesor";

                        SessionData.NombreProfesor = profesor.nombre;
                        SessionData.ApellidosProfesor = profesor.apellidos;
                        SessionData.IdProfesor = profesor.idprofesor;


                        frmBotones botonesVentana = new frmBotones(this);
                        botonesVentana.Show();
                        this.Hide();
                        return;
                    }
                }


                if (alumnos != null && alumnos.results != null)
                {
                    Alumno alumno = alumnos.results
                        .FirstOrDefault(a => a.email == usuario && a.password == contraseniaEncriptada);

                    if (alumno != null)
                    {

                        RetoDI.frmAlumno.frmAlumno frmAlumnoVentana = new RetoDI.frmAlumno.frmAlumno(this);
                        frmAlumnoVentana.Show();
                        this.Hide();
                        return;
                    }
                }


                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                txtContrasenia.Text = "";
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
    public static class SessionData
    {
        public static string TipoUsuario { get; set; }
        public static string NombreProfesor { get; set; }
        public static string ApellidosProfesor { get; set; }
        public static string IdProfesor { get; set; }
    }
}
