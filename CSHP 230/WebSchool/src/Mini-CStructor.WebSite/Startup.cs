using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mini_CStructor.WebSite.Startup))]
namespace Mini_CStructor.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
