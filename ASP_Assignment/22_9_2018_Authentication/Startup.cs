using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_22_9_2018_Authentication.Startup))]
namespace _22_9_2018_Authentication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
