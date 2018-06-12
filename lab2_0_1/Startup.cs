using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab2_0_1.Startup))]
namespace lab2_0_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
