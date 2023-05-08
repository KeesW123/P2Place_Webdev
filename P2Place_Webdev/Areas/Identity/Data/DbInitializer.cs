using Microsoft.EntityFrameworkCore;
using P2Place_Webdev.Models;

namespace P2Place_Webdev.Areas.Identity.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            _modelBuilder.Entity<Advert>().HasData(
                    new Advert { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, UserId = "c72140e7-31bd-48a4-be2f-c48a51ac3749", UserEmail="keeswijenberg@gmail.com", Photo = File.ReadAllBytes("C:\\Users\\keesw\\source\\repos\\P2Place_Webdev\\P2Place_Webdev\\wwwroot\\images\\p2place_logo.png"), Title = "Test_Title", Price = 999, Description = "Test description"},
                    new Advert { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, UserId = "c72140e7-31bd-48a4-be2f-c48a51ac3749", UserEmail="keeswijenberg@gmail.com", Photo = File.ReadAllBytes("C:\\Users\\keesw\\source\\repos\\P2Place_Webdev\\P2Place_Webdev\\wwwroot\\images\\p2place_logo.png"), Title = "Test_Title", Price = 999, Description = "Test description"},
                    new Advert { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, UserId = "c72140e7-31bd-48a4-be2f-c48a51ac3749", UserEmail="keeswijenberg@gmail.com", Photo = File.ReadAllBytes("C:\\Users\\keesw\\source\\repos\\P2Place_Webdev\\P2Place_Webdev\\wwwroot\\images\\p2place_logo.png"), Title = "Test_Title", Price = 999, Description = "Test description"},
                    new Advert { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, UserId = "c72140e7-31bd-48a4-be2f-c48a51ac3749", UserEmail="keeswijenberg@gmail.com", Photo = File.ReadAllBytes("C:\\Users\\keesw\\source\\repos\\P2Place_Webdev\\P2Place_Webdev\\wwwroot\\images\\p2place_logo.png"), Title = "Test_Title", Price = 999, Description = "Test description"},
                    new Advert { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, UserId = "c72140e7-31bd-48a4-be2f-c48a51ac3749", UserEmail="keeswijenberg@gmail.com", Photo = File.ReadAllBytes("C:\\Users\\keesw\\source\\repos\\P2Place_Webdev\\P2Place_Webdev\\wwwroot\\images\\p2place_logo.png"), Title = "Test_Title", Price = 999, Description = "Test description"},
                    new Advert { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, UserId = "c72140e7-31bd-48a4-be2f-c48a51ac3749", UserEmail="keeswijenberg@gmail.com", Photo = File.ReadAllBytes("C:\\Users\\keesw\\source\\repos\\P2Place_Webdev\\P2Place_Webdev\\wwwroot\\images\\p2place_logo.png"), Title = "Test_Title", Price = 999, Description = "Test description"},
                    new Advert { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, UserId = "c72140e7-31bd-48a4-be2f-c48a51ac3749", UserEmail="keeswijenberg@gmail.com", Photo = File.ReadAllBytes("C:\\Users\\keesw\\source\\repos\\P2Place_Webdev\\P2Place_Webdev\\wwwroot\\images\\p2place_logo.png"), Title = "Test_Title", Price = 999, Description = "Test description"},
                    new Advert { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, UserId = "c72140e7-31bd-48a4-be2f-c48a51ac3749", UserEmail="keeswijenberg@gmail.com", Photo = File.ReadAllBytes("C:\\Users\\keesw\\source\\repos\\P2Place_Webdev\\P2Place_Webdev\\wwwroot\\images\\p2place_logo.png"), Title = "Test_Title", Price = 999, Description = "Test description"},
                    new Advert { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, UserId = "c72140e7-31bd-48a4-be2f-c48a51ac3749", UserEmail="keeswijenberg@gmail.com", Photo = File.ReadAllBytes("C:\\Users\\keesw\\source\\repos\\P2Place_Webdev\\P2Place_Webdev\\wwwroot\\images\\p2place_logo.png"), Title = "Test_Title", Price = 999, Description = "Test description"},
                    new Advert { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, UserId = "c72140e7-31bd-48a4-be2f-c48a51ac3749", UserEmail="keeswijenberg@gmail.com", Photo = File.ReadAllBytes("C:\\Users\\keesw\\source\\repos\\P2Place_Webdev\\P2Place_Webdev\\wwwroot\\images\\p2place_logo.png"), Title = "Test_Title", Price = 999, Description = "Test description"}
                );
        }
    }
}
