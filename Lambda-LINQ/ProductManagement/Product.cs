using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lambda.ProductManagement
{
    // product class
    public class Product
    {
        public string? Name;
        public string? Category;
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Product price cannot be negative.");
                    return;
                }
                price = value;
            }
        }
    }
}