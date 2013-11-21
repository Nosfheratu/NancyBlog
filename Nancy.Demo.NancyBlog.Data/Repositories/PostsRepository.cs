using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Nancy.Demo.NancyBlog.Data.Entities;

namespace Nancy.Demo.NancyBlog.Data.Repositories
{
    public class PostsRepository
    {
        private List<Post> Posts;

        public PostsRepository()
        {
            Posts = new List<Post>
            {
                new Post(){Id = 1, Title="First Post", Body="This is the first Post", Author="FSC"},
                new Post(){Id = 2, Title="Second Post", Body="This is the second Post", Author="FSC"},
                new Post(){Id = 3, Title="Third Post", Body="This is the third Post", Author="FSC"}
            };
        }

        public List<Post> GetAll()
        {
            return Posts;
        }

        public Post GetById(int id)
        {
            return Posts.FirstOrDefault(p => p.Id == id);
        }
    }
}
