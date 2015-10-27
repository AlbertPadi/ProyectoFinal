using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Vistas;

namespace ProyectoFinal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Lotesbutton_Click(object sender, EventArgs e)
        {
            ControlDeLotes cd = new ControlDeLotes();
            cd.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void CentrosAcpbutton_Click(object sender, EventArgs e)
        {
            CentrosDeAcopio cda = new CentrosDeAcopio();
            cda.Show();
        }

        private void Exportacionbutton_Click(object sender, EventArgs e)
        {
            Exportacion exp = new Exportacion();
            exp.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Inspeccionesbutton_Click(object sender, EventArgs e)
        {
            Inspecciones insp = new Inspecciones();
            insp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarSbutton_Click(object sender, EventArgs e)
        {
            RegistrarSocios rs = new RegistrarSocios();
            rs.Show();
        }
    }
}
