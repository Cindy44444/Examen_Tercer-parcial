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
            new herencia (3467, "name 1",DateTime.Today,true,"azul","nose"),
        };
        herencia a = new herencia();
        public List<herencia> Consultas()
        {
            return listaHerencia;
        }
        public bool Altas(int iD, string nombre, DateTime fechaRegistro, bool activo, string colorinterfaz, string dato2)
        {
            try
            {
                listaHerencia.Add(new herencia(a.ID = iD, a.Nombre = nombre, a.FechaRegistro = fechaRegistro, a.activo = activo, a.ColorInterfaz = colorinterfaz, a.Dato2 = dato2));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Bajas (string Nombre)
        {
            try
            {
                var objetobaja = listaHerencia.Find(x => x.Nombre == Nombre);
                if (objetobaja != null)
                {
                    listaHerencia.Remove(objetobaja);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool cambios(int iD, string nombre, DateTime fechaRegistro, bool activo, string colorinterfaz, string dato2)
        {
            try
            {
                var objetoCambio = listaHerencia.Find(x => x.ID == iD);
                if (objetoCambio != null)
                {
                    listaHerencia.Remove(objetoCambio);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
