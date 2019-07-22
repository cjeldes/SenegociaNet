using Controlador;
using LibreriaDeClases;
using System;
namespace App
{
    public class Menu
    {
        public Ctrl ctrl { get; set; }

        public Menu()
        {
            ctrl = new Ctrl();
        }
        public void mostrarMenu()
        {
            int op = 0;
            string entrada;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1.- Listar Personas");
                Console.WriteLine("2.- Listar Comunas");
                Console.WriteLine("3.- Listar Regiones");
                Console.WriteLine("0.- SALIR");
                do
                {
                    Console.WriteLine("Ingrese su opcion");
                    entrada = Console.ReadLine();
                } while (!int.TryParse(entrada, out op));
                switch (op)
                {
                    case 1:
                        listarPersonas();
                        break;
                    case 2:
                        listarComunas();
                        break;
                    case 3:
                        listarRegiones();
                        break;
                    default:
                        break;
                }
            } while (op != 0);
        }

        // Metodo que retorna una lista de personas y sus atributos
        private void listarPersonas()
        {
            Console.WriteLine("******************************************");
            foreach (Persona tmp in ctrl.listarPersonas())
            {
                Console.WriteLine("[ID: " + tmp.Identificador + ", Nombre: " + tmp.Nombre + ", Apellido: "
                        + tmp.Apellido + ", Direccion: " + tmp.Direccion + ", Comuna: "
                        + buscaNombreComuna(tmp.IdComuna) + ", Region: " + buscaNombreRegion(buscaIDRegion(tmp.IdComuna))
                        + ", ¿Activo?: " + tmp.Activo + "]");
            }
            Console.WriteLine("******************************************");
        }

        // Metodo que retorna una lista de comunas y sus atributos
        private void listarComunas()
        {
            Console.WriteLine("******************************************");
            foreach (Comuna tmp in ctrl.listarComunas())
            {
                Console.WriteLine("[ID: " + tmp.Identificador + ", Nombre: " + tmp.Nombre + ", Region: "
                        + buscaNombreRegion(tmp.IdRegion) + ", ¿Activo?: " + tmp.Activo + "]");
            }
            Console.WriteLine("******************************************");
        }

        // Metodo que retorna nombre de una comuna al ingresar el identificador de la
        // comuna
        private String buscaNombreComuna(int idComuna)
        {
            return ctrl.buscarComuna(idComuna).Nombre;
        }

        // Metodo que retorna un listado de regiones y sus atributos
        private void listarRegiones()
        {
            Console.WriteLine("******************************************");
            foreach (Region tmp in ctrl.listarRegiones())
            {
                Console.WriteLine("[ID: " + tmp.Identificador + ", Nombre: " + tmp.Nombre + ", ¿Activo?: "
                        + tmp.Activo + "]");
            }
            Console.WriteLine("******************************************");
        }

        // Metodo que retorna identificador de una region al ingresar el identicador de
        // una comuna
        private int buscaIDRegion(int idComuna)
        {
            return ctrl.buscarComuna(idComuna).IdRegion;
        }

        // Metodo que retorna nombre de region al ingresar identificador de la region
        private String buscaNombreRegion(int idRegion)
        {
            return ctrl.buscarRegion(idRegion).Nombre;
        }

    }
}
