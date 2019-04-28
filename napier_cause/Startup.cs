using Microsoft.Owin;
using Owin;
using napier_cause.Models;
using Microsoft.EntityFrameworkCore;
using napier_cause.DAC;
using Microsoft.Extensions.DependencyInjection;

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

        public void ConfigureServices(IServiceCollection services)
        {
             
            

            var connection = @"Server=(localdb)\mssqllocaldb;Database=napier_cause.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<CauseDBContext>(options => options.UseSqlServer(connection));
                
            // BloggingContext requires
            // using EFGetStarted.AspNetCore.NewDb.Models;
            // UseSqlServer requires
            // using Microsoft.EntityFrameworkCore;
        }
    }

    
}
