using System.Collections.Generic;
using ForumApp.Models;

namespace ForumApp.Repositories
{
    public interface IPostRepo
    {
         IEnumerable<Post> Posts {get;}
         void SavePost(Post post);
    }
}