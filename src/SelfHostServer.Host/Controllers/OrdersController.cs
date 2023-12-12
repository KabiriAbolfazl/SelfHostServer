using SelfHostServer.Host.Data.DbContext;
using SelfHostServer.Host.Models.Orders;
using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly ApplicationDbContext _context;
        public OrdersController()
        {
            _context = new ApplicationDbContext();
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders;
        }
    }
}
