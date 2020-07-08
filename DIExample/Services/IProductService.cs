using System.Collections.Generic;
using DIExample.Models;

namespace DIExample.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
    }
}