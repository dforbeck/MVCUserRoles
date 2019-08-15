using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCUserRole.WebMVC.Startup))]
namespace MVCUserRole.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
