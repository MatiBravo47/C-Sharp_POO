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
            cController = new ClientController();
            pController = new ProductController();
            CargarOrdenes();
        }

        private void CargarOrdenes() 
        {
            orderList = Repository<Order>.ObtenerTodos(Path.Combine("Repository", "Data", "ordenes"));
        }

        private void GuardarOrdenes() 
        {
            Repository<Order>.GuardarLista(Path.Combine("Repository", "Data", "ordenes"), orderList);
        }


        // Metodos a completar 
        public void CreateOrder()
        {
            var cliente = cController.LoadClient();
            if (cliente == null)
            {
                OrderView.showMsg("Error No se puede crear la orden: Cliente invalido");
                return;
            }
            var productos = pController.LoadProductList();
            {
                if (productos == null || productos.Count == 0)
                {
                    OrderView.showMsg("Error No se puede crear la orden: Cliente invalido");
                    return;
                }
            }
            Order nuevaOrden = new Order();
            nuevaOrden.client = cliente;
            nuevaOrden.productList = productos;
            orderList.Add(nuevaOrden);
            GuardarOrdenes();

            OrderView.showMsg("Orden creada y guardada con exito");
            
        }
        public void ShowAllOrders() 
        {
            if (orderList.Count == 0)
            {
                OrderView.showMsg("No hay ordenes");
            }
            int indice = 0;

            foreach (var o in orderList) 
            {
                OrderView.showMsg($"Numero de orden: {indice}");
                cController.ShowClient(o.client);
                OrderView.showMsg("Lista de productos");
                pController.ShowProductList(o.productList);
                indice++;
            }
        }
        public void DeleteOrderByClientID() 
        {
            ShowAllOrders();
            OrderView.showMsg("Ingrese un indice:");
            int index = int.Parse(Console.ReadLine());
            orderList.RemoveAt(index);
            GuardarOrdenes();
            OrderView.showMsg("Orden eliminada con exito");
        }
        public void UpdateClientByID() 
        {
            ShowAllOrders();
            OrderView.showMsg("Ingrese un indice");
            int index = int.Parse(Console.ReadLine());

            var nuevoCliente = cController.LoadClient();
            var nuevosProductos = pController.LoadProductList();

            orderList[index].client = nuevoCliente;
            orderList[index].productList = nuevosProductos;

            GuardarOrdenes() ;
        }
    }
}
