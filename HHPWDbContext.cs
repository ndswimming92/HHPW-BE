using Microsoft.EntityFrameworkCore;
using HHPW_BE.Models;
using HHPW_BE.Data;

namespace HHPW_BE
{
    public class HHPWDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Item>? Items { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }

        public HHPWDbContext(DbContextOptions<HHPWDbContext> context) : base(context)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(UsersData.Users);
            modelBuilder.Entity<Item>().HasData(ItemsData.Items);
            modelBuilder.Entity<Order>().HasData(OrdersData.Orders);
        }

    }
}
