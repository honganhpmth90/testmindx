using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(duonghonganh_070590.Startup))]
namespace duonghonganh_070590
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
