using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Demo.NancyBlog.Data.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Bio { get; set; }

        public IList<Post> Posts { get; set; }
    }
}
