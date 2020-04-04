using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SantoriniDream.Startup))]
namespace SantoriniDream
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
