using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(napier_cause.Startup))]
namespace napier_cause
{
    public partial class Startup
    {
        public object SameSiteMode { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

      
    }

    
}
