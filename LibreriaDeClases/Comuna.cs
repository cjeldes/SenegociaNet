namespace LibreriaDeClases
{
    public class Comuna : Base
    {
        public int IdRegion { get; set; }

        public Comuna(int identificador, string nombre, bool activo, int idRegion)
            : base(identificador, nombre, activo)
        {
            IdRegion = idRegion;
        }

    }
}
