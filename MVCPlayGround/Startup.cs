using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPlayGround.Startup))]
namespace MVCPlayGround
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
