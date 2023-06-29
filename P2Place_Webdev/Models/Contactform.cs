using System.ComponentModel.DataAnnotations;

namespace P2Place_Webdev.Models
{
    public class Contactform
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required]
        [MaxLength(200)]
        public string Subject { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(600)]
        public string Message { get; set; }
    }
}
