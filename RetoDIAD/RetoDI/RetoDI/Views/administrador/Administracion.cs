using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RetoDI.Administrador
{
    public partial class Administracion : Form
    {
        // private readonly ApiService _apiService;
        public Administracion()
        {
           // _apiService = new ApiService();
            InitializeComponent();
            //nos aseguramos de que todo este en dock fill
            pnlConsultarDatos.Dock = DockStyle.Fill;
            pnlDatosAlumnos.Dock = DockStyle.Fill;
            pnlDatosProfesores.Dock = DockStyle.Fill;
            pnlDatosProyecto.Dock = DockStyle.Fill;
            //nos aseguramos de que todo este invisible
            pnlDatosAlumnos.Visible = false;
            pnlDatosProfesores.Visible = false;
            pnlDatosProyecto.Visible = false;
            pnlConsultarDatos.Visible = false;
            try
            {
                Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
                this.BackgroundImage = img;
                this.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception ex) 
            {
            
            }     

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Botones botones = new Botones();
            botones.ShowDialog();
            this.Hide();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private async void btnDatosAlumnos_Click(object sender, EventArgs e)
        {

            //cargamos los datos y hacemos que solo se muestre el panel deaseado
            await CargarDatosAlumnosAsync();
            pnlDatosAlumnos.Visible = true;
            pnlDatosProfesores.Visible = false;
            pnlDatosProyecto.Visible = false;
            pnlConsultarDatos.Visible = false;
        }

        private async void btnDatoProfesores_Click(object sender, EventArgs e)
        {
            await CargarDatosAlumnosAsync();
            pnlDatosAlumnos.Visible = false;
            pnlDatosProfesores.Visible = true;
            pnlDatosProyecto.Visible = false;
            pnlConsultarDatos.Visible = false;
        }

        private async Task CargarDatosAlumnosAsync()
        {
            //try
            //{
            //    var alumnos = await _apiService.ObtenerAlumnosAsync();
            //    dataGridView1.DataSource = alumnos;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al cargar datos de alumnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private async Task CargarDatosProfesoresAsync()
        {
            //try
            //{
            //    var profesores = await _apiService.ObtenerProfesoresAsync();
            //    dataGridView1.DataSource = profesores;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al cargar datos de profesores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "¿Está seguro de que desea salir de la aplicación?","Confirmar salida",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide(); 
            }
        }

        private void btnDatoProyecto_Click(object sender, EventArgs e)
        {
            pnlDatosAlumnos.Visible = false;
            pnlDatosProfesores.Visible = false;
            pnlDatosProyecto.Visible = true;
            pnlConsultarDatos.Visible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            pnlDatosAlumnos.Visible = false;
            pnlDatosProfesores.Visible = false;
            pnlDatosProyecto.Visible = false;
            pnlConsultarDatos.Visible = true;
        }

        private void btnAceptarAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarProfesor_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarProfesor_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarProyecto_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarProyecto_Click(object sender, EventArgs e)
        {

        }
    }
}
