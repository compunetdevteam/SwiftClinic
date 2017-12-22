using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SwiftClinic.Startup))]
namespace SwiftClinic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
