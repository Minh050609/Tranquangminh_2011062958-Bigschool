using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tranquangminh_2011062958.Startup))]
namespace Tranquangminh_2011062958
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
