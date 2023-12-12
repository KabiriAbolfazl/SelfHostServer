using SelfHostServer.Host.Models.Orders;
using SelfHostServer.Host.Models.Products;
using System.Collections.Generic;

namespace SelfHostServer.Host.Data.DbContext
{
    public class ApplicationDbContext
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public ApplicationDbContext()
        {
            Orders = new List<Order>()
            {
                 new Order { Id = 1,Name="Sara",Category="Mobile",Price=50},
                 new Order { Id = 2,Name="Ali",Category="Laptop",Price=80},
                 new Order { Id = 3,Name="Nabi",Category="Learning",Price=10}
            };

            Products = new List<Product>()
            {
                new Product { Id = 1,Name="Galaxy S23 Ultra",Price=50},
                new Product { Id = 2,Name="Hp pavilion",Price=80},
                new Product { Id = 3,Name=".Net Mastery",Price=10}
            };
        }
    }
}
