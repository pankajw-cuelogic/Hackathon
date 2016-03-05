using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hackathon.DMS.Web.Startup))]
namespace Hackathon.DMS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
