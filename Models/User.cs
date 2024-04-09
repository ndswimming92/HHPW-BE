using System.ComponentModel.DataAnnotations;

namespace HHPW_BE.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public bool Uid { get; set; }
        public string? Name { get; set; }
    }
}
