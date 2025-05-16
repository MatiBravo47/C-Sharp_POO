using System;
using Controllers;

namespace RepasoParcial
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Sistema de gestion de ordenes - Beta";
            OrderController controller = new OrderController();

            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Crear nueva orden");
                Console.WriteLine("2. Mostrar todas las órdenes");
                Console.WriteLine("3. Eliminar orden por ID de cliente");
                Console.WriteLine("4. Actualizar cliente en una orden");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            controller.CreateOrder();
                            break;
                        case 2:
                            controller.ShowAllOrders();
                            Console.ReadKey();
                            break;
                        case 3:
                            controller.DeleteOrderByClientID();
                            Console.ReadKey();
                            break;
                        case 4:
                            controller.DeleteOrderByClientID();
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    opcion = 1; Console.ReadKey();
                }
            } while (opcion != 0);
        }
    }
}