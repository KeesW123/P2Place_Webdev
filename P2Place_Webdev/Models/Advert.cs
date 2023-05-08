using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace P2Place_Webdev.Models
{
    public class Advert
    {
        [Key]
        [ValidateNever]
        public string Id { get; set; }
        [ValidateNever]
        public DateTime CreatedAt { get; set; }
        [Required]
        [Range(0, 9999999)]
        public int Price { get; set; }
        public byte[]? Photo { get; set; }
        [Required]
        [MaxLength(40)]
        public string Description { get; set; }
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }
        [ValidateNever]
        public string UserId { get; set; }
        [ValidateNever]
        public string UserEmail { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public ApplicationUser User { get; set; }
    }
}
