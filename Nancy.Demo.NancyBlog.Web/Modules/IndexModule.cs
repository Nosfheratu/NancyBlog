namespace Nancy.Demo.NancyBlog.Web.Modules
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index", new { Title = "Nancy Blog", Description = "A simple blog demo built with Nancy" }];
            };
        }
    }
}