using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200.Startup))]
namespace MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
