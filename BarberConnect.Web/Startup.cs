using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarberConnect.Web.Startup))]
namespace BarberConnect.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
