using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingSite.Models
{
    public class RegisterViewModel // tip : The class name is different from the class file name
    {

        [MaxLength(300)]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "تکرار کلمه عبور")]
        public string RePassword { get; set; }
    }

    public class LoginViewModel
    {
        [MaxLength(300)]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار ")]
        public bool RememberMe { get; set; }
    }
}
