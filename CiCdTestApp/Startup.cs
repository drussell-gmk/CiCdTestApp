using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CiCdTestApp.Startup))]
namespace CiCdTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
