﻿using System;
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
    public partial class RegistrarSocios : Form
    {
        public RegistrarSocios()
        {
            InitializeComponent();
        }

        private void RegistrarSocios_Load(object sender, EventArgs e)
        {

        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            ConsultarSocios cs = new ConsultarSocios();
            cs.Show();
        }
    }
}
