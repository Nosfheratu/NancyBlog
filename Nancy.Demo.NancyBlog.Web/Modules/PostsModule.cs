﻿using System;
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
            var repository = new PostsRepository();

            Get["/Posts"] = p =>
            {
                var posts = repository.GetAll();
                return View["Posts/index", new { Posts = posts, Title = "Nancy Blog", Description = "A simple blog demo built with Nancy" }];
            };

            Get["/Posts/{id}"] = p =>
            {
                var post = repository.Find(p.id);
                return View["Posts/show", new { Post = post, Title = "Nancy Blog", Description = "A simple blog demo built with Nancy" }];
            };
        }
    }
}
