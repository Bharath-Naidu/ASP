using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_22_9_2018_Authencation2._0.Startup))]
namespace _22_9_2018_Authencation2._0
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
