using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(todooXamarinService.Startup))]

namespace todooXamarinService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}