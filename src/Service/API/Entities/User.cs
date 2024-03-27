using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
