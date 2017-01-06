using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TamagotchiWebApp.Startup))]
namespace TamagotchiWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
