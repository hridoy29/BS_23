using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BS_23.Startup))]
namespace BS_23
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
