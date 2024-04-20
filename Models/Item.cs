using System.ComponentModel.DataAnnotations;

namespace HHPW_BE.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public decimal Price { get; set; }
       
    }
}
