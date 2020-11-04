using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarrieXPress.Startup))]
namespace BarrieXPress
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
