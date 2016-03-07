using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedisTrial.Startup))]
namespace RedisTrial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
