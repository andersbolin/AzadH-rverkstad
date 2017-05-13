using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzadHarVerkstad.Startup))]
namespace AzadHarVerkstad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
