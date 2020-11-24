using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoTrader.Startup))]
namespace AutoTrader
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
