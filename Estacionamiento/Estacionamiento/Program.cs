using System;

namespace Estacionamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registro estacionamiento = new Registro();

            while (true)
            {
                estacionamiento.mostrarAutos();
                Console.WriteLine("1. Agregar auto");
                Console.WriteLine("2. Eliminar auto por patente");
                Console.WriteLine("3. Eliminar auto por número");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion) 
                {
                    case "1":
                        estacionamiento.agregarAuto();
                        Console.Clear();
                        break;
                    case "2":
                        estacionamiento.eliminarAutoPorPatente();
                        Console.Clear();
                        break;
                    case "3":
                        estacionamiento.eliminarAutoPorNumero();
                        Console.Clear();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }
    }
}
