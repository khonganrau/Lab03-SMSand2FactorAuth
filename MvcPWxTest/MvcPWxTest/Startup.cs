using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPWxTest.Startup))]
namespace MvcPWxTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
