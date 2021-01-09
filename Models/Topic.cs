using System.Collections.Generic;

namespace ForumApp.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Post> Posts { get; set; }

        public int CategoryId {get; set;}
        public Category Category { get; set; }
    }
}