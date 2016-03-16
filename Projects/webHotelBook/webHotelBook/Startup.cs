using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webHotelBook.Startup))]
namespace webHotelBook
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
