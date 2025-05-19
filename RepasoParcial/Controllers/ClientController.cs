using System;
using Views;
using Models;

namespace Controllers
{
    public class ClientController
    {
        public ClientController() { }

        public Client LoadClient() 
        {
            Console.WriteLine("Cargando clientes");
            return ClientView.LoadClient();
        }

        public void ShowClient(Client temp) 
        {
            ClientView.ShowClient(temp);
        }
    }
}
