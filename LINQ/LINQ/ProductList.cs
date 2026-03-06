using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ProductList
    {
        public static readonly List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 10,
                Name = "Õun",
                Category = "Puuvili",
                Price = 1,
                Amount = 7,
            },

            new Product()
            {
                Id = 2,
                Name = "Piim",
                Category = "Dairy",
                Price = 3,
                Amount = 5,
            },

            new Product()
            {
                Id = 3,
                Name = "Sai",
                Category = "Dairy",
                Price = 3,
                Amount = 1,
            },

            new Product()
            {
                Id = 4,
                Name = "Vesi",
                Category = "Jook",
                Price = 1,
                Amount = 1,
            },

            new Product()
            {
                Id = 5,
                Name = "Kala",
                Category = "Liha",
                Price = 25,
                Amount = 3,
            },

            new Product()
            {
                Id = 6,
                Name = "Kana",
                Category = "Liha",
                Price = 150,
                Amount = 1,
            },

            new Product()
            {
                Id = 7,
                Name = "Tee",
                Category = "Jook",
                Price = 5,
                Amount = 10,
            },

            new Product()
            {
                Id = 8,
                Name = "Keefir",
                Category = "Dairy",
                Price = 2,
                Amount = 4,
            },

            new Product()
            {
                Id = 9,
                Name = "Friikartulid",
                Category = "Köögivili",
                Price = 4,
                Amount = 5,
            },

            new Product()
            {
                Id = 10,
                Name = "Ferrari La Ferrari",
                Category = "Auto",
                Price = 5000000,
                Amount = 1,
            },
        };
    }
}
