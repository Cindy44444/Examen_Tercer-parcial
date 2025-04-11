using System;
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
            int ID = Convert.ToInt32(txbID.Text);
            DateTime fecha = Convert.ToDateTime(txbFecha.Text);
            bool activo = Convert.ToBoolean(txbActivo.Text);

            if (ACC.cambios(ID, txbNombre.Text, fecha, activo, txbcolor.Text, txbdato2vivo.Text))
            {
                MessageBox.Show("Cambio exitoso");
            }
            else
            {
                MessageBox.Show("Fallo");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbNombre.Text = "";
            txbFecha.Text = "";
            txbActivo.Text = "";
            txbcolor.Text = "";
            txbdato2vivo.Text = "";
            txbEliminar.Text = "";


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txbID.Text);
            DateTime fecha = Convert.ToDateTime(txbFecha.Text);
            bool activo = Convert.ToBoolean(txbActivo.Text);

            if (ACC.agregar(ID, txbNombre.Text, fecha, activo, txbcolor.Text, txbdato2vivo.Text))
            {
                MessageBox.Show("Agregado con exito");
            }
            else
            {
                MessageBox.Show("Fallo");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txbEliminar.Text);
            if (ACC.Bajas(ID))
            {
                MessageBox.Show("Eliminado con exito");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
