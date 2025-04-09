using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tercer_parcial
{
    internal class Acciones
    {
        List<herencia> listaHerencia = new List<herencia>
        {
            new herencia (3467, "name 1",DateTime.Today,,"azul","nose"),
        };
        herencia a = new herencia();
        public List<herencia> MostrarHerencia()
        {
            return listaHerencia;
        }
        public string Altas()
        {

        }

    }
}
