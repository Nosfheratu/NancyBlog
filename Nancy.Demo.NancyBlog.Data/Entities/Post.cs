using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Demo.NancyBlog.Data.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        
        public string Title { get; set; }

        public string Body { get; set; }

        public IList<Comment> Comments { get; set; }

        public Author Author { get; set; }

        public Blog Blog { get; set; }

        public int AuthorId { get; set; }

        public int BlogId { get; set; }
    }
}
