using System;
using System.Collections.Generic;
using System.IO;
using Controllers;
using Models;
using Views;
using Repository;

namespace Controllers
{
    class OrderController
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

        //Metodo para crear y guardar una orden nueva
        public void CreateOrder()
        {
            var temp = new Order
            {
                client = cController.LoadClient()
            };
            temp.setProductList(pController.LoadProductList());

            // Agrega a la lista en memoria 
            this.orderList.Add(temp);

            //Persiste usando el repositorio
            Repository<Order>.Agregar(Path.Combine("Repository", "Data", "ordenes"), temp);
            OrderView.showMsg("Orden creada y guardada correctamente");
        }

        //Mostrar todas las ordenes persistidas
        public void ShowOrders() 
        {
            if (orderList == null || orderList.Count == 0) 
            {
                OrderView.showMsg("No hay ordenes cargadas");
                return;
            }

            OrderView.showMsg("Mostrando todas las ordenes");

            foreach(Order o in orderList) 
            {
                cController.ShowClient(o.client);
                pController.ShowProductList(o.getProductList());
                Console.WriteLine($"Total sin IVA: ${ o.CalculateTotal()}");
                Console.WriteLine($"Total con IVA: ${o.CalculateTotalIVA()}");
            }
        }

        //Este metodo no es necesario si se usa en el constructor
        public void LoadOrdersFromJson() 
        {
            this.orderList = Repository<Order>.ObtenerTodos("Repository/data/ordenes");
            OrderView.showMsg("Ordenes cargadas desde JSON");
        }

        public void Test() 
        {
            var ordenes = Repository<Order>.ObtenerTodos("Repository/data/ordenes");
            foreach (var o in ordenes)
            {
                Console.WriteLine($"Cliente: {o.client.Name}");
                Console.WriteLine("Productos:");
                foreach(var p in o.getProductList())
                {
                    Console.WriteLine($"-{p.Name}: ${p.Price} | Final con IVA: ${p.FinalPrice()}");
                }
                Console.WriteLine("--------");
            }
        }


    }
}
