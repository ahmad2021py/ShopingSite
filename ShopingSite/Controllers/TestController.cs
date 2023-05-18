using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ShopingSite.Controllers
{
    [Authorize] // only logined user allow to get this action
    public class TestController : Controller
    {
       public string Test1()
       {
           return "Test 1";
       }

       [AllowAnonymous] // all users allow to get this action
       public string Test2()
       {
           return "Test 2";
       }
    }
}
