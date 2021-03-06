using System.Collections.Generic;

namespace ForumApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Email {get; set;}

        public List<Post> Posts {get; set;}
    }
}