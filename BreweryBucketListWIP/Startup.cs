using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BreweryBucketListWIP.Startup))]
namespace BreweryBucketListWIP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
