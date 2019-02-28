using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebStTest2.Startup))]
namespace WebStTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
