using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;
using Models;

namespace Controllers
{
    class ClientController
    {
        private List<Client> _clients; 

        public ClientController()
        {
            _clients = new List<Client>();
        }

        //Agrega cliente a la lista clientes
        public void AddClient()
        {
            Console.WriteLine("Agregando un cliente");
            Client client = ClientView.LoadClient();
            _clients.Add(client);
            Console.WriteLine("Cliente agregado a la lista");
        }

        public void ShowAllClients() 
        {
            if (_clients.Count() == 0)
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            else 
            {
                foreach (Client client in _clients)
                {
                    ClientView.ShowClient(client);
                }
            }
        }


    }
}
