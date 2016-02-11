using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(homeWVSCA.Startup))]
namespace homeWVSCA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
