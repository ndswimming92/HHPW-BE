namespace HHPW_BE.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order? OrderId { get; set; }
        public Item? ItemId { get; set; }
    }
}
