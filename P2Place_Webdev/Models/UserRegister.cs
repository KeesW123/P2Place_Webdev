using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P2Place_Webdev.Models
{
    public class UserRegister
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please fill in a Firstname.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please fill in an Emailaddress.")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please fill in a Password.")]
        public string Password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Please fill in a Confirm Password.")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }

        ICollection<Advert> Adverts { get; set; }
    }
}
