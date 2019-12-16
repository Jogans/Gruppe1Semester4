using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(GuldtandMVC_Identity.Areas.Identity.IdentityHostingStartup))]
namespace GuldtandMVC_Identity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}