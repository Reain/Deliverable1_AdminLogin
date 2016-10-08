using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SNCR_Login.Startup))]
namespace SNCR_Login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
