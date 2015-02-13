using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineWeek4Day4.Startup))]
namespace OnlineWeek4Day4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
