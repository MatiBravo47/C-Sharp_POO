using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Views;

namespace Controllers
{
    public class ProductController
    {
        public ProductController() { }

        public Product LoadProduct() 
        {
            Console.WriteLine("Cargando producto");
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
