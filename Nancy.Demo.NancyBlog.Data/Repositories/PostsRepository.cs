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
            dynamic post = this.db.Posts.FindByPostId(id);
            return post;
        }

        public List<dynamic> GetAll()
        {
            return this.db.Posts.All();
        }

        public dynamic Add(dynamic post)
        {
            var addedPost = this.db.Posts.Insert(post);
            return addedPost;
        }

        public dynamic Update(dynamic post)
        {
            this.db.Posts.Update(post);
            return post;
        }

        public void Remove(int id)
        {
            this.db.Posts.DeleteByPostId(id);
        }
    }
}
