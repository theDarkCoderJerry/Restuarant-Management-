using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restuarant_Management.Startup))]
namespace Restuarant_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
