using System.Collections.Generic;
using ForumApp.Models;

namespace ForumApp.Repositories
{
    public interface ICategoryRepo
    {
         IEnumerable<Category> Categories {get;}
    }
}