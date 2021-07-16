using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Biggschool.Startup))]
namespace Biggschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
