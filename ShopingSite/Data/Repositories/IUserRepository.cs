using ShopingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingSite.Data.Repositories
{
    public interface IUserRepository
    {
        bool IsExistUserByEmail(string email);
        void AddUser(Users user);
         Users GetUserForLogin(string email, string password);
        //  Users GetUserForLogin()
    }

    public class UserRepository : IUserRepository
    {
        private ShopingSiteContext _context;

        public UserRepository(ShopingSiteContext context)
        {
            _context = context;
        }

        public bool IsExistUserByEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public void AddUser(Users user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public Users GetUserForLogin(string email, string password)
        {
            return _context.Users
                .SingleOrDefault(u => u.Email == email && u.Password == password);
        }
    }

}
