using System.ComponentModel.DataAnnotations;

namespace HHPW_BE.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool? Status { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? OrderType { get; set; }
        public string? PaymentType { get; set; }
        public decimal? Tip { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Total {
            get
            {
                return Subtotal + Tip;
            }
        }
        public List<OrderItem>? Items { get; set; }
        public decimal? Subtotal
        {
            get
            {
                return Items.Sum(item => item.Price);
            }
        }
    }
};