using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Otaku_Amines.Startup))]
namespace Otaku_Amines
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
