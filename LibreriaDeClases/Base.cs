using System;

namespace LibreriaDeClases
{
    public class Base
    {
        public int Identificador { get; set; }
        public string Nombre { get; set; }
        public Boolean Activo { get; set; }


        public Base(int identificador, string nombre, bool activo)
        {
        
            Identificador = identificador;
            Nombre = nombre;
            Activo = activo;
        }

    }
}
