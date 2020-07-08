using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIExample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DIExample.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Hello from ProductController");
            var products = _productService.GetAllProducts();
            return View(products);
        }
    }
}
