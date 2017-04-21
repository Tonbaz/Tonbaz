using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CssMediaQuery.Startup))]
namespace CssMediaQuery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
