using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bomba.Startup))]
namespace Bomba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
