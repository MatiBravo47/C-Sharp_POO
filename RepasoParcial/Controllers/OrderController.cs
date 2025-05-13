using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Models;
using Controllers;
using System.IO;
using Views;

namespace Controllers
{
    public class OrderController
    {
        private ClientController cController;
        private ProductController pController;
        private List<Order> orderList = new List<Order>();

        public OrderController() 
        {
            this.cController = new ClientController();
            this.pController = new ProductController();
            this.orderList = Repository<Order>.ObtenerTodos(Path.Combine("Repository", "Data", "Ordenes"));
        }



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
            var tempOrder = new Order();
            tempOrder.client = cController.LoadClient();

        }
        public void ShowAllOrders() { }
        public void DeleteOrderByClientID(string clientID) { }
        public void UpdateClientByID(string clientID, Client nuevoCliente) { }
    }
}
