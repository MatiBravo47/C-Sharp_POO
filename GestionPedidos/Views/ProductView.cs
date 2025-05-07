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
        public static void ShowProductList(List<Product> productList)
        {
            foreach (Product var in productList)
            {
                ShowProduct(var);
            }
        }
        public static void ShowProduct(Product product)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Nombre de producto: {product.Name}");
            Console.WriteLine($"Precio: {product.Price}");
            Console.WriteLine($"Precio final: {product.FinalPrice()}");
            Console.WriteLine($"Descripcion: {product.Desc}");
            Console.WriteLine("-----------------------");
        }

        public static Product LoadProduct()
        {
            Product temp = new Product();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nombre de producto: ");
            temp.Name = Console.ReadLine();
            Console.WriteLine("Precio de producto");
            temp.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Descripcion del producto");
            temp.Desc = Console.ReadLine();
            Console.WriteLine("-----------------------");

            return temp;
        }

        public static List<Product> LoadProductList() {
            string resp = "n";
            List<Product> temp = new List<Product>();
            do
            {
                temp.Add(ProductView.LoadProduct());
                Console.WriteLine("Agregar otro producto? Y/N");
                resp = Console.ReadLine();
            } while (resp.ToLower() != "n");
            return temp;
        }
    }
}
