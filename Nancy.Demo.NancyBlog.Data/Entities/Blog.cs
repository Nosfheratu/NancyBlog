using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Demo.NancyBlog.Data.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string Name { get; set; }

        public IList<Post> Posts { get; set; }
    }
}
