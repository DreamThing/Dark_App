using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(App1.MobileAppService.Startup))]

namespace App1.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}