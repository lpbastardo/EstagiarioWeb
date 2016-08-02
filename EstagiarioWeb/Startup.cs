using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstagiarioWeb.Startup))]
namespace EstagiarioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
