using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;
using Models;

namespace Controllers
{
    class ProductController
    {

        public ProductController()
        {
        }

        public Product LoadProduct()
        {
            Console.WriteLine("------LOADING PRODUCT------");
            return ProductView.LoadProduct();
        }


    }
}
