using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpManager.Startup))]
namespace ExpManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
