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

        public herencia(string iD, string nombre, string fechaRegistro, string dato1, string dato2, string dato3)
            : base(iD, nombre, fechaRegistro)
        {
            Dato1 = dato1;
            Dato2 = dato2;
            Dato3 = dato3;
        }

        public string Dato1 { get; set; }
        public string Dato2 { get; set; }
        public string Dato3 { get; set; }
    }
}
