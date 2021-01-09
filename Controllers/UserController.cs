using System.Linq;
using ForumApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ForumApp.Controllers
{
    public class UserController : Controller
    {
        private IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public ViewResult Index() =>
            View(_userRepo.Users);

        
    }
}