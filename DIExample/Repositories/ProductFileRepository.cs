using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIExample.Models;

namespace DIExample.Repositories
{
    public class ProductFileRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            var products = System.IO.File.ReadAllLines("Products.txt");
            return products.Select(p => new Product
            {
                Name = p
            });
        }
    }
}
