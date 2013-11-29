using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Nancy.Demo.NancyBlog.Data.Entities;
using Simple.Data;

namespace Nancy.Demo.NancyBlog.Data.Repositories
{
    public class AuthorsRepository
    {
        private dynamic db = Database.OpenNamedConnection("NancyBlog");
        
        public dynamic Find(int id)
        {
            dynamic author = this.db.Authors.FindByAuthorId(id);
            return author;
        }

        public List<dynamic> GetAll()
        {
            return this.db.Authors.All();
        }

        public dynamic Add(dynamic author)
        {
            var addedAuthor = this.db.Authors.Insert(author);
            return addedAuthor;
        }

        public dynamic Update(dynamic author)
        {
            this.db.Authors.Update(author);
            return author;
        }

        public void Remove(int id)
        {
            this.db.Authors.DeleteByAuthorId(id);
        }
    }
}
