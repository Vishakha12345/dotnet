using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAsyncWebApp.Startup))]
namespace TestAsyncWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
