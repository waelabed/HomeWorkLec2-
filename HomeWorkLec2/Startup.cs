using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeWorkLec2.Startup))]
namespace HomeWorkLec2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
