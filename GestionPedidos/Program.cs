using System;
using Controllers;
using System.Threading;

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

                Console.WriteLine("Products menu");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Show all products");
                Console.WriteLine("3. Update product");
                Console.WriteLine("4. Delete product");
                Console.WriteLine("5. Add client");
                Console.WriteLine("6. Show all clients");
                Console.WriteLine("7. Exit");
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
                        productController.UpdateProduct();
                        break;
                    case 4:
                        productController.DeleteProduct();
                        break;
                    case 5:
                        clientController.AddClient();
                        break;
                    case 6:
                        clientController.ShowAllClients();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Exiting...");
                        Console.ResetColor();
                        Thread.Sleep(3000); // Pausa de 3 segundos
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect answer");
                        break;
                }
            }
        }
    }
}
