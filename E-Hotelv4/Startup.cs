using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Hotelv4.Startup))]
namespace E_Hotelv4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
