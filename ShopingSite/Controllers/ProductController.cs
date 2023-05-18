using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopingSite.Data;

namespace ShopingSite.Controllers
{
    public class ProductController : Controller
    {
        private ShopingSiteContext _context;

        public ProductController(ShopingSiteContext context)
        {
            _context = context;
        }

        [Route("Group/{id}/{name}")]
        public IActionResult ShowProductByGroupId(int id, string name)
        {
            ViewData["GroupName"] = name;
            var products = _context.CategoryToProducts
                .Where(c => c.CategoryId == id)
                .Include(c => c.Product)
                .Select(c => c.Product)
                .ToList();
            return View(products);
        }
    }
}
