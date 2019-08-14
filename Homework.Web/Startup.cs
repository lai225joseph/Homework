using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homework.Web.Startup))]
namespace Homework.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
