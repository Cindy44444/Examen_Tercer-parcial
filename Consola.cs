using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tercer_parcial
{
    internal class Consola
    {
        public Consola() { }

        public Consola(string iD, string nombre, string fechaRegistro)
        {
            ID = iD;
            Nombre = nombre;
            FechaRegistro = fechaRegistro;
        }

        public string ID { get; set; }
        public string Nombre { get; set; }
        public string FechaRegistro {  get; set; }

    }
}
