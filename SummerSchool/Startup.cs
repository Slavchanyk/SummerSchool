using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SummerSchool.Startup))]
namespace SummerSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
