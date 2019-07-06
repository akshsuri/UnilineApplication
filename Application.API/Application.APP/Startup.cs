using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Application.APP.Startup))]
namespace Application.APP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
