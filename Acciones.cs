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
            new herencia (3467, "name 1",01/04/2022,"si","azul","nose"),
            new herencia (5987, "name 2",01/06/2022,"si","verde", "vivo"),
            new herencia (4017, "name 3",09/06/2022,"no", "morado", "muero"),
            new herencia (4028, "name 4",10/07/2022,"si","cafe", "vivo"),
            new herencia (1892, "name 5",25/07/2022,"no","amarillo", "muerto"),
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
