using LibreriaDeClases;
using System.Collections.Generic;

namespace Controlador
{
    public class Ctrl
    {
        public List<Region> lstRegiones;
        public List<Comuna> lstComunas;
        public List<Persona> lstPersonas;
        public Ctrl()
        {
            this.lstRegiones = new List<Region>();

            lstRegiones.Add(new Region(2, "Antofagasta", true));
            lstRegiones.Add(new Region(5, "Valparaiso", true));
            lstRegiones.Add(new Region(10, "Los Lagos", true));
            lstRegiones.Add(new Region(15, "Arica", true));

            this.lstComunas = new List<Comuna>();
            this.lstComunas.Add(new Comuna(1, "Calama", true, 2));
            this.lstComunas.Add(new Comuna(2, "Mejillones", true, 2));
            this.lstComunas.Add(new Comuna(3, "Limache", true, 5));
            this.lstComunas.Add(new Comuna(4, "Olmue", true, 5));
            this.lstComunas.Add(new Comuna(5, "Castro", true, 10));
            this.lstComunas.Add(new Comuna(6, "Putre", true, 15));

            this.lstPersonas = new List<Persona>();
            this.lstPersonas.Add(new Persona(1, "Juan", true, "Jose", "Direccion 1", 1));
            this.lstPersonas.Add(new Persona(2, "Maria", true, "Muñoz", "Direccion 2", 2));
            this.lstPersonas.Add(new Persona(3, "Pedro", true, "Perez", "Direccion 3", 3));
            this.lstPersonas.Add(new Persona(4, "Luis", true, "Pinto", "Direccion 4", 4));
            this.lstPersonas.Add(new Persona(5, "Dani", true, "Lobos", "Direccion 5", 5));
            this.lstPersonas.Add(new Persona(6, "Diego", true, "Marin", "Direccion 6", 6));
        }

        // --------------- PERSONA ---------------
        // Metodo que retorna la lista de personas ordenadas por identificador
        public List<Persona> listarPersonas()
        {
            return lstPersonas;
        }
        // --------------- COMUNA ---------------
        // Metodo que retorna la lista de comunas ordenadas por identificador
        public List<Comuna> listarComunas()
        {
            return lstComunas;
        }
        // Metodo busca una comuna por su identificador en la lista de comunas
        public Comuna buscarComuna(int idComuna)
        {
            foreach (Comuna tmp in lstComunas)
            {
                if (tmp.Identificador == idComuna)
                {
                    return tmp;
                }
            }
            return null;
        }
        // --------------- REGION ---------------
        // Metodo que retorna la lista de regiones ordenadas por identificador
        public List<Region> listarRegiones()
        {
            return lstRegiones;
        }

        // Metodo busca una region por su identificador en la lista de regiones
        public Region buscarRegion(int idRegion)
        {
            foreach (Region tmp in lstRegiones)
            {
                if (tmp.Identificador == idRegion)
                {
                    return tmp;
                }
            }
            return null;
        }
    }
}
