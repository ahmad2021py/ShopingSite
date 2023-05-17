
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopingSite.Data;

namespace ShopingSite.Components
{
    public class ProductGroupsComponent : ViewComponent
    {
        private ShopingSiteContext _context;

        public ProductGroupsComponent(ShopingSiteContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Components/ProductGroupsComponent.cshtml", _context.Categories);
        }
    }
}
