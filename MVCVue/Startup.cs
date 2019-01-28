using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCVue.Startup))]
namespace MVCVue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
