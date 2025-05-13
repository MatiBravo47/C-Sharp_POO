using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public static class ProductView
    {
        public static Product LoadProduct() 
        {
            Product tempProduct =  new Product();

            Console.WriteLine("Producto");
            tempProduct.Name = Console.ReadLine();
            Console.WriteLine("Precio");
            tempProduct.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Descripcion");
            tempProduct.Desc = Console.ReadLine();
            
            return tempProduct;
        }

        public static List<Product> LoadProductList() 
        {
            string resp = "n";
            List<Product> tempList = new List<Product>();
            do
            {
                tempList.Add(LoadProduct());
                Console.WriteLine("Desea agregar otro producto");
                resp = Console.ReadLine();
            } while (resp.ToLower() != "n");
            return tempList;
        }

        //Muestra cada producto en la lista
        public static void ShowProductList(List<Product> productList) 
        {
            foreach (Product var in productList) 
            {
                ShowProduct(var);
            }
        }

        public static void ShowProduct(Product product) 
        {
            Console.WriteLine($"Producto: {product.Name}");
            Console.WriteLine($"Precio: {product.Price}");
            Console.WriteLine($"Descripcion: {product.Desc}");
        }
    }
}
