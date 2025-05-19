using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Order
    {
        public Client client { get; set; }
        public List<Product> productList { get; set; } = new List<Product>();

        public double CalculateTotalIVA() 
        {
            return productList.Sum(item => item.FinalPrice());
        }

        public double CalculateTotal() 
        {
            return productList.Sum(item => item.Price);
        }
    }
}
