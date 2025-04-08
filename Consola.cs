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

        public Consola(int iD, string nombre, DateTime fechaRegistro, bool activo)
        {
            ID = iD;
            Nombre = nombre;
            FechaRegistro = fechaRegistro;
            this.activo = activo;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro {  get; set; }
        public bool activo { get; set; }

    }
}
