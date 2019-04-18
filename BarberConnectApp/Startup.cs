using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarberConnectApp.Startup))]
namespace BarberConnectApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
