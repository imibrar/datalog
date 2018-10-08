using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataLog.Startup))]
namespace DataLog
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
