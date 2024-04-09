using Microsoft.EntityFrameworkCore;
using HHPW_BE.Models;

namespace HHPW_BE
{
    public class HHPWDbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Item>? Items { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }

      
    }
}
