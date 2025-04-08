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
    public partial class frmlogin : Form
    {
        Usuarios usuarios = new Usuarios();
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContrasenia.Text;

            var lista = usuarios.ObtenerUsuarios();
            var valider = lista.FirstOrDefault(u => u.NuevoUsuario == user && u.Contrasenia == password);

            if (valider != null)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("FALLASTE");
            }
        }
    }
}
