using System.ComponentModel.DataAnnotations;

namespace HHPW_BE.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Uid { get; set; }
        public bool? Cashier { get; set; }
    }
}
