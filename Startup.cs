using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demoMvc.Startup))]
namespace demoMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
