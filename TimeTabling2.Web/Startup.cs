using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeTabling2.Web.Startup))]
namespace TimeTabling2.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
