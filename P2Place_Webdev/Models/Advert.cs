using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace P2Place_Webdev.Models
{
    public class Advert
    {
        [Key]
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required]
        [MaxLength(10)]
        public int Price { get; set; }
        public byte[] Photo { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
