using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P2Place_Webdev.Data;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IWebHostEnvironment;
using P2Place_Webdev.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace P2Place_Webdev.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly P2PlaceDbContext _dbcontext;
        private IHostingEnvironment _environment;
        private UserManager<ApplicationUser> _usermanager;

        public HomeController(P2PlaceDbContext dbcontext, IHostingEnvironment environment, UserManager<ApplicationUser> usermanager, SignInManager<ApplicationUser> signinmanager)
        {
            _dbcontext = dbcontext;
            _environment = environment;
            _usermanager = usermanager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var adverts = await _dbcontext.Adverts.OrderBy(x => x.CreatedAt).ToListAsync();
            return View(adverts);
        }

        public IActionResult Create_Advert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create_Advert(Advert advert, IFormFile postedFile)
        {
            if (postedFile != null && postedFile.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    postedFile.CopyTo(stream);
                    advert.Photo = stream.ToArray();
                }
            }
            else
            {
                ModelState.AddModelError("Photo", "Please select a photo");
                return View();
            }

            if (ModelState.IsValid)
            {
                var currentuser = await _usermanager.GetUserAsync(User);
                advert.Id = Guid.NewGuid().ToString();
                advert.CreatedAt = DateTime.Now;
                advert.UserId = currentuser.Id;
                advert.UserEmail = currentuser.Email;

                string path = Path.Combine(this._environment.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                _dbcontext.Adverts.Add(advert);
                _dbcontext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contactform form)
        {
            if(ModelState.IsValid)
            {
                form.Id = Guid.NewGuid().ToString();
                form.CreatedAt = DateTime.Now;
                _dbcontext.Contactforms.Add(form);
                _dbcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
