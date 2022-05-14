using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolPortal.UIDX.Web.Startup))]
namespace SchoolPortal.UIDX.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
