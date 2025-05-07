using System;
using Models;

namespace Views
{
    public static class ClientView
    {
        public static void ShowClient(Client client)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Nombre cliente: {client.Name}");
            Console.WriteLine($"Apellido cliente: {client.LastName}");
            Console.WriteLine($"ID cliente: {client.ID}");
            Console.WriteLine($"Direccion cliente: {client.Adress}");
            Console.WriteLine($"Email cliente: {client.Email}");
            Console.WriteLine("-----------------------");
        }

        public static Client LoadClient()
        {
            Console.WriteLine("Nombre cliente: ");
            string name = Console.ReadLine();
            Console.WriteLine("Apellido cliente: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("ID cliente: ");
            string id = Console.ReadLine();
            Console.WriteLine("Direccion cliente: ");
            string adress = Console.ReadLine();
            Console.WriteLine("Email client: ");
            string email = Console.ReadLine();

            Client temp = new Client(name, lastName, id, adress, email);

            return temp;
        }
    }
}
