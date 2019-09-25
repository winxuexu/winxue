using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication123455.Startup))]
namespace WebApplication123455
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
