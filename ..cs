﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tercer_parcial
{
    //Ultimo cambio para ver si si se guardo
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
            catch (Exception )
            {
                return false;
            }
        }
        public bool Bajas (int ID)
        {
            try
            {
                var objetobaja = listaHerencia.Find(x => x.ID == ID);
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
            catch (Exception )
            {
                return false;
            }
        }
        public bool cambios(int iD, string nombre, DateTime fechaRegistro, bool activo, string colorinterfaz, string dato2)
        {
            try
            {
                var objetoCambio = listaHerencia.Find(x => x.ID == iD);
                objetoCambio.ID = iD;
                objetoCambio.Nombre = nombre;
                objetoCambio.FechaRegistro = fechaRegistro;
                objetoCambio.activo = activo;
                objetoCambio.ColorInterfaz = colorinterfaz;
                objetoCambio.Dato2 = dato2;
                if (objetoCambio != null)
                {
                    listaHerencia.Remove(objetoCambio);
                    return true;
                }
                return false;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool agregar(int iD, string nombre, DateTime fechaRegistro, bool activo, string colorinterfaz, string dato2)
        {
            try
            {
                listaHerencia.Add(new herencia(a.ID = iD, a.Nombre = nombre, a.FechaRegistro = fechaRegistro, a.activo = activo, a.ColorInterfaz = colorinterfaz, a.Dato2 = dato2));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
