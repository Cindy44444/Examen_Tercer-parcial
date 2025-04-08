using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tercer_parcial
{
    internal class Usuarios
    {
        private static List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios {NuevoUsuario = "C", Contrasenia = "1234"},
            new Usuarios {NuevoUsuario = "f", Contrasenia = "amacameca"},
            new Usuarios {NuevoUsuario = "a", Contrasenia = "gatobanana"},
            new Usuarios {NuevoUsuario = "j", Contrasenia = "foca123"},
            new Usuarios {NuevoUsuario = "Y", Contrasenia = "Lbcd"}
        };
        public Usuarios() { }
        public List<Usuarios> ObtenerUsuarios ()
        {
            return usuarios;
        }
        public string NuevoUsuario { get; set; }
        public string Contrasenia { get; set; }
    }
}
