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
            new herencia ("clave", "name 1","edad","1","2","3"),
            new herencia ("clave", "name 2","edad","1","2","3"),
            new herencia ("clave", "name 3","edad","1","2","3"),
            new herencia ("clave", "name 4","edad","1","2","3"),
            new herencia ("clave", "name 5","edad","1","2","3"),
        };
        herencia a = new herencia();
        public List<herencia> MostrarHerencia()
        {
            return listaHerencia;
        }
    }
}
