using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealsourceMVC.Startup))]
namespace RealsourceMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
