using System;
using Controllers;
using System.Threading;
using System.ComponentModel.Design;

namespace SistemaDePedidos
{
    class Program
    {
        static void Main(string[] args) 
        {
            Menu();
        }
        static void Menu()
        {
            OrderController oController = new OrderController();
            
            bool salida = false;
            do
            {
                int input = 0;
                Console.WriteLine("Ingrese una opcion");
                Console.WriteLine("1: Cargar pedido");
                Console.WriteLine("2: Mostrar pedido");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        oController.CreateOrder();
                        break;
                    case 2:
                        oController.ShowOrders();
                        break;
                    default:
                        Console.WriteLine("Error, ingrese otra opcion");
                        break;
                }
            } while (!salida);
        }
    }
}
