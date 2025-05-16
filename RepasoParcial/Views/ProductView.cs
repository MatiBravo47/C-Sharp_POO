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

            Console.Write("Nombre producto: ");
            tempProduct.Name = Console.ReadLine();
            
            Console.Write("Precio: ");
            tempProduct.Price = double.Parse(Console.ReadLine());
            
            Console.Write("Descripcion: ");
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
                Console.Write("Desea agregar otro producto(S/N)");
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
            Console.WriteLine($"{product.Name} -${product.Price} ({product.Desc}) ");
        }
    }
}
