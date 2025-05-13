using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ClientController
    {
        public ClientController() { }

        public ClientController LoadClient() 
        {
            Console.WriteLine("Cargando clientes");
            return OrderView.LoadOrder();
        }


    }
}
