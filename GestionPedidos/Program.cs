using System;
using Controllers;

namespace SistemaDePedidos
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductController productController = new ProductController();
            ClientController clientController = new ClientController();
            bool running = true;
            while (running)
            {
                Console.WriteLine("Menu de productos");
                Console.WriteLine("1. Agregar productos");
                Console.WriteLine("2. Mostrar todos los productos");
                Console.WriteLine("3. Agregar clientes");
                Console.WriteLine("4. Mostrar todos los clientes");
                Console.WriteLine("5. Salir");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        productController.AddProduct();
                        break;
                    case 2:
                        productController.ShowAllProducts();
                        break;
                    case 3:
                        clientController.AddClient();
                        break;
                    case 4:
                        clientController.ShowAllClients();
                        break;
                    case 5:
                        running = false;
                        break; 
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            }
        }
    }
}
