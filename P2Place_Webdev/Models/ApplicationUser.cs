using Microsoft.AspNetCore.Identity;

namespace P2Place_Webdev.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Advert> Adverts { get; set; }
    }
}
