using System;

namespace ForumApp.Models.ViewModels
{
    public class ReplyViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Post Post {get; set;}
    }
}