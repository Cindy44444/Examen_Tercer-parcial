using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tercer_parcial
{
    internal class principal
    {
        public principal() { }

        public principal(string clave, string nombre, string edad)
        {
            Clave = clave;
            Nombre = nombre;
            Edad = edad;
        }

        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Edad {  get; set; }

    }
}
