﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;


namespace RetoDI
{
    public partial class GestiiónInterna : Form
    {
        

        public GestiiónInterna()
        {
            InitializeComponent();            

        }

        private void btnSubirarchivos_Click(object sender, EventArgs e)
        {
            {
                // Crear una instancia del formulario Botones
                SubirArchivos subirArchivos = new SubirArchivos();

                // Configurar el formulario para que no sea independiente
                subirArchivos.TopLevel = false;
                subirArchivos.FormBorderStyle = FormBorderStyle.None;

                subirArchivos.Dock = DockStyle.Fill; // Ajustar al tamaño del panel

                // Limpiar cualquier control previo en el Panel2
                splitContainer1.Panel2.Controls.Clear();

                // Agregar el formulario al Panel2
                splitContainer1.Panel2.Controls.Add(subirArchivos);

                // Mostrar el formulario
                subirArchivos.Show();
            }
        }

        private void btnAñadircomentarios_Click(object sender, EventArgs e)
        {

            {
                // Crear una instancia del formulario Botones
                ComentarProyectos comentarios = new ComentarProyectos();

                // Configurar el formulario para que no sea independiente
                comentarios.TopLevel = false;
                comentarios.FormBorderStyle = FormBorderStyle.None;

                // Ajustar al tamaño del panel
                comentarios.Dock = DockStyle.Fill;

                // Limpiar cualquier control previo en el Panel2
                splitContainer1.Panel2.Controls.Clear();

                // Agregar el formulario al Panel2
                splitContainer1.Panel2.Controls.Add(comentarios);

                // Mostrar el formulario
                comentarios.Show();
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            {
                // Crear una instancia del formulario Botones
                CalificarAlumnos calificar = new CalificarAlumnos();

                // Configurar el formulario para que no sea independiente
                calificar.TopLevel = false;
                calificar.FormBorderStyle = FormBorderStyle.None;

                calificar.Dock = DockStyle.Fill; // Ajustar al tamaño del panel

                // Limpiar cualquier control previo en el Panel2
                splitContainer1.Panel2.Controls.Clear();

                // Agregar el formulario al Panel2
                splitContainer1.Panel2.Controls.Add(calificar);

                // Mostrar el formulario
                calificar.Show();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Cerrarsesion_Click(object sender, EventArgs e)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Botones botones = new Botones(true);
            botones.Show();
            this.Hide();
        }

        
        }
    }
