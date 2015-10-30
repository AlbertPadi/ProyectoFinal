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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            RegistroUsuario rs = new RegistroUsuario();
            rs.Show();
        }

        private void Entrarbutton_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
        }
    }
}
