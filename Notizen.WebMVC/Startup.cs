using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Notizen.WebMVC.Startup))]
namespace Notizen.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
