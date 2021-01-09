using System.Collections.Generic;
using ForumApp.Data;
using ForumApp.Models;

namespace ForumApp.Repositories
{
    public class UserRepo : IUserRepo
    {
        private ForumDbContext _context;

        public UserRepo(ForumDbContext context)
        {
            _context = context;
        }
        public IEnumerable<User> Users => _context.Users;
    }
}