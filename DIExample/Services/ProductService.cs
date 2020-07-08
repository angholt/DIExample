using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIExample.Models;
using DIExample.Repositories;

namespace DIExample.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            //Some business logic here

            return _productRepository.GetProducts();
        }
    }
}
