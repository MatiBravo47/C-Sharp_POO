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
        private List<Product> _products;

        public ProductController()
        {
            _products = new List<Product>();
        }

        // Método para agregar un producto a la lista
        public void AddProduct() 
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Adding a new product");
            Console.ResetColor();

            Product product = ProductView.LoadProduct();
            _products.Add(product);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Product added successfully");
            Console.ResetColor();
        }

        public void ShowAllProducts()
        {
            Console.Clear();
            if (_products.Count == 0)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Empty product list.");
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Showing all products:");
            ProductView.ShowProductList(_products); // Mostrar la lista de productos usando la vista
        }

        public void UpdateProduct()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the name of the product to update");
            Console.ResetColor();
            string name = Console.ReadLine();

            Product product = _products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (product == null)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Product not found");
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Updating product");
            Product updatedProduct = ProductView.LoadProduct();
            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Desc = updatedProduct.Desc;
            
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Product updated successfully");
            Console.ResetColor();
        }

        public void DeleteProduct()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the name of the product to delete");
            Console.ResetColor();
            string name = Console.ReadLine();

            Product product = _products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (product == null)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Product not found");
                Console.ResetColor();
                return;
            }

            _products.Remove(product);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Product deleted");
            Console.ResetColor();
        }
    }
}
