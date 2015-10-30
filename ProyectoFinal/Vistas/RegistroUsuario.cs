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
    public partial class RegistroUsuario : Form
    {
        RegistroUsuarios reg = new RegistroUsuarios();
        public RegistroUsuario()
        {
            InitializeComponent();
           
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            reg.Nombre = NombretextBox.Text;
            reg.Apellido = ApellidotextBox.Text;
            reg.Telefono = TelefonotextBox.Text;
            reg.Direccion = DirecciontextBox.Text;
          
            reg.Cedula = CedulatextBox.Text;
         
            int n = 0;
            if (FemradioButton.Checked == true)
            {
                n = 1;
            }
            if (MascradioButton.Checked == true)
            {
                n = 2;
            }

            reg.sexo = n;

            reg.Clave = ClavetextBox.Text;

            reg.Insertar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminar = new EliminarUsuario();
            eliminar.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
