using SelfHostServer.Host.Models.Orders;
using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host.Controllers
{
    public class OrdersController : ApiController
    {
        Order[] orders = new Order[]
        {
            new Order { Id = 1,Name="Sara",Category="Mobile",Price=50},
            new Order { Id = 2,Name="Ali",Category="Laptop",Price=80},
            new Order { Id = 3,Name="Nabi",Category="Learning",Price=10}
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }
    }
}
