using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSchool.Website.Startup))]
namespace WebSchool.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
