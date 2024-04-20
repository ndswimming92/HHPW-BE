using HHPW_BE.Models;

namespace HHPW_BE.Data
{
    public class OrdersData
    {
        public static List<Order> Orders = new List<Order>()
        {
            new Order() { Id = 1, Name = "Alice Brown", Status = true, Phone = "111-222-3333", Email = "alice@example.com", OrderType = "Dine-in", PaymentType = "Debit Card", Total = 12, Tip = 03M, Date = DateTime.Now.AddDays(-2) },
            new Order() { Id = 2, Name = "Bob Green", Status = false, Phone = "444-555-6666", Email = "bob@example.com", OrderType = "Pickup", PaymentType = "Cash", Total = 5, Tip = 12, Date =  DateTime.Now.AddDays(-5) },
            new Order() { Id = 3, Name = "Charlie White", Status = false, Phone = "777-888-9999", Email = "charlie@example.com", OrderType = "Delivery", PaymentType = "Online", Total = 8, Tip = 1.2M, Date =  DateTime.Now.AddDays(-15) },
            new Order() { Id = 4, Name = "David Black", Status = true, Phone = "123-456-7890", Email = "david@example.com", OrderType = "Dine-in", PaymentType = "Credit Card", Total = 9, Tip = 4.4M, Date =  DateTime.Now.AddDays(-6) },
            new Order() { Id = 5, Name = "Eva Red", Status = false, Phone = "987-654-3210", Email = "eva@example.com", OrderType = "Pickup", PaymentType = "Cash", Total = 7, Tip = 12M, Date =  DateTime.Now.AddDays(-10) },
            new Order() { Id = 6, Name = "Frank Yellow", Status = false, Phone = "456-789-0123", Email = "frank@example.com", OrderType = "Delivery", PaymentType = "Online", Total = 36, Tip = 5.2M, Date =  DateTime.Now.AddDays(-9) }
        };
    }
}
