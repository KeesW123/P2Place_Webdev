using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using P2Place_Webdev.Areas.Identity.Data;
using P2Place_Webdev.Models;
using System.Reflection.Emit;

namespace P2Place_Webdev.Data;

public class P2PlaceDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Advert> Adverts { get; set; }
    public DbSet<Contactform> Contactforms { get; set; }
    public P2PlaceDbContext(DbContextOptions<P2PlaceDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        var dbInitializer = new DbInitializer(builder);
        dbInitializer.Seed();
    }
}
