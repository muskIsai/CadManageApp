using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CadManage.Startup))]
namespace CadManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
