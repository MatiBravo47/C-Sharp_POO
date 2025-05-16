using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
