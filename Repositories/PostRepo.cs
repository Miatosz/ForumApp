using System.Collections.Generic;
using System.Linq;
using ForumApp.Data;
using ForumApp.Models;

namespace ForumApp.Repositories
{
    public class PostRepo : IPostRepo
    {
        private ForumDbContext _context;

        public PostRepo(ForumDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Post> Posts => _context.Posts;

        public void SavePost(Post post)
        {
            if (post.Id == 0)
            {
                _context.Posts.Add(post);
            }
            else
            {
                Post newPost = _context.Posts.FirstOrDefault(c => c.Id == post.Id);
            
                if (newPost != null)
                {
                    newPost.Author = post.Author;
                    newPost.AuthorId = post.AuthorId;
                    newPost.Content = post.Content;
                    newPost.Date = post.Date; 
                }
            }
            _context.SaveChanges();
        }
    }
}