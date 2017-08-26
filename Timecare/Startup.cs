using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Timecare.Startup))]
namespace Timecare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
