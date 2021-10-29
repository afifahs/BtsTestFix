using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BtsTest.Startup))]
namespace BtsTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
