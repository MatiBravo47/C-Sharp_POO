using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Models;

namespace Controllers
{
    public class OrderController
    {
        private List<Order> orderList = new List<Order>();

        public void LoadOrders() 
        {
            orderList = Repository<Order>.ObtenerTodos("ordenes");
        }

        public void SaveOrders() 
        {
            foreach (var orden in orderList) 
            {
                Repository<Order>.Agregar("ordenes", orden);
            }
        }

        // Metodos a completar 
        public void CreateOrder() 
        {
            var temp = new Order 
            {
                client = 
            }
        }
        public void ShowAllOrders() { }
        public void DeleteOrderByClientID(string clientID) { }
        public void UpdateClientByID(string clientID, Client nuevoCliente) { }
    }
}
