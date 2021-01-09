using System.Collections.Generic;
using ForumApp.Models;

namespace ForumApp.Repositories
{
    public interface IUserRepo
    {
         IEnumerable<User> Users {get;}
         
    }
}