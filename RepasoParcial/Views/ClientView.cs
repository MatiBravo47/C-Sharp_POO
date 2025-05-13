using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public static class ClientView
    {
        public static Client LoadClient() 
        {
            //string name, string lastname, string id, string adress, string email) 
            Client tempClient = new Client();
            Console.WriteLine("Nombre:");
            tempClient.Name = Console.ReadLine();

            Console.WriteLine("Apellido:");
            tempClient.LastName = Console.ReadLine();

            Console.WriteLine("ID:");
            tempClient.ID = Console.ReadLine();

            Console.WriteLine("Direccion:");
            tempClient.Adress = Console.ReadLine();

            Console.WriteLine("Email:");
            tempClient.Email = Console.ReadLine();

            return tempClient;
        }

        public static void ShowClient(Client client) 
        {
            Console.WriteLine($"Nombre: {client.Name}");
            Console.WriteLine($"Nombre: {client.LastName}");
            Console.WriteLine($"Nombre: {client.ID}");
            Console.WriteLine($"Nombre: {client.Adress}");
            Console.WriteLine($"Nombre: {client.Email}");
        }
    }
}
