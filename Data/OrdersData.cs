using HHPW_BE.Models;

namespace HHPW_BE.Data
{
    public class OrdersData
    {
        public static List<Order> Orders = new List<Order>()
        {
            new Order() { Id = 1, Name = "Alice Brown", Status = true, Phone = "111-222-3333", Email = "alice@example.com", OrderType = "Dine-in", PaymentType = "Credit Card" },
            new Order() { Id = 2, Name = "Bob Green", Status = false, Phone = "444-555-6666", Email = "bob@example.com", OrderType = "Pickup", PaymentType = "Cash" },
            new Order() { Id = 3, Name = "Charlie White", Status = true, Phone = "777-888-9999", Email = "charlie@example.com", OrderType = "Delivery", PaymentType = "Online Payment" }
        };
    }
}
