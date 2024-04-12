using HHPW_BE.Models;

namespace HHPW_BE.Data
{
    public class ItemsData
    {
        public static List<Item> Items = new List<Item>()
        {
            new Item() { Id = 1, Name = "Four Cheese", Price = 10.99M },
            new Item() { Id = 2, Name = "Margarita", Price = 9.49M },
            new Item() { Id = 3, Name = "Chicken Alfredo", Price = 11.99M },
            new Item() { Id = 4, Name = "Veggie Delight", Price = 12.49M },
        };
    }
}
