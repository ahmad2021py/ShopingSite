using ShopingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingSite.Data.Repositories
{
    public interface IGroupRepository
    {
        IEnumerable<Category> GetAllCategories();
        IEnumerable<ShowGroupViewModel> GetGroupForShow();
    }

    public class GroupRepository : IGroupRepository
    {
        private ShopingSiteContext _context;

        public GroupRepository(ShopingSiteContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public IEnumerable<ShowGroupViewModel> GetGroupForShow()
        {
            return _context.Categories
                 .Select(c => new ShowGroupViewModel()
                 {
                     GroupId = c.Id,
                     Name = c.Name,
                     ProductCount = _context.CategoryToProducts.Count(g => g.CategoryId == c.Id)
                 }).ToList();
        }
    }
}
