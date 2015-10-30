using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace ProyectoFinal.Vistas
{
    public partial class EliminarUsuario : Form
    {
        RegistroUsuarios registro = new RegistroUsuarios();
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            registro.Clave = ClavetextBox.Text;

            registro.Eliminar();
        }
    }
}
