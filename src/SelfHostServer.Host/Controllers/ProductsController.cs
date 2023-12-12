using SelfHostServer.Host.Data.DbContext;
using SelfHostServer.Host.Models.Products;
using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly ApplicationDbContext _context;
        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }
    }
}
