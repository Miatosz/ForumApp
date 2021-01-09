using System;
using System.Linq;
using ForumApp.Data;
using ForumApp.Models;
using ForumApp.Models.ViewModels;
using ForumApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
// using PagedList;
using X.PagedList.Mvc.Core;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {
        private IPostRepo _repo;
        private readonly ForumDbContext _context;

        int pageSize = 10;
        


        public PostController(IPostRepo repo, ForumDbContext context)
        {
            _repo = repo;
            _context = context;
        }

        
        public ViewResult Index(int? page, int categoryId)
        {
            int pageNumber = (page ?? 1);

            return View(_context.Posts.Include(c => c.Author)
                                        .ToPagedList(pageNumber, pageSize));
        }
            

        [HttpGet]
        public ViewResult IndexByCategory(int categoryId) =>
            View(_context.Posts.Include(c => c.Author));


        
        [HttpGet]
        public ViewResult AddReply() =>
            View(new Post{
                Author = new User(),
                Date = DateTime.Now
            });    
        
        [HttpPost]
        public IActionResult AddReply(Post post)
        {


            post.Author = _context.Users.First();
            post.AuthorId = _context.Users.First().Id;
            _repo.SavePost(post);
            return RedirectToAction(nameof(Index),nameof(Category));
        }
        
        
        
        
       
    }
}