using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DanceCommunity.Startup))]
namespace DanceCommunity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
