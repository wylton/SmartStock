using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartMvc.Admin.Startup))]
namespace SmartMvc.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}