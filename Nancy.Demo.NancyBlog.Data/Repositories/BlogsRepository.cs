using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Nancy.Demo.NancyBlog.Data.Entities;
using Simple.Data;

namespace Nancy.Demo.NancyBlog.Data.Repositories
{
    public class BlogsRepository
    {
        private dynamic db = Database.OpenNamedConnection("NancyBlog");
        
        public dynamic Find(int id)
        {
            dynamic blog = this.db.Blogs.FindByBlogId(id);
            return blog;
        }

        public List<dynamic> GetAll()
        {
            return this.db.Blogs.All();
        }

        public dynamic Add(dynamic blog)
        {
            var addedBlog = this.db.Blogs.Insert(blog);
            return addedBlog;
        }

        public dynamic Update(dynamic blog)
        {
            this.db.Blogs.Update(blog);
            return blog;
        }

        public void Remove(int id)
        {
            this.db.Blogs.DeleteByBlogId(id);
        }
    }
}
