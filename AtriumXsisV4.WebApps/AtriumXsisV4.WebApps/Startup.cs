using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtriumXsisV4.WebApps.Startup))]
namespace AtriumXsisV4.WebApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
