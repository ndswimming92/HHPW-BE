namespace HHPW_BE.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order? Order { get; set; }
        public Item? Item { get; set; }
        public decimal? Price
        {
            get
            {
                return Item?.Price;
            }
        }
    }
}
