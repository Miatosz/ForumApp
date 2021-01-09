using ForumApp.Data;
using ForumApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace ForumApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ForumDbContext _context;
        private readonly ICategoryRepo _repo;

        

        public CategoryController(ForumDbContext context, ICategoryRepo repo)
        {
            _context = context;
            _repo = repo;
        }

        public ViewResult Index(int? page)
        {

            return View(_context.Categories.Include(c => c.Posts).ThenInclude(c => c.Author));
        }
            
    }
}