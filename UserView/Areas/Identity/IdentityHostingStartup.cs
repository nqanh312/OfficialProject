[assembly: HostingStartup(typeof(UserView.Areas.Identity.IdentityHostingStartup))]
namespace UserView.Areas.Identity
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
