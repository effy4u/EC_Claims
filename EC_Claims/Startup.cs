using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EC_Claims.Startup))]
namespace EC_Claims
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
