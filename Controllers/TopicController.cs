using Microsoft.AspNetCore.Mvc;
using ForumApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using X.PagedList;




using X.PagedList.Mvc.Core;

namespace ForumApp.Controllers
{
    public class TopicController : Controller
    {     
        private readonly ForumDbContext _context;

        int pageSize = 10;
        


        public TopicController(ForumDbContext context)
        {
            _context = context;
        }

        
        // public ViewResult Index(int? page, int categoryId)
        // {
        //     int pageNumber = (page ?? 1);

        //     return View(_context.Topics.Include(c => c.Posts)
        //                                 .ThenInclude(c => c.Author)
        //                                 .Include(c => c.Category)
        //                                 .Where(c => c.CategoryId == categoryId)
        //                                 .ToPagedList(pageNumber, pageSize));
        // }
            

        [HttpPost]
        public ViewResult IndexByCategory(int? page, int categoryId)
        {
            int pageNumber = (page ?? 1);

            return View(_context.Topics.Where(c => c.CategoryId == categoryId)
                                .Include(c => c.Posts)
                                .ThenInclude(c => c.Author)
                                .Include(c => c.Category)                                
                                .ToPagedList(pageNumber, pageSize));
        }
            
    }
}
   