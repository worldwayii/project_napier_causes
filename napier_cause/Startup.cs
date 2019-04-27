using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(napier_cause.Startup))]
namespace napier_cause
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
