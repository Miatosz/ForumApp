using System.Collections.Generic;
using ForumApp.Data;
using ForumApp.Models;

namespace ForumApp.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        private ForumDbContext _context;

        public CategoryRepo(ForumDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> Categories => _context.Categories;
    }
}