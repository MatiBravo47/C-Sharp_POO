using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public Client client { get; set; }
        private List<Product> productList = new List<Product>();

        public double CalculateTotalIVA() 
        {
            return productList.Sum(item => item.FinalPrice());
        }

        public double CalculateTotal() 
        {
            return productList.Sum(item => item.Price);
        }

        public List<Product> getProductList() => productList;
        public void setProductList(List<Product> list) => productList = list;
    }
}
