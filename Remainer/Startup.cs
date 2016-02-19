using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Remainer.Startup))]
namespace Remainer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
