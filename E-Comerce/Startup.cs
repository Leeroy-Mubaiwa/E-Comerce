using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Comerce.Startup))]
namespace E_Comerce
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
