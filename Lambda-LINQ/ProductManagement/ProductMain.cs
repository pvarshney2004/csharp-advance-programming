using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lambda.ProductManagement
{
    public class ProductMain
    {
        /*
        WAP TO use of LINQ to group a list of products by category and calculate the average price for each category. It covers concepts of grouping, aggregation, and projection using LINQ in C#.
        */
        public static void Execute()
        {
            List<Product> ll = new List<Product>
            {
                new Product { Name = "Chair", Category = "Furniture", Price = 5000 },
                new Product { Name = "Table", Category = "Furniture", Price = 8000 },

                new Product { Name = "Laptop", Category = "Electronics", Price = 60000 },
                new Product { Name = "Mobile", Category = "Electronics", Price = 30000 },
                new Product { Name = "Headphones", Category = "Electronics", Price = 2000 },

                new Product { Name = "Notebook", Category = "Stationery", Price = 100 },
                new Product { Name = "Pen", Category = "Stationery", Price = 20 }
            };

            var averagePriceByCategory = ll
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    AveragePrice = g.Average(p => p.Price)
                });

            Console.WriteLine("Average Price of Products by Category:\n");
            foreach (var item in averagePriceByCategory)
            {
                Console.WriteLine($"Category: {item.Category}");
                Console.WriteLine($"Average Price: {item.AveragePrice:F2}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}