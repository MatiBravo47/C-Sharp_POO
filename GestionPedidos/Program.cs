using System;
using Controllers;

namespace SistemaDePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductController productController = new ProductController();
            productController.CreateAndShowProduct();
            Console.ReadLine();
        }
    }
}
