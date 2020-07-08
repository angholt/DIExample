using System.Collections.Generic;
using System.Linq;
using DIExample.Models;
using DIExample.Repositories;
using DIExample.Services;
using FakeItEasy;
using NUnit.Framework;

namespace DIExample.Tests
{
    public class ProductServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var productRepo = A.Fake<IProductRepository>();
            var products = new List<Product>
            {
                new Product{Name = "Desk"},
                new Product{Name = "Chair"},
                new Product{Name = "Lamp"}
            };
            
            A.CallTo(() => productRepo.GetProducts()).Returns(products);

            var productService = new ProductService(productRepo);

            var returnedProducts = productService.GetAllProducts().ToArray();

            Assert.AreEqual(3, returnedProducts.Count());
            Assert.True(returnedProducts.Any(rp => rp.Name == "Chair"));
        }
    }
}