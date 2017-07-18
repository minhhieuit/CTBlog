using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CTBlog.Startup))]
namespace CTBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
