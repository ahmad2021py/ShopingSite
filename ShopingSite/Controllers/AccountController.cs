using Microsoft.AspNetCore.Mvc;
using ShopingSite.Data.Repositories;
using ShopingSite.Models;
using System;

namespace ShopingSite.Controllers
{

    public class AccountController : Controller
    {
        private IUserRepository _userRepository;

        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
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

            if (_userRepository.IsExistUserByEmail(register.Email.ToLower()))
            {
                ModelState.AddModelError("Email", "ایمیل وارد شده قبلا ثبت نام کرده است");
                return View(register);
            }

            Users user = new Users()
            {
                Email = register.Email.ToLower(),
                Password = register.Password,
                IsAdmin = false,
                RegisterDate = DateTime.Now
            };

            _userRepository.AddUser(user);

            return View("SuccessRegister", register);
        }
    }
}
