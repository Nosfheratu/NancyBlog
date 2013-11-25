using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Nancy.Demo.NancyBlog.Data.Entities;
using Simple.Data;

namespace Nancy.Demo.NancyBlog.Data.Repositories
{
    public class PostsRepository
    {
        private dynamic db = Database.OpenNamedConnection("NancyBlog");
        
        public dynamic Find(int id)
        {
            return new NotImplementedException();
        }

        public List<dynamic> GetAll()
        {
            return db.Posts.All();
        }
    }
}
