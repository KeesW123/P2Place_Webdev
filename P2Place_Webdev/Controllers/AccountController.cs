using Microsoft.AspNetCore.Mvc;
using P2Place_Webdev.Models;

namespace P2Place_Webdev.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLogin userLogin)
        {
            if (ModelState.IsValid)
            {
                //validate if password matches email (make a call to database)
                return RedirectToAction("Index", "Home", null);
            }
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegister userRegister)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home", null);
            }
            return View();
        }

        public IActionResult LostPassword()
        {
            return View();
        }

        public IActionResult YourAccount()
        {
            return View();
        }
    }
}
