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
            Console.WriteLine(tempClient);
            Console.WriteLine(tempClient.Email);
            return tempClient;
        }

        public static void ShowClient(Client client) 
        {
            Console.WriteLine($" ID: {client.ID} | Nombre: {client.Name} | Apellido: {client.LastName} | Direccion: {client.Adress} | Email: {client.Email}");
        }
    }
}
