using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_DemoDRUDUsingEF.Startup))]
namespace MVC_DemoDRUDUsingEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
