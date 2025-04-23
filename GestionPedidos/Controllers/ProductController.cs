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
        /*
        public ProductController()
        {
        }

        public Product LoadProduct()
        {
            Console.WriteLine("------LOADING PRODUCT------");
            return ProductView.LoadProduct();
        }
        */

        public void CreateAndShowProduct()
        {
            Product product = new Product("Smartphone", 799.99, "Un teléfono inteligente de última generación");
            ProductView.ShowProduct(product)
        }
    }
}
