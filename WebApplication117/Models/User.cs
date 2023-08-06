using System.ComponentModel.DataAnnotations;

namespace WebApplication117.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone number is wrong")]
        public int Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }

    }
}
