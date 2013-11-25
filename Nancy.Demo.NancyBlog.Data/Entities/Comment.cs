using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Demo.NancyBlog.Data.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Body { get; set; }

        public string Author { get; set; }

        public Post Post { get; set; }
    }
}
