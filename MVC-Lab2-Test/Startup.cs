using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Lab2_Test.Startup))]
namespace MVC_Lab2_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
