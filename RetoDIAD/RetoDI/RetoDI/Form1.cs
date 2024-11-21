using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoDI
{
    public partial class frmLogin : System.Windows.Forms.Form
    {
        public frmLogin()
        {
            InitializeComponent();
            try
            {
                Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
                this.BackgroundImage = img;
            }
            catch (Exception ex) { }
            
        }

       
    }
}
