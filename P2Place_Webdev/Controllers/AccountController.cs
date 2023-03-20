using Microsoft.AspNetCore.Mvc;

namespace P2Place_Webdev.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult Register()
        {
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
