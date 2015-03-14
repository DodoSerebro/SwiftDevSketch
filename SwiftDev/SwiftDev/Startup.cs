using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SwiftDev.Startup))]
namespace SwiftDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
