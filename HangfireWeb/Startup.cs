using Hangfire;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HangfireWeb.Startup))]
namespace HangfireWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage("Server=(localdb)\\MSSQLLocalDB;Integrated Security=true");

            app.UseHangfireDashboard();
        }
    }
}
