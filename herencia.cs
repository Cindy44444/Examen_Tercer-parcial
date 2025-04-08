using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tercer_parcial
{
    internal class herencia : Consola
    {
        public herencia() { }

        public herencia(int iD, string nombre, DateTime fechaRegistro, bool activo, string colorinterfaz, string dato2, string dato3)
            : base(iD, nombre, fechaRegistro, activo)
        {
            ColorInterfaz = colorinterfaz;
            Dato2 = dato2;
            Dato3 = dato3;
        }

        public string ColorInterfaz { get; set; }
        public string Dato2 { get; set; }
        public string Dato3 { get; set; }
    }
}
