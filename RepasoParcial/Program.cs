using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;

namespace RepasoParcial
{
    class Program
    {
        static void Main()
        {
            OrderController controller = new OrderController();

            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Crear nueva orden");
                Console.WriteLine("2. Mostrar todas las órdenes");
                Console.WriteLine("3. Eliminar orden por ID de cliente");
                Console.WriteLine("4. Actualizar cliente en una orden");
                Console.WriteLine("5. Salir");
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
                            //Lógica
                            break;
                        case 3:
                            //Lógica
                            break;
                        case 4:
                            //Lógica
                            break;
                        case 5:
                            return;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");
                    opcion = 1; Console.ReadKey();
                }
            } while (opcion != 0);
        }
    }
}