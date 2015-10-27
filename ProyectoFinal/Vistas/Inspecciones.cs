using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas
{
    public partial class Inspecciones : Form
    {
        public Inspecciones()
        {
            InitializeComponent();
        }

        private void Inspecciones_Load(object sender, EventArgs e)
        {

        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            ConsultarInspeccion ci = new ConsultarInspeccion();
            ci.Show();
        }
    }
}
