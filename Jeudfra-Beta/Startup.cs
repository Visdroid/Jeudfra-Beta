using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jeudfra_Beta.Startup))]
namespace Jeudfra_Beta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
