﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Tercer_parcial
{
    public partial class Inicio : Form
    {
        Acciones ACC = new Acciones();
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dGVlatablita.DataSource = null;
            dGVlatablita.DataSource = ACC.Consultas();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (ACC.cambios(txbID.ResetText(Convert.ToInt16), txbNombre.Text, txbFecha.Text, txbActivo.Text, txbcolor.Text, txbdato2vivo.Text))
            {
                MessageBox.Show("Cambio exitoso");
            }
            else
            {
                MessageBox.Show("Fallo");
            }
        }
    }
}
