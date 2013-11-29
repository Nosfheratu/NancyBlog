using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Nancy.ModelBinding;
using Nancy.Validation;

using Nancy.Demo.NancyBlog.Data.Entities;
using Nancy.Demo.NancyBlog.Data.Repositories;

namespace Nancy.Demo.NancyBlog.Web.Modules
{
    public class PostsModule : NancyModule
    {
        public PostsModule()
        {
            var postsRepository = new PostsRepository();
            var authorsRepository = new AuthorsRepository();
            var blogsRepository = new BlogsRepository();

            Get["/Posts"] = p =>
            {
                var posts = postsRepository.GetAll();
                
                return View["Posts/index", new { Posts = posts, Title = "Nancy Blog", Description = "A simple blog demo built with Nancy" }];
            };

            Get["/Posts/{id}"] = p =>
            {
                var post = postsRepository.Find(p.id);
                
                return View["Posts/show", new { Post = post, Title = "Nancy Blog", Description = "A simple blog demo built with Nancy" }];
            };

            Get["/Posts/New"] = p =>
            {
                var post = new Post();

                var author = authorsRepository.Find(1);

                var blog = blogsRepository.Find(1);

                return View["Posts/new", new { Post = post, Author = author, Blog = blog, Title = "Nancy Blog", Description = "A simple blog demo built with Nancy", Action = "Create" }];
            };

            Post["/Posts/Create"] = p =>
            {
                Post post = this.Bind();

                var addedPost = postsRepository.Add(post);

                if (post.PostId != addedPost.PostId)
                {
                    return Response.AsRedirect("/Posts");
                }

                return View[""];
            };

            Get["/Posts/{id}/Edit"] = p =>
            {
                var post = postsRepository.Find(p.id);

                var author = authorsRepository.Find(1);

                var blog = blogsRepository.Find(1);

                return View["Posts/edit", new { Post = post, Author = author, Blog = blog, Title = "Nancy Blog", Description = "A simple blog demo built with Nancy", Action = p.id + "/Update" }];
            };

            Post["/Posts/Update"] = p =>
            {
                Post post = this.Bind();

                var modifiedPost = postsRepository.Update(post);

                if (true)
                {
                    return Response.AsRedirect("/Posts");
                }

                return View[""];
            };
        }
    }
}
