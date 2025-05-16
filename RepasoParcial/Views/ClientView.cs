using System;
using System.Collections.Generic;
using Models;

namespace Views
{
    public static class ClientView
    {
        public static Client LoadClient() 
        { 
            Client tempClient = new Client();
            
            Console.Write("Nombre:");
            tempClient.Name = Console.ReadLine();

            Console.Write("Apellido:");
            tempClient.LastName = Console.ReadLine();

            Console.Write("ID:");
            tempClient.ID = Console.ReadLine();

            Console.Write("Direccion:");
            tempClient.Adress = Console.ReadLine();

            Console.Write("Email:");
            tempClient.Email = Console.ReadLine();
            
            return tempClient;
        }

        public static void ShowClient(Client client) 
        {
            Console.WriteLine($" ID: {client.ID} | Nombre: {client.Name} | Apellido: {client.LastName} | Direccion: {client.Adress} | Email: {client.Email}");
        }
    }
}
