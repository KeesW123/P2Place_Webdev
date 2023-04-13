using System.ComponentModel.DataAnnotations;

namespace P2Place_Webdev.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Please fill in an Emailaddress.")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please fill in a Password.")]
        public string Password { get; set; }
    }
}
