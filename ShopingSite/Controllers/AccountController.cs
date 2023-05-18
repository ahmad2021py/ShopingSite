using Microsoft.AspNetCore.Mvc;
using ShopingSite.Models;

namespace ShopingSite.Controllers
{

    public class AccountController : Controller
    {
        public IActionResult Register() // this method by default is HttpGet
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            return View();
        }
    }
}
