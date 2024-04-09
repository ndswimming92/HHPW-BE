using System.ComponentModel.DataAnnotations;

namespace HHPW_BE.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<OrderItem> Orders { get; set; } = new List<OrderItem>();
    }
}
