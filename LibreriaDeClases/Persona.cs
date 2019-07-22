namespace LibreriaDeClases
{
    public class Persona : Base
    {
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int IdComuna { get; set; }


        public Persona(int identificador, string nombre, bool activo, string apellido, string direccion, int idComuna)
            : base(identificador, nombre, activo)
        {
            Apellido = apellido;
            Direccion = direccion;
            this.IdComuna = idComuna;
        }
    }
}
