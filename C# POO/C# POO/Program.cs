using System;

namespace C__POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda miAgenda = new Agenda();

            while (true)
            {

                //Menu de opciones 
                Console.WriteLine("Seleccion una opcion");
                Console.WriteLine("1. Agregar un nuevo contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Salir");
                string respuesta = Console.ReadLine();
                switch (respuesta)
                {
                    case "1":
                        Console.WriteLine("Ingrese un nuevo contacto");
                        
                        Console.Write("Ingrese nombre: ");
                        string nombre = Console.ReadLine();
                        
                        Console.Write("Ingrese telefono: ");
                        string telefono = Console.ReadLine();
                        
                        Console.Write("Ingrese direccion: ");
                        string direccion = Console.ReadLine();
                        
                        miAgenda.AgregarContacto(nombre, telefono, direccion);
                        break;
                    case "2":
                        miAgenda.MostrarContactos();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
    }
}
