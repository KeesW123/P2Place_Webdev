using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P2Place_Webdev.Models;

namespace P2Place_Webdev.Data;

public class P2PlaceDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Advert> Adverts { get; set; }
    public P2PlaceDbContext(DbContextOptions<P2PlaceDbContext> options)
        : base(options)
    {
    }
}
