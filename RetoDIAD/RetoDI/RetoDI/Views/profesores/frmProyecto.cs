using RetoDI.Controles;
using RetoDI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace RetoDI.Views.profesores
{
    public partial class frmProyecto : Form
    {
        private ControlProyectos controlProyectos;
        private Proyectos proyectos;
        public frmProyecto()
        {
            InitializeComponent();
            controlProyectos = new ControlProyectos();
        }      
        

        private void btnVolver_Click(object sender, EventArgs e)
        {

           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay un proyecto seleccionado
            if (listViewmisproyectos.SelectedItems.Count > 0)
            {
                // Obtener el proyecto desde el Tag del ListViewItem seleccionado
                Proyecto proyecto = (Proyecto)listViewmisproyectos.SelectedItems[0].Tag;
            }
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

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //TODOS LOS PROYECTOS
        private async void button2_Click(object sender, EventArgs e)
        {
            proyectos = await controlProyectos.GetAllProyectos();
            listViewmisproyectos.Items.Clear();

            ListViewItem item;

            foreach (Proyecto proyecto in proyectos.results)
            {
                item = new ListViewItem(new[]
{
                    proyecto.nombre,                                // Nombre del proyecto
                    proyecto.tipo,                                  // Tipo del proyecto
                    proyecto.anno_acad.ToString(),                  // Año académico (convertido a cadena)
                    proyecto.ciclo?.nombre ?? "Sin ciclo",          // Nombre del ciclo (si existe), si no "Sin ciclo"
                    proyecto.tutor?.nombre ?? "Sin tutor",          // Nombre del tutor (si existe), si no "Sin tutor"
                    proyecto.resumen,                               // Resumen del proyecto
                    proyecto.fecha_pres?.ToString("yyyy-MM-dd") ?? "Sin fecha",  // Fecha de presentación (formateada a yyyy-MM-dd), si no tiene fecha, "Sin fecha"
                    proyecto.logo,                                  // Logo del proyecto
                    proyecto.memoria,                               // Memoria del proyecto
                    proyecto.archivos,                              // Archivos asociados al proyecto
                    proyecto.comentarios                            // Comentarios sobre el proyecto
                   });
                item.Tag = proyecto;
                listViewmisproyectos.Items.Add(item);
            }

         
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            proyectos = await controlProyectos.GetallbyidProyecto();
            listViewmisproyectos.Items.Clear();

            ListViewItem item;
            if (proyectos != null)
            {
                foreach (Proyecto proyecto in proyectos.results)
                {
                    item = new ListViewItem(new[]
                    {
                    proyecto.nombre,                                // Nombre del proyecto
                    proyecto.tipo,                                  // Tipo del proyecto
                    proyecto.anno_acad.ToString(),                  // Año académico (convertido a cadena)
                    proyecto.ciclo?.nombre ?? "Sin ciclo",          // Nombre del ciclo (si existe), si no "Sin ciclo"
                    proyecto.tutor?.nombre ?? "Sin tutor",          // Nombre del tutor (si existe), si no "Sin tutor"
                    proyecto.resumen,                               // Resumen del proyecto
                    proyecto.fecha_pres?.ToString("yyyy-MM-dd") ?? "Sin fecha",  // Fecha de presentación (formateada a yyyy-MM-dd), si no tiene fecha, "Sin fecha"
                    proyecto.logo,                                  // Logo del proyecto
                    proyecto.memoria,                               // Memoria del proyecto
                    proyecto.archivos,                              // Archivos asociados al proyecto
                    proyecto.comentarios                            // Comentarios sobre el proyecto
                });
                    item.Tag = proyecto;
                    listViewmisproyectos.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("No tienes proyectos asignados");
            }
        }

    }
    }
    
    
    

