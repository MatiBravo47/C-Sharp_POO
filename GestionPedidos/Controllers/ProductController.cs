using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;
using Models;

namespace Controllers
{
    public class ProductController
    {

        private List<Product> _products;

        public ProductController()
        {
            _products = new List<Product>();
        }

        // Método para agregar un producto a la lista
        public void AddProduct() 
        {
            Console.WriteLine("Agregando un nuevo producto");
            Product product = ProductView.LoadProduct();
            _products.Add(product);
            Console.WriteLine("Producto agregado exitosamente");
        }

        public void ShowAllProducts()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine("No hay productos en la lista.");
                return;
            }

            Console.WriteLine("Mostrando todos los productos:");
            ProductView.ShowProductList(_products); // Mostrar la lista de productos usando la vista
        }
    }
}
