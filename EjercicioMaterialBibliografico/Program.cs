using System;
using Clases;

namespace EjercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {
            MaterialBibliografico materialB = new MaterialBibliografico();

            while (true)
            {
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Eliminar libros");
                Console.WriteLine("3. Mostrar libros");
                Console.WriteLine("4. Agregar ebook");
                Console.WriteLine("5. Eliminar ebook");
                Console.WriteLine("6. Mostrar ebooks");
                Console.WriteLine("7. Salir");
                string respuesta = Console.ReadLine();
                Console.Clear();
                switch (respuesta)
                {
                    case "1":
                        materialB.agregarLibro();
                        break;
                    case "2":
                        materialB.eliminarLibro();
                        break;
                    case "3":
                        Console.WriteLine("Libros almacenados: ");
                        materialB.mostrarLibros();
                        break;
                    case "4":
                        materialB.agregarEbook();
                        break;
                    case "5":
                        materialB.eliminarEbook();
                        break;
                    case "6":
                        Console.WriteLine("Ebooks almacenados: ");
                        materialB.mostrarEbooks();
                        break;
                    case "7":
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }
}
