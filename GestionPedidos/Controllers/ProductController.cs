using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;
using Models;
using System.Data;

namespace Controllers
{
    public class ProductController
    {

        public ProductController() { }

        // Método para agregar un producto a la lista
        public Product LoadProduct()
        {
            Console.WriteLine("-------Loading product---");
            return ProductView.LoadProduct();
        }

        public List<Product> LoadProductList()
        {
            return ProductView.LoadProductList();
        }

        public void ShowProductList(List<Product> productList)
        {
            ProductView.ShowProductList(productList);
        }
    }
}
