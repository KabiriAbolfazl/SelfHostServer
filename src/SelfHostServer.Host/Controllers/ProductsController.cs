using SelfHostServer.Host.Models.Products;
using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1,Name="Galaxy S23 Ultra",Price=50},
            new Product { Id = 2,Name="Hp pavilion",Price=80},
            new Product { Id = 3,Name=".Net Mastery",Price=10}
        };

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
    }
}
