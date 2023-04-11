using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESH_Nobet.Startup))]
namespace ESH_Nobet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
