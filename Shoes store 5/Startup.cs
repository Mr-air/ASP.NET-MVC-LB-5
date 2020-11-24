using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shoes_store_5.Startup))]
namespace Shoes_store_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
