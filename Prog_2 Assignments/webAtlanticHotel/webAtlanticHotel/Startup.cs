using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webAtlanticHotel.Startup))]
namespace webAtlanticHotel
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
