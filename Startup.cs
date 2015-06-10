using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(forealx.Startup))]
namespace forealx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
