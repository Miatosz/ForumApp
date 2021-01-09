using System;

namespace ForumApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Content {get; set;}
        
        public int AuthorId {get; set;}
        public User Author {get; set;}

        

    }
}