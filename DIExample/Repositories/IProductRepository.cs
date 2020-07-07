using System.Collections.Generic;
using DIExample.Models;

namespace DIExample.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}