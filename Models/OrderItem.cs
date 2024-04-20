namespace HHPW_BE.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        
        public Item? Item { get; set; }

        public int Amount { get; set; }

        public Order Order { get; set; }

    }
}
