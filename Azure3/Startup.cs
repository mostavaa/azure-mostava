using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Azure3.Startup))]
namespace Azure3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
