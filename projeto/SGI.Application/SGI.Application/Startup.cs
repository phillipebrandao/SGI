using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SGI.Application.Startup))]
namespace SGI.Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
