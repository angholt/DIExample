using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIExample.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DIExample.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetProducts();
            return View(products);
        }
    }
}
