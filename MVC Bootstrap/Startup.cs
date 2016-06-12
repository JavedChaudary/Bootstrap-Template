using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Bootstrap.Startup))]
namespace MVC_Bootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
