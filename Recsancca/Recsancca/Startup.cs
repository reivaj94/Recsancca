using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Recsancca.Startup))]
namespace Recsancca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
