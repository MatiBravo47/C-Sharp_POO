﻿namespace Models
{
    public class Product
    {
        public string Name { get; set; } 
        public double Price { get; set; }
        public string Desc { get; set; }

        public Product() { }

        public Product(string name, double price, string desc) 
        {
            Name = name;
            Price = price;
            Desc = desc;
        }

        public double FinalPrice() 
        {
            return Price * 1.21;
        }
    }
}
