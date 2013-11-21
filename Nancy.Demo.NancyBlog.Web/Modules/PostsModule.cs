using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Nancy.Demo.NancyBlog.Data.Entities;
using Nancy.Demo.NancyBlog.Data.Repositories;

namespace Nancy.Demo.NancyBlog.Web.Modules
{
    public class PostsModule : NancyModule
    {
        public PostsModule()
        {
            PostsRepository repository = new PostsRepository();

            Get["/Posts"] = p =>
            {
                return View["Posts/index.cshtml", repository.GetAll()];
            };

            Get["/Posts/{id}"] = p =>
            {
                var post = repository.GetById(p.id);

                return View["Posts/show.cshtml", post];
            };
        }
    }
}
